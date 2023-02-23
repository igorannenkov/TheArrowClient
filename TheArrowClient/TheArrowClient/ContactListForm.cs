using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;

namespace TheArrowClient
{
    public enum MessageType
    {
        SystemMessage,
        ContactListRenewMessage,
        TextMessage
    }
    public partial class ContactListForm : Form
    {
        List<LiteEmployee> clients = new List<LiteEmployee>();
        public ContactListForm()
        {
            InitializeComponent();
            
           
        }

        private async void TestConnectionAsync()
        {
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync("127.0.0.1", 8888);
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                this.Text =  reader.ReadLine();
            }
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                ChatForm chatForm = new ChatForm();
                chatForm.Text = e.Node.Text;
                chatForm.StartPosition = FormStartPosition.CenterScreen;
                chatForm.Show(); 
            }
        }

        public string[] GetNodeNames(TreeNode node)
        {
             string[] GetNodeNamesRecursive(TreeNode treeNode, ref List<string> nodesNames)
             {
                if (treeNode.Nodes.Count == 0)
                {
                    nodesNames.Add(treeNode.Text);
                }

                foreach (TreeNode subnode in treeNode.Nodes)
                {
                    GetNodeNamesRecursive(subnode, ref nodesNames);
                }

                return nodesNames.ToArray();
             }

            List<string> names = new List<string>();

            if (node.Nodes.Count == 0)
            {
                names.Add(node.Text); 
            }

            foreach (TreeNode subnode in node.Nodes)
            {
                GetNodeNamesRecursive(subnode, ref names);
            }

            return names.ToArray();
        }     

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string[] allNodesNames = GetNodeNames(treeView1.Nodes[0]);
            List<string> newCollection = new List<string>();
            foreach (string s in allNodesNames)
            {
                if (s.ToUpper().Contains(comboBox1.Text.ToUpper()))
                {
                    newCollection.Add(s);
                }
            }

            string oldText = comboBox1.Text;
            comboBox1.DroppedDown = true;
            comboBox1.DataSource = newCollection.ToArray();
            comboBox1.Text = oldText;                     
            comboBox1.SelectionStart = comboBox1. Text.Length;
        }

        private TreeNode FIndNodeByText(TreeNodeCollection nodes, string searchText)
        {
            TreeNode foundNode = null;
            bool isNodeFound = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Text == searchText)
                {
                    isNodeFound = true;
                    foundNode = node;

                    return foundNode;
                }

                if (!isNodeFound)
                {
                    foundNode = FIndNodeByText(node.Nodes, searchText);

                    if (foundNode != null)
                    {
                        return foundNode;
                    }
                }
            }
            return null;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                TreeNode node = FIndNodeByText(treeView1.Nodes, comboBox1.Text);
                treeView1.Focus();
                treeView1.SelectedNode = node;
            }
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (treeView1.SelectedNode.Nodes.Count == 0)
                {
                    ChatForm chatForm = new ChatForm();
                    chatForm.Text = treeView1.SelectedNode.Text;
                    chatForm.StartPosition = FormStartPosition.CenterScreen;
                    chatForm.Show();
                }
            }
        }

        private void ContactListForm_Load(object sender, EventArgs e)
        {
            
        }

        private async void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            TcpClient client = new TcpClient("192.168.0.103", 9999);//адрес сервера
            //client.Connect("127.0.0.1", 9999);
            string clientInfo = JsonConvert.SerializeObject(new LiteEmployee("Пушкин", "Александр", "Сергеевич", "192.168.0.112"));//свой адрес

            Message msgOut = new Message(MessageType.SystemMessage, clientInfo);


            string msgToSend = JsonConvert.SerializeObject(msgOut);
            StreamWriter writer = new StreamWriter(client.GetStream());
            writer.WriteLine(msgToSend);
            writer.Flush();
            writer.Close();


            TcpListener listener = new TcpListener(IPAddress.Any, 8888);
            listener.Start();
                while (true)
                {
                    TcpClient systemclient = await listener.AcceptTcpClientAsync();
                    NetworkStream stream = systemclient.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    string lineToDeserialize = reader.ReadLine();
                    Message inputMsg = JsonConvert.DeserializeObject<Message>(lineToDeserialize);

                    switch (inputMsg.msgType)
                    {
                        case MessageType.SystemMessage:
                            // Добавить в список клиента
                            // Разослать всем подключенным клиентам новый список
                            clients = JsonConvert.DeserializeObject<List<LiteEmployee>>(inputMsg.msgData);
                            treeView1.Nodes.Clear();
                            for (int i = 0; i < clients.Count; i++)
                            {
                                TreeNode node = new TreeNode(clients[i].lastName + " " + clients[i].firstName[0] + "." + clients[i].middleName[0]+ ".");
                                treeView1.Nodes.Add(node);
                            }

                            break;
                        case MessageType.TextMessage: break;
                    }
                }
            
        }
    }
}

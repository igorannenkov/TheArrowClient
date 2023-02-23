using System.Collections.Generic;
using System.Windows.Forms;

namespace TheArrowClient
{
    partial class ContactListForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Петров");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Сидоров");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Смирнов");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Кактусов");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Иванкин");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Иванов");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Петин");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Петина");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Петрович");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("П");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Аб");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Абвг");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Абвгд");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Абвгде");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Абвгдеж");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Список контактов", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 690);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownHeight = 150;
            this.comboBox1.DropDownWidth = 250;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(0, 12);
            this.comboBox1.MaxDropDownItems = 7;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(0, 38);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Петров";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Сидоров";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "Смирнов";
            treeNode4.Name = "Узел6";
            treeNode4.Text = "Кактусов";
            treeNode5.Name = "Узел13";
            treeNode5.Text = "Иванкин";
            treeNode6.Name = "Узел0";
            treeNode6.Text = "Иванов";
            treeNode7.Name = "Узел15";
            treeNode7.Text = "Петин";
            treeNode8.Name = "Узел16";
            treeNode8.Text = "Петина";
            treeNode9.Name = "Узел18";
            treeNode9.Text = "Петрович";
            treeNode10.Name = "Узел21";
            treeNode10.Text = "П";
            treeNode11.Name = "Узел22";
            treeNode11.Text = "Аб";
            treeNode12.Name = "Узел23";
            treeNode12.Text = "Абвг";
            treeNode13.Name = "Узел24";
            treeNode13.Text = "Абвгд";
            treeNode14.Name = "Узел25";
            treeNode14.Text = "Абвгде";
            treeNode15.Name = "Узел26";
            treeNode15.Text = "Абвгдеж";
            treeNode16.Name = "Узел1";
            treeNode16.Text = "Список контактов";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(311, 651);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // ContactListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 712);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ContactListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стрела 0.0.1";
            this.Load += new System.EventHandler(this.ContactListForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}


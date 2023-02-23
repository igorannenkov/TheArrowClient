using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheArrowClient
{
    internal class Message
    {     
        public string msgData;
        public MessageType msgType;

        public Message(MessageType msgType, string msgData)
        {
            this.msgType = msgType;
            this.msgData = msgData;
        }
    }
}

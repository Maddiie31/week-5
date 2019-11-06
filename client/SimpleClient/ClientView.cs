using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleClient
{
    public partial class ClientView : Form
    {
        private ClientController cc;
        private delegate void AddListBoxItemDelegate(object item);

        public ClientView()
        {
            InitializeComponent();
            cc = new ClientController(this); // new
        }

        private void btnServerConnect_Click(object sender, EventArgs e)
        {
            if (cc.ConnectToServer(tbxServerIP.Text, tbxServerPort.Text))
            {
                AddListBoxItem("Connected to server...");
            }
            else {
                AddListBoxItem("Could not connect to server...");
            }
        }

        private void btnServerDisconnect_Click(object sender, EventArgs e)
        {
            cc.Disconnect();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            cc.ExchangeMessage(tbxOutboundMessage.Text);
        }

        private void AddListBoxItem(object item) {
            if (this.lbxServerMessages.InvokeRequired)
            {
                this.lbxServerMessages.Invoke(new AddListBoxItemDelegate(this.AddListBoxItem), item);
            }
            else {
                this.lbxServerMessages.Items.Add(item);
            }
        }

        public void IncomingMessage(string pMessage) {
            AddListBoxItem(pMessage);
        }
        // new
        public void ConnectionLost() {
            IncomingMessage("Connection to server lost...");
        }

        public void ConnectionClosed() {
            IncomingMessage("Connection to server closed...");

        }
    }
}

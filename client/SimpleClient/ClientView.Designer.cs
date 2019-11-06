namespace SimpleClient
{
    partial class ClientView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxServerIP = new System.Windows.Forms.TextBox();
            this.tbxServerPort = new System.Windows.Forms.TextBox();
            this.btnServerConnect = new System.Windows.Forms.Button();
            this.btnServerDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOutboundMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxServerMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Server Port:";
            // 
            // tbxServerIP
            // 
            this.tbxServerIP.Location = new System.Drawing.Point(110, 8);
            this.tbxServerIP.Name = "tbxServerIP";
            this.tbxServerIP.Size = new System.Drawing.Size(173, 20);
            this.tbxServerIP.TabIndex = 2;
            // 
            // tbxServerPort
            // 
            this.tbxServerPort.Location = new System.Drawing.Point(110, 34);
            this.tbxServerPort.Name = "tbxServerPort";
            this.tbxServerPort.Size = new System.Drawing.Size(173, 20);
            this.tbxServerPort.TabIndex = 3;
            // 
            // btnServerConnect
            // 
            this.btnServerConnect.Location = new System.Drawing.Point(29, 68);
            this.btnServerConnect.Name = "btnServerConnect";
            this.btnServerConnect.Size = new System.Drawing.Size(298, 22);
            this.btnServerConnect.TabIndex = 4;
            this.btnServerConnect.Text = "Connect to server";
            this.btnServerConnect.UseVisualStyleBackColor = true;
            this.btnServerConnect.Click += new System.EventHandler(this.btnServerConnect_Click);
            // 
            // btnServerDisconnect
            // 
            this.btnServerDisconnect.Location = new System.Drawing.Point(29, 97);
            this.btnServerDisconnect.Name = "btnServerDisconnect";
            this.btnServerDisconnect.Size = new System.Drawing.Size(298, 23);
            this.btnServerDisconnect.TabIndex = 5;
            this.btnServerDisconnect.Text = "Disconnect from server";
            this.btnServerDisconnect.UseVisualStyleBackColor = true;
            this.btnServerDisconnect.Click += new System.EventHandler(this.btnServerDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message to send";
            // 
            // tbxOutboundMessage
            // 
            this.tbxOutboundMessage.Location = new System.Drawing.Point(13, 152);
            this.tbxOutboundMessage.Name = "tbxOutboundMessage";
            this.tbxOutboundMessage.Size = new System.Drawing.Size(331, 20);
            this.tbxOutboundMessage.TabIndex = 7;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(32, 182);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(294, 21);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "Send message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Server response";
            // 
            // lbxServerMessages
            // 
            this.lbxServerMessages.FormattingEnabled = true;
            this.lbxServerMessages.Location = new System.Drawing.Point(10, 238);
            this.lbxServerMessages.Name = "lbxServerMessages";
            this.lbxServerMessages.Size = new System.Drawing.Size(333, 82);
            this.lbxServerMessages.TabIndex = 10;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 331);
            this.Controls.Add(this.lbxServerMessages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbxOutboundMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnServerDisconnect);
            this.Controls.Add(this.btnServerConnect);
            this.Controls.Add(this.tbxServerPort);
            this.Controls.Add(this.tbxServerIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientView";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxServerIP;
        private System.Windows.Forms.TextBox tbxServerPort;
        private System.Windows.Forms.Button btnServerConnect;
        private System.Windows.Forms.Button btnServerDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOutboundMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxServerMessages;
    }
}


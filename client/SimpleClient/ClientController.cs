using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace SimpleClient
{
    class ClientController
    {
        private TcpClient client;
        private NetworkStream clientStream;
        ASCIIEncoding encoder;
        ClientView host;
        IPEndPoint serverEndPoint;
        Thread serverThread; //new

        public ClientController(ClientView pHost)
        {
            this.host = pHost;
            encoder = new ASCIIEncoding(); // new
        }

        public bool ConnectToServer(string pStrIP, string pStrPort) {
            client = new TcpClient();
            serverEndPoint = new IPEndPoint(IPAddress.Parse(pStrIP), Int32.Parse(pStrPort));
            try
            {
                client.Connect(serverEndPoint);
                return true;
            }
            catch {
                return false;
            }
        }
        public void Disconnect() {
            client.Close();
            host.ConnectionClosed();
        }
        public void ExchangeMessage(string pMessage) {
            clientStream = client.GetStream();
            byte[] buffer = encoder.GetBytes(pMessage);
            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
            buffer = null;
            if(serverThread == null) {
                serverThread = new Thread(new ThreadStart(HandleServerComm));
                serverThread.Start();
            }
        }
        private void HandleServerComm() {
            byte[] message = new byte[4096];
            int bytesRead;
            while (true) {
                bytesRead = 0;
                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch {
                    host.ConnectionLost();            
                    break;
                }

                if (bytesRead == 0) {
                    host.ConnectionClosed();
                    break;
                }
                string incomingMessage = encoder.GetString(message, 0, bytesRead);
                if (incomingMessage == "Disconnect")
                {
                    host.IncomingMessage("Disconnect has occurred");
                    Disconnect();
                    break;
                }
                else { 
                  host.IncomingMessage(encoder.GetString(message, 0, bytesRead));
                }
            }
        }
    }
}
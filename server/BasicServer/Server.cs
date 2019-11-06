using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Collections;

namespace BasicServer
{
    class Server
    {
        private int port;
        private TcpListener tcpListener;
        private Thread listenThread;
        private ArrayList clients = new ArrayList();

        public Server(int pPort) {
            port = pPort;
        }

        // get the IP address
        public void PublishIP() {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList) {
                Console.WriteLine("{0} : {1}", ip.AddressFamily.ToString(), ip.ToString());
            }        
        }

        public void StartServer() {
            this.tcpListener = new TcpListener(IPAddress.Any, port);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }

        public void ListenForClients() {
            Console.WriteLine("ServerStarted...");
            this.tcpListener.Start();
            while (true) {
                TcpClient client = this.tcpListener.AcceptTcpClient();
                clients.Add(client);
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client) {
            var client = new POPClient();
client.Connect("pop.gmail.com", 995, true);
client.Authenticate("admin@bendytree.com", "YourPasswordHere");
var count = client.GetMessageCount();
Message message = client.GetMessage(count);
Console.WriteLine(message.Headers.Subject);
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            IPAddress ipOfClient = IPAddress.Parse(((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString());
            Console.WriteLine(ipOfClient + " has connected...");
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer;
            byte[] message = new byte[4096];
            int bytesRead;

            while (true) {
                bytesRead = 0;
                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch {
                    break;
                }
                if (bytesRead == 0) {
                    Console.WriteLine(ipOfClient + " has disconnected...");
                    break;
                }
                Console.Write("Message received from - " + ipOfClient + " : ");
                string incomingMsg = encoder.GetString(message, 0, bytesRead);
                Console.WriteLine(incomingMsg);

                if (incomingMsg == "List")
                {
                    buffer = encoder.GetBytes("Currently connected are: ");
                    clientStream.Write(buffer, 0, buffer.Length);
                    clientStream.Flush();
                    buffer = null;
                    foreach (TcpClient c in clients)
                    {
                        IPAddress cliIP = IPAddress.Parse(((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString());
                        buffer = encoder.GetBytes(cliIP.ToString());
                        clientStream.Write(buffer, 0, buffer.Length);
                        clientStream.Flush();
                        buffer = null;
                    }
                }
                else {
                    buffer = encoder.GetBytes("Hello Client!");
                    clientStream.Write(buffer, 0, buffer.Length);
                    clientStream.Flush();
                    buffer = null;
                }
            }
            clients.Remove(client);
            tcpClient.Close();
        }
    }
}

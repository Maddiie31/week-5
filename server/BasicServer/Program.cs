using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
namespace BasicServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter server port number: ");
            int port;
            if (Int32.TryParse(Console.ReadLine(), out port) && TestPortNumber(port))
            {
                Server s = new Server(port);
                s.PublishIP();
                s.StartServer();
            }
            else {
                Console.WriteLine("ERROR: not a valid entry or port not available...");
            }
        }
        static bool TestPortNumber(int pPort) {
            bool isAvailable = true;
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();
            foreach(TcpConnectionInformation tcpi in tcpConnInfoArray) {
              if(tcpi.LocalEndPoint.Port == pPort) {
                  isAvailable = false;
                  break;
              }
            }
            return isAvailable;
        }
    }
}

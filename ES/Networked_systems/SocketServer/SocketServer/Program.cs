using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener servSock = null;
            TcpClient clientSock = null;
            const int port = 8888;
            byte[] bytes = new byte[1024];
            string received = "";
            servSock = new TcpListener(IPAddress.Loopback, port);
            servSock.Start();
            Console.WriteLine("Waiting for the client to connect");
            while (clientSock == null)
            {
                clientSock = servSock.AcceptTcpClient();
            }           
            Console.WriteLine("Connected !");
            while (received != "Quit" && clientSock != null)
            {
                try
                {
                    NetworkStream stream = clientSock.GetStream();
                    int num = stream.Read(bytes, 0, bytes.Length);
                    received = Encoding.ASCII.GetString(bytes, 0, num);
                    Console.WriteLine(received);
                }
                catch (Exception e)
                {
                    Console.WriteLine("SocketException: {0}", e.ToString());
                }
            }
            clientSock.Close();
            servSock.Stop();
        }
    }
}

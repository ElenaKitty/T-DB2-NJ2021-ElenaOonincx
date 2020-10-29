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

            try
            {
                servSock = new TcpListener(IPAddress.Loopback, port);
                servSock.Start();
                clientSock = new TcpClient();
                Console.WriteLine("Waiting for the client to connect");
                clientSock = servSock.AcceptTcpClient();
                Console.WriteLine("Connected !");
                NetworkStream stream = clientSock.GetStream();
                int num = stream.Read(bytes, 0, bytes.Length);
                Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, num));
                Console.Write("Press ANY key to quit");
                Console.Read();
                clientSock.Close();
                servSock.Stop();
            }
            catch(Exception e)
            {
                Console.WriteLine("SocketException: {0}", e.ToString());
            }

        }
    }
}

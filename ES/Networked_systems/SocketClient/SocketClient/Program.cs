using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{
    class Program
    {

        static void Main(string[] args)
        {
            const int port = 8888;
            string sendLine = "";
            TcpClient clientSock = new TcpClient();
            Console.WriteLine("Connecting to Server ...");
            clientSock.Connect(IPAddress.Loopback, port);
            while (sendLine != "Quit")
            {
                try
                {
                    NetworkStream stream = clientSock.GetStream();
                    Console.WriteLine("What do you wanna send?");
                    sendLine = Console.ReadLine();
                    byte[] data = Encoding.ASCII.GetBytes(sendLine);
                    Console.WriteLine("Sending message to the Server");
                    stream.Write(data, 0, data.Length);           
                }
                catch (Exception e)
                {
                        Console.WriteLine(e.ToString());
                }
            }
            clientSock.Close();
        }
    }
}

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
            String sendLine = "Hallo from Client";
          
            try
            {
                    TcpClient clientSock = new TcpClient();
                    Console.WriteLine("Connecting to Server ...");
                    clientSock.Connect(IPAddress.Loopback, port);

                    NetworkStream stream = clientSock.GetStream();
                    byte[] data = Encoding.ASCII.GetBytes(sendLine);
                    Console.WriteLine("Sending message to the Server");
                    stream.Write(data, 0, data.Length);

                    Console.WriteLine("Presss ANY key to quit");
                    Console.Read();
                    clientSock.Close();
             }
             catch (Exception e)
             {
                    Console.WriteLine(e.ToString());
             }
         
        }
    }
}

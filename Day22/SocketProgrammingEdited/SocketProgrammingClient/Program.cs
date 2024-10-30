using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            var client = new TcpClient();
            client.Connect(ip, port);
            Console.WriteLine("Connected to server.");

            string message = "AB";
            byte[] data = Encoding.ASCII.GetBytes(message);

            client.GetStream().Write(data, 0, data.Length);
            Console.WriteLine("Message sent.");
        }
    }
}

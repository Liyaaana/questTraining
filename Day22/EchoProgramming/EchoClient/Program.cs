using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EchoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the IP address and port to connect to.
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            // Create a TcpClient instance and connect to the server.
            var client = new TcpClient();
            client.Connect(ip, port);
            Console.WriteLine("Connected to echo server.");

            var stream = client.GetStream();

            while (true)
            {
                // Read a message from the user.
                Console.Write("Enter message: ");
                string message = Console.ReadLine();

                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Disconnecting...");
                    break;
                }

                // Send the message to the server.
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Receive the echoed message from the server.
                byte[] responseBuffer = new byte[1024];
                int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                string response = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);

                Console.WriteLine($"Echo from server: {response}");
            }

            // Close the stream and client connection.
            stream.Close();
            client.Close();
            Console.WriteLine("Disconnected from server.");
        }
    }
}

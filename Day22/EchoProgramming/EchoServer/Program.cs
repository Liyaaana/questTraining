using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the IP address and port for the server to listen on.
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            // Create a TcpListener instance and start listening for connections.
            var listener = new TcpListener(ip, port);
            listener.Start();
            Console.WriteLine($"Echo server is listening on {ip}:{port}");

            // Accept a client connection.
            Socket socket = listener.AcceptSocket();
            Console.WriteLine("Client connected");

            // Enter a loop to receive and echo messages from the client.
            while (true)
            {
                try
                {
                    // Receive data from the client.
                    var buffer = new byte[1024];
                    var dataLength = socket.Receive(buffer);
                    if (dataLength == 0)
                    {
                        // If no data is received, the client has disconnected.
                        Console.WriteLine("Client disconnected");
                        break;
                    }

                    // Convert the received data to a string and display it.
                    string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                    Console.WriteLine($"Received: {message}");

                    // Echo the received message back to the client.
                    socket.Send(buffer, 0, dataLength, SocketFlags.None);
                    Console.WriteLine("Echoed back to client");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    break;
                }
            }

            // Close the socket and stop the listener.
            socket.Close();
            listener.Stop();
            Console.WriteLine("Server stopped");
        }
    }
}

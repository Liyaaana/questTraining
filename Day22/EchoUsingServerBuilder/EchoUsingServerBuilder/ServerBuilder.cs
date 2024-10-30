using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EchoUsingServerBuilder
{
    public class ServerBuilder
    {
        // Define the IP address and port number for the server
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;

        // TcpListener listens for client requests
        private TcpListener _listener;

        // Socket to manage the connection with the client
        private Socket _socket;

        // Method to initialize and set up the TcpListener with the IP and port
        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _listener = new TcpListener(ip, port);
        }

        // Method to start the server and listen for incoming client connections
        public void Run(Action<string> callback)
        {
            // Build the server configuration
            Build();
            // Start the listener
            _listener.Start();
            Console.WriteLine($"App is listening on {ipAddress}:{port}.");

            // Accept an incoming client connection
            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected");

            // Continuously receive messages from the connected client
            while (true)
            {
                var buffer = new byte[1024];
                var dataLength = _socket.Receive(buffer); // Receive data into the buffer
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength); // Convert bytes to string
                callback(message); // Invoke the callback with the received message
            }
        }

        // Method to send a message back to the client
        public void SendMessage(string message)
        {
            var data = Encoding.ASCII.GetBytes(message); // Convert the message to byte array
            _socket.Send(data); // Send the message back to the client
        }

        // Method to close the connection and stop the server
        public void ShutDown()
        {
            _socket.Close(); // Close the client socket
            _listener.Stop(); // Stop the TcpListener
            Console.WriteLine("Server shut down.");
        }
    }
}

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Exercise4Client
{
    class Client
    {
        static void Main(string[] args)
        {
            byte[] adr = { 127, 0, 0, 1 };
            TcpClient client = new TcpClient("127.0.0.1", 5000);

            client.Connect(new IPEndPoint(new IPAddress(adr), 5000));

            NetworkStream networkStream = client.GetStream();
            byte[] hello = Encoding.ASCII.GetBytes("Hello, I am your client.");
            networkStream.Write(hello, 0, hello.Length);

            byte[] answer = new byte[client.ReceiveBufferSize];
            int read = networkStream.Read(answer, 0, client.ReceiveBufferSize);
            System.Console.WriteLine("SERVER> " + Encoding.ASCII.GetString(answer, 0, read));
            client.Close();
        }
    }
}

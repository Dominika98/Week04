using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Exercise4
{
    class Server
    {
        static void Main(string[] args)
        {
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAsr = new IPAddress(adr);
            TcpListener newsock = new TcpListener( ipAsr, 12345);
            newsock.Start();
            System.Console.WriteLine("Waiting for a client...");

            while(true)
            {
                TcpClient client = newsock.AcceptTcpClient();
                Thread t0 = new Thread( new ThreadStart(HandleClient()));
                t0.Start(client);
            }
        }

        public void HandleClient(object client)
        {
            TcpClient clientTcp = (TcpClient) client;
            NetworkStream ns = clientTcp.GetStream();

            byte[] read = new byte[clientTcp.ReceiveBufferSize];

            int bytes = ns.Read(read, 0, clientTcp.ReceiveBufferSize);
            string received = Encoding.ASCII.GetString(read, 0, bytes);
            System.Console.WriteLine("Client> " + received);

            byte[] welcome = Encoding.ASCII.GetBytes("Weclome to my server :D");
            ns.Write(welcome, 0, welcome.Length);

            clientTcp.Close();
        }
    }
}

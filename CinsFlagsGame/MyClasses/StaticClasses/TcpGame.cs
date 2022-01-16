using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace CinsFlagsGame.MyClasses.StaticClasses
{
    public static class TcpGame  //  Mostly, Asynhronous Threaded Tcp connection codes from our lecture book.
    {
        private static byte[] data = new byte[1024];
        public static Socket client;
        public static void Initialize()
        {
            if (Configuration.role == "Server")
            {
                client = new Socket(AddressFamily.InterNetwork,
                               SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
                client.Bind(ipep);
                client.Listen(5);
                client.BeginAccept(new AsyncCallback(AcceptConn), client);
            }
            if (Configuration.role == "Client")
            {
                client = new Socket(AddressFamily.InterNetwork,
                   SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(Configuration.serverIpep), 9050);
                client.BeginConnect(ipep, new AsyncCallback(Connected), client);
            }


        }
        public static void Send(byte[] message, int length)
        {
            client.BeginSend(message, 0, length, 0,
                new AsyncCallback(SendData), client);
        }


        private static void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            client = oldserver.EndAccept(iar);
            Game.ChatWindow.Items.Add("CONNECTION IS READY");
            Game.playStartSound();
            Thread receiver = new Thread(new ThreadStart(ReceiveData));
            receiver.Start();
        }
        private static void Connected(IAsyncResult iar)
        {
            try
            {
                client.EndConnect(iar);
                Thread receiver = new Thread(new ThreadStart(ReceiveData));
                receiver.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("Error Connecting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private static void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }

        private static void ReceiveData()
        {
            int recv;
            while (true)
            {

                recv = client.Receive(data);
                Game.ReceiveMessage(data, recv); // Critical codes with specific game states.
               
            }
        }
    }
}

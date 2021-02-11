namespace LANTournamentManager
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;
    class Server
    {
        Tournament t;

        int port;
        int num;
        string name;
        string game;

        TcpClient[] tcpClients;
        int numConnected = 0;
        Client[] clients;

        bool running = false;

        clientListener cl;

        /* NETWORK PROTOCOL:
         * formalities:
         * 000 Welcome (connection successful) 000.OK
         * 999 Bye (client or server) - 999.OK
         * 998 Kick (server) - 998.OK (bye from server)
         * 997 Server full (server) - 997.OK (bye from server)
         * 
         * player data format: 
         * 00x.0 for set null (s>c) or non-existent player (c>s)
         * 00x.1.k.d.w.l (only server to client)
         * 00x.1.OK
         * 00x.2.name
         * 00x.2.OK
         * 00x.3.tag
         * 00x.3.OK
         * 00x.4.[1|0] (participates)
         * 00x.4.OK
         * 
         * 001 (Server requests client player data)
         * 001.OK (Client acknowledges and proceeds to send data)
         * 
         * 004.i (Server sends client ID)
         * 004.OK (Client acknowledges and changes own ID)
         * 
         * 002.i (Client requests player data of player i)
         * 002.i.OK (Server acknowledges and sends player data of player i)
         * 
         * 003 (Client requests to change own data)
         * 003.OK (Server approves and registers changes)
         * 003.DEN (Server denies changes)
         * 
         * 100.CHAT (Client sends chat)
         * 100.OK (Server acknowledges and broadcasts to other clients)
         * 
         * 101.i.CHAT (Chat from client i)
         *
         */

        public Server(int num, int port, string name, string game)
        {
            this.port = port;
            this.num = num;
            this.name = name;
            this.game = game;

            clients = new Client[num];
            t = new Tournament(num, name, game);

            cl = new clientListener();
            cl.nc += new clientListener.newClient(newClientEvent);

            tcpClients = new TcpClient[num];
        }

        public Tournament getTournament() => t;
        public void setStatus(int i) => t.setStatus(i);
        public int getStatus() => t.getStatus();

        protected virtual void newClientEvent(TcpClient c)
        {
            if (numConnected < clients.Length)
            {

            }
            else // server is full, send FULL and quit
            {

            }
        }

        private void sendToClient(TcpClient c, string message)
        {
            NetworkStream stream = c.GetStream();
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            stream.Write(msg, 0, msg.Length);
        }

        public void changeProperties(int num, int port, string name, string game)
        {
            if (!running)
            {
                this.port = port;
                this.num = num;
            }
            this.name = name;
            this.game = game;
        }

        public void stopServer()
        {
            // send bye
            cl.stopListening();
        }
    }

    //http://www.hinzberg.net/csharp/csharp/csharp/threadevents.html
    //https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.tcplistener?view=net-5.0
    //https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.tcpclient?view=net-5.0

    class clientListener
    {
        TcpListener listen;
        public delegate void newClient(TcpClient c);
        public event newClient nc;

        //public static ManualResetEvent tcpClientConnected = new ManualResetEvent(false);


        bool isFinished = false;
        public clientListener()
        {
            listen = new TcpListener(IPAddress.Parse("127.0.0.1"), 20000);
            listen.Start();
            DoBeginAcceptTcpClient(listen);
        }

        public void DoBeginAcceptTcpClient(TcpListener l)
        {
            //tcpClientConnected.Reset();
            l.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), l);
            //tcpClientConnected.WaitOne();
        }

        public void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            TcpListener l = (TcpListener)ar.AsyncState;
            TcpClient cl = l.EndAcceptTcpClient(ar);

            Console.WriteLine("Client connected completed");
            //process 

            //tcpClientConnected.Set();
        }

        public string handleMessage()
        {

        }

        public void stopListening()
        {
            listen.Stop();
        }
    }

    class messageListener
    {
        public delegate void newMessage(string s);
        public event newMessage nm;

        bool isFinished = false;

        TcpClient client;
        NetworkStream stream;
        public messageListener(TcpClient client)
        {
            byte[] bytes = new byte[256];
            this.client = client;
            stream = this.client.GetStream();
            int length = 0;

            string data = "";
            while (!isFinished)
            {
                length = stream.Read(bytes, 0, bytes.Length);
                for (int i = 0; i < length; i++)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                }
            }
        }
    }
}

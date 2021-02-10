namespace LANTournamentManager
{
    using System.Net;
    using System.Net.Sockets;
    class Server
    {
        Tournament t;
        Client[] clients;
        int port;
        int num;
        string name;
        string game;

        public Server(int num, int port, string name, string game)
        {
            this.port = port;
            this.num = num;
            this.name = name;
            this.game = game;

            clients = new Client[num];
            t = new Tournament(num, name, game);

            ServerEventClass st = new ServerEventClass();
            st.nc += new ServerEventClass.newClient(newClientEvent);
        }

        public Tournament getTournament() => t;

        public void setStatus(int i) => t.setStatus(i);
        public int getStatus() => t.getStatus();

        private void newClientEvent(TcpClient c) { 
        
        }
    }

    // http://www.hinzberg.net/csharp/csharp/csharp/threadevents.html
    // https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.tcplistener?view=net-5.0
    // https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.tcpclient?view=net-5.0

    class ServerEventClass
    {
        TcpListener listen;
        public delegate void newClient(TcpClient c);
        public event newClient nc;
        public ServerEventClass()
        {
            listen = new TcpListener(IPAddress.Parse("127.0.0.1"), 20000);
            listen.Start();
        }
    }
}

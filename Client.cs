namespace LANTournamentManager
{

    class Client
    {
        Player p = new Player(0);
        Tournament t = null;

        int status = 0; // see Tournament.cs
        int id = 0;

        public Client()
        {
            p.setName("Name");
            p.setTag("UnnamedPlayer");
        }



        public bool isConnected() => status != 0;
        public int getStatus() => status;
        public void setStatus(int status) => this.status = status;
        public int getId() => p.getId();
        public void setId(int id) => p.setId(id);
        public Player getPlayer() {
            Player pl = p;
            if (true)
            {

            }
            return pl;
        }
        public void setPlayer(Player p) => this.p = p;

        public Tournament getTournament() => t;



    }
}

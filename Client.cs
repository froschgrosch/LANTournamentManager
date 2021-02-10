namespace LANTournamentManager
{

    class Client
    {
        Player p = new Player(0);
        int status = 0; // see Tournament.cs

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
        public Player getPlayer() => p;
        public void setPlayer(Player p) => this.p = p;

        // NETWORKING


    }
}

using System;

namespace LANTournamentManager
{
    public class Tournament
    {
        byte tournamentStatus = 0; /*
                                   * current status of the tournament
                                   * 0: not connected
                                   * 1: waiting
                                   * 2: running
                                   * 3: finished */
        Player[] players;
        int numberOfplayers = 0;

        String name;
        String game;

        public Tournament(int s, string name, string game)
        {
            players = new Player[s];
            this.name = name;
            this.game = game;
        }

        public int getStatus() => tournamentStatus;
        public String getName() => name;
        public String getGame() => game;
        public Player[] getPlayers() => players;
        public void setPlayer(Player p, int i) => players[i] = p;
        public int getNumOfPlayers() => numberOfplayers;

        public void addPlayer(Player p)
        {
            if (numberOfplayers <= players.Length)
            {
                players[numberOfplayers] = p;
                numberOfplayers++;
            }
        }

        public void deletePlayer(int num)
        {
            if (num < numberOfplayers && num >= 0) // gültig
            {
                players[num] = null;
                numberOfplayers--;
                for (int i = num; i < numberOfplayers; i++)
                {
                    players[i].lowerId();
                    players[i] = players[i + 1];
                }
            }
        }

        public Player getPlayer(int i)
        {
            Player output;
            if (i < numberOfplayers && i >= 0) // gültig
            {
                output = players[i];
            }
            else
            {
                output = new Player(-1);
                output.setName("");
                output.setTag("");
            }
            return output;
        }


    }
}

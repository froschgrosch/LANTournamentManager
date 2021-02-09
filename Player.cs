namespace LANTournamentManager
{
    public class Player
    {
        string name = "";
        string tag = "";
        int[] score;
        /*  stores the players wins and loses as well as kills and deaths.
         *  0 - wins
         *  1 - losses
         *  2 - kills
         *  3 - Deaths */
        int id;

        public Player(string name, string tag, int id)
        {
            this.name = name;
            this.tag = tag;
            this.id = id;
            score = new int[4];
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = 0;
            }
        }

        public string getName()
        {
            return name;
        }

        public string getTag()
        {
            return tag;
        }

        public int[] getScore()
        {
            return score;
        }
    }
}

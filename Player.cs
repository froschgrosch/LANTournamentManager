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
        int id; // 0 is host
        bool participates = true; // does participate

        public Player(int id)
        {
            this.id = id;
            score = new int[4];
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = 0;
            }
        }

        public int getId() => id;
        public void setId(int id) => this.id = id;
        public void lowerId() => id--;
        public string getName() => name;
        public void setName(string name) => this.name = name;
        public string getTag() => tag;
        public void setTag(string tag) => this.tag = tag;
        public int[] getScore() => score;
        public void increaseScore(int index, int amount) => score[index] += amount;
        public bool getParticipates() => participates;
        public void setParticipates(bool newValue) => participates = newValue;
    }
}

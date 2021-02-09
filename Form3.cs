using System;
using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form3 : Form
    {
        private Form1 mainForm = null;
        private bool[] isConnected;
        public Form3(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as Form1;
            this.Text = mainForm.Text + " - Spieler";
        }

        private void Form3_Load(object sender, EventArgs e) { }


        private string getNameFormatted(Player p)
        {
            string name = p.getName();
            if (name == "")
            {
                name = "Nicht verbunden";
            }
            return name;
        }

        public void updateWindow()
        {

            Tournament t = mainForm.getTournament();
            isConnected = new bool[t.getNumOfPlayers()];
            Player[] p = t.getPlayers();

            for (int i = 0; i < isConnected.Length; i++)
            {
                isConnected[i] = true;
                if (p[i].getId() == -1)
                {
                    isConnected[i] = false;
                }
            }

            textBox1.Text = getNameFormatted(p[0]);
            button1.Enabled = isConnected[0];
            textBox2.Text = getNameFormatted(p[1]);
            button2.Enabled = isConnected[1];
            textBox3.Text = getNameFormatted(p[2]);
            button3.Enabled = isConnected[2];
            textBox4.Text = getNameFormatted(p[3]);
            button4.Enabled = isConnected[3];
            textBox5.Text = getNameFormatted(p[4]);
            button5.Enabled = isConnected[4];
            textBox6.Text = getNameFormatted(p[5]);
            button6.Enabled = isConnected[5];
            textBox7.Text = getNameFormatted(p[6]);
            button7.Enabled = isConnected[6];
            textBox8.Text = getNameFormatted(p[7]);
            button8.Enabled = isConnected[7];
            textBox9.Text = getNameFormatted(p[8]);
            button9.Enabled = isConnected[8];
            textBox10.Text = getNameFormatted(p[9]);
            button10.Enabled = isConnected[9];
            textBox11.Text = getNameFormatted(p[10]);
            button11.Enabled = isConnected[10];
            textBox12.Text = getNameFormatted(p[11]);
            button12.Enabled = isConnected[11];
            textBox13.Text = getNameFormatted(p[12]);
            button13.Enabled = isConnected[12];
            textBox14.Text = getNameFormatted(p[13]);
            button14.Enabled = isConnected[13];
            textBox15.Text = getNameFormatted(p[14]);
            button15.Enabled = isConnected[14];
            textBox16.Text = getNameFormatted(p[15]);
            button16.Enabled = isConnected[15];


        }
    }
}

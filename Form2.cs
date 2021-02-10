using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        Player p;
        bool viewOnly = false;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e) { }

        public void loadPlayer(Player p, bool viewOnly)
        {
            this.p = p;
            this.viewOnly = viewOnly;
        }

        public void setViewOnly(bool b) => viewOnly = b;

        public void updateView()
        {
            this.Text = mainForm.Text + " - " + p.getName();

            textBox1.Text = p.getName();
            textBox2.Text = p.getTag();
            checkBox1.Checked = p.getParticipates();

            textBox1.ReadOnly = viewOnly;
            textBox2.ReadOnly = viewOnly;
            checkBox1.Enabled = !viewOnly;

            int[] scores = p.getScore();
            textBox3.Text = scores[0].ToString(); ;
            textBox4.Text = scores[1].ToString(); ;
            if (scores[1] == 0) { textBox5.Text = "-"; }
            else { textBox5.Text = (scores[0] / scores[1]).ToString(); }
            textBox6.Text = scores[2].ToString();
            textBox7.Text = scores[3].ToString();
            if (scores[3] == 0) { textBox8.Text = "-"; }
            else { textBox8.Text = (scores[2] / scores[3]).ToString(); }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.TextLength >= 3)
            {
                p.setName(textBox1.Text);
                updateView();
            }
            p.setTag(textBox2.Text);
            // mainForm.updateView();

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = p.getName();
            textBox2.Text = p.getTag();
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            p.setParticipates(checkBox1.Checked);
            mainForm.updateView();
        }
    }
}

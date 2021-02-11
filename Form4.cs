using System;
using System.Windows.Forms;

namespace LANTournamentManager
{

    public partial class Form4 : Form
    {
        private Form1 mainForm = null;

        bool running = false;
        public Form4(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as Form1;
            this.Text = mainForm.Text + " - Server";
            this.numericUpDown1.Value = mainForm.defaultPort;
        }

        public void updateView() { }

        private void setRunning(bool b)
        {
            running = b;

            button1.Enabled = !b;
            button2.Enabled = b;
            textBox3.ReadOnly = b;
            textBox4.ReadOnly = b;
            checkBox1.Enabled = !b;
            numericUpDown1.ReadOnly = b;
            numericUpDown2.ReadOnly = b;
       }
        public string getHostname() => textBox3.Text;
        public string getGame() => textBox4.Text;
        public void setAddress(string addr) => textBox2.Text = addr;
        public int getMaxClients() => Convert.ToInt32(numericUpDown2.Value);
        public int getPort() => Convert.ToInt32(numericUpDown1.Value);

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.openListForm();
        }

        public string getHostName() => textBox3.Text;

        public void startServer()
        {
            button1.Enabled = false;
            button2.Enabled = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            checkBox1.Enabled = false;
            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
        }

        public void stopServer()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            checkBox1.Enabled = true;
            numericUpDown1.ReadOnly = false;
            numericUpDown2.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && numericUpDown2.Value >= 2)
            {
                mainForm.startServer(this);
                setRunning(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setRunning(false);
        }
    }
}

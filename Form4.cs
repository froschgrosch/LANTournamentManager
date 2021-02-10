using System;
using System.Windows.Forms;

namespace LANTournamentManager
{

    public partial class Form4 : Form
    {
        private Form1 mainForm = null;
        public Form4(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as Form1;
            this.Text = mainForm.Text + " - Server";
        }

        public void updateView() { }
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
        }

        public void stopServer()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            checkBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startServer();
            mainForm.startServer(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopServer();
        }
    }
}

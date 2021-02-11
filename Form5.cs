using System;
using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form5 : Form
    {
        private Form1 mainForm = null;
        public Form5(Form1 callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as Form1;
            this.numericUpDown1.Value = mainForm.defaultPort;
        }

        private void Form5_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // mainForm.clientConnect(textBox1.Text, Convert.ToInt32(numericUpDown1.Value));
        }
    }
}

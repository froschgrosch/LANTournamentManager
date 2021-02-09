using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form2 : Form
    {
        private Form1 mainForm = null;
        Player p;
        bool viewOnly = false;
        public Form2(Form callingForm, Player p, bool viewOnly)
        {
            mainForm = callingForm as Form1;
            this.p = p;
            this.viewOnly = viewOnly;
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {

        }
    }
}

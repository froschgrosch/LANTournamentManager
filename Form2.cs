using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form2 : Form
    {
        private Form1 mainForm = null;
        Player p;
        public Form2(Form callingForm, Player p)
        {
            mainForm = callingForm as Form1;
            this.p = p;
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form3 : Form
    {
        public Form3(string parentTitle)
        {
            InitializeComponent();
            this.Text = parentTitle + " - Spieler";
        }

        private void Form3_Load(object sender, EventArgs e) { }
    }
}

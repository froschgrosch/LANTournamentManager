using System;
using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form1 : Form
    {
        Player p;
        string fileName = "";
        readonly string windowTitle = "LANTournamentManager";
        Boolean tournamentHasStarted = false;
        Boolean isConnected = false;

        public Form1()
        {
            // Window
            InitializeComponent();
            openFileDialog1.Filter = "Tournament file (*.trn)|*.trn";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = "";

            saveFileDialog1.Filter = "Tournament file (*.trn)|*.trn";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.FileName = "";

            this.Text = windowTitle;

            // Program
            p = new Player("Simon", "froschgrosch", 0);
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }

        private void neuToolStripMenuItem_Click_1(object sender, EventArgs e) // new file
        {
            this.Text = windowTitle + " - neue Datei";
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e) // open file for reading
        {
            System.Diagnostics.Debug.WriteLine("open File");
            openFileDialog1.ShowDialog();
            saveFileDialog1.FileName = openFileDialog1.FileName;
            fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            this.Text = windowTitle + " - " + fileName;
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e) // save file
        {
            System.Diagnostics.Debug.WriteLine("save File");
            saveFileDialog1.ShowDialog();
            openFileDialog1.FileName = saveFileDialog1.FileName;
        }

        private void verbindenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("connect");

        }

        private void spielerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("connect");
            Form2 playerForm = new Form2(this, p);
            playerForm.Show();
        }

        private void teilnehmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tournamentHasStarted)
            {
                teilnehmenToolStripMenuItem.Checked = !teilnehmenToolStripMenuItem.Checked;
            }
        }
    }
}
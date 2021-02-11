using System;
using System.Windows.Forms;

namespace LANTournamentManager
{
    public partial class Form1 : Form
    {
        readonly string windowTitle = "LANTourney";
        string fileName = ".trn";
        string serverAddress = "";

        bool connected = false;

        public readonly int defaultPort = 26077;

        private Server s;
        private Client c;

        Form2 playerForm;
        Form3 listForm;
        Form4 serverForm;
        Form5 connectForm;

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

            c = new Client();
            c.setId(0);
        }

        private Player getPlayer()
        {
            Player p;
            if (s == null)
            {
                p = c.getPlayer();
            }
            else
            {
                p = getTournament().getPlayer(c.getId());
            }
            return p;
        }

        private void setPlayer(Player p)
        {
            if (s == null)
            {
                c.setPlayer(p);
            }
            else
            {
                getTournament().setPlayer(p, p.getId());
            }
        }

        public string getServerAddress()
        {
            string output = "";
            if (c.getId() == 0)
            {
                output = "localhost";
            }
            else
            {
                output = serverAddress;
            }
            return output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateView();
            playerForm = new Form2(this);
            listForm = new Form3(this);
            serverForm = new Form4(this);
            connectForm = new Form5(this);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        public Tournament getTournament() => s.getTournament();

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
            //setConnected(true);
            connectForm.Show();
            connectForm.Focus();
        }

        private void serverStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serverForm.Show();
            serverForm.Focus();
            serverForm.updateView();
        }


        public void openListForm()
        {
            if (s != null)
            {
                listForm.Show();
                listForm.Focus();
                listForm.updateView();
            }
        }

        public void openPlayerForm(Player p)
        {
            playerForm.loadPlayer(p, p.getId() != c.getId());
            playerForm.Show();
            playerForm.Focus();
            playerForm.updateView();
        }

        private void spielerToolStripMenuItem_Click(object sender, EventArgs e) { openListForm(); }

        private void teilnehmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teilnehmenToolStripMenuItem.Checked = !teilnehmenToolStripMenuItem.Checked;
            Player p = getPlayer();
            p.setParticipates(teilnehmenToolStripMenuItem.Checked);
            setPlayer(p);
        }

        public void setConnected(bool b)
        {
            connected = b;
            if (b)
            {
                verbindenToolStripMenuItem.Enabled = false;
                if (getPlayer().getId() != 0) // we are host
                {
                    verbindungTrennenToolStripMenuItem.Enabled = false;
                }
                else
                {
                    verbindungTrennenToolStripMenuItem.Enabled = true;
                }
                verbindenToolStripMenuItem.Enabled = false;
            }
            else
            {
                verbindenToolStripMenuItem.Enabled = true;
                verbindungTrennenToolStripMenuItem.Enabled = false;
            }
        }

        public void updateView()
        {
            string newStatus = "";
            switch (c.getStatus())
            {
                case 0: // notConnected
                    newStatus = "Nicht verbunden";
                    break;
                case 1: // waiting
                    newStatus = getServerAddress() + " - Warten auf Turnierbeginn";
                    teilnehmenToolStripMenuItem.Enabled = true;
                    break;
                case 2:  // active
                    newStatus = getServerAddress() + " - Turnier läuft";
                    teilnehmenToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    newStatus = getServerAddress() + " - Turnier abgeschlossen";
                    teilnehmenToolStripMenuItem.Enabled = true;
                    break;
            }
            toolStripStatusLabel1.Text = newStatus;
            teilnehmenToolStripMenuItem.Checked = getPlayer().getParticipates();
            verbindungTrennenToolStripMenuItem.Enabled = c.isConnected();
        }

        private void eigeneAngabenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPlayerForm(getPlayer());
        }


        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: add prompt to save unsaved changes
            stopServer();
            Environment.Exit(0);
        }

        private void turnierStarten()
        {
            if (s != null)
            {
                s.setStatus(2);
                c.setStatus(2);
                updateView();
            }
        }

        public void startServer(Form4 form)
        {
            string hostname = form.getHostname();
            string game = form.getGame();
            int port = form.getPort();
            int maxClients = form.getMaxClients();

            System.Diagnostics.Debug.WriteLine(port);
            System.Diagnostics.Debug.WriteLine(maxClients);
            System.Diagnostics.Debug.WriteLine(hostname);
            System.Diagnostics.Debug.WriteLine(game);

            if (s == null)
            {
                s = new Server(16, 20000, "name", "game");
            }
            else
            {
                s.changeProperties(16, 20000, "name", "game");
            }
        }

        public void stopServer()
        {
            s.stopServer();
        }

        public void clientConnect(String ip, int port)
        {
            connectForm.Hide();
            MessageBox.Show(ip);
        }

        public void clientDisconnect()
        {

        }
    }
}
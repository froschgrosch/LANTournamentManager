
namespace LANTournamentManager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netzwerkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbindenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbindungTrennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigeneAngabenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.turnierStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.netzwerkToolStripMenuItem,
            this.turnierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click_1);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // netzwerkToolStripMenuItem
            // 
            this.netzwerkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verbindenToolStripMenuItem,
            this.verbindungTrennenToolStripMenuItem,
            this.serverStartenToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.netzwerkToolStripMenuItem.Name = "netzwerkToolStripMenuItem";
            this.netzwerkToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.netzwerkToolStripMenuItem.Text = "Netzwerk";
            // 
            // verbindenToolStripMenuItem
            // 
            this.verbindenToolStripMenuItem.Name = "verbindenToolStripMenuItem";
            this.verbindenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.verbindenToolStripMenuItem.Text = "Verbinden";
            this.verbindenToolStripMenuItem.Click += new System.EventHandler(this.verbindenToolStripMenuItem_Click);
            // 
            // verbindungTrennenToolStripMenuItem
            // 
            this.verbindungTrennenToolStripMenuItem.Name = "verbindungTrennenToolStripMenuItem";
            this.verbindungTrennenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.verbindungTrennenToolStripMenuItem.Text = "Verbindung trennen";
            // 
            // serverStartenToolStripMenuItem
            // 
            this.serverStartenToolStripMenuItem.Name = "serverStartenToolStripMenuItem";
            this.serverStartenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.serverStartenToolStripMenuItem.Text = "Server starten";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // turnierToolStripMenuItem
            // 
            this.turnierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielerToolStripMenuItem,
            this.teilnehmenToolStripMenuItem,
            this.eigeneAngabenToolStripMenuItem,
            this.toolStripSeparator2,
            this.turnierStartenToolStripMenuItem});
            this.turnierToolStripMenuItem.Name = "turnierToolStripMenuItem";
            this.turnierToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.turnierToolStripMenuItem.Text = "Turnier";
            // 
            // spielerToolStripMenuItem
            // 
            this.spielerToolStripMenuItem.Name = "spielerToolStripMenuItem";
            this.spielerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.spielerToolStripMenuItem.Text = "Spieler";
            this.spielerToolStripMenuItem.Click += new System.EventHandler(this.spielerToolStripMenuItem_Click);
            // 
            // teilnehmenToolStripMenuItem
            // 
            this.teilnehmenToolStripMenuItem.Checked = true;
            this.teilnehmenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.teilnehmenToolStripMenuItem.Name = "teilnehmenToolStripMenuItem";
            this.teilnehmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teilnehmenToolStripMenuItem.Text = "Teilnehmen";
            this.teilnehmenToolStripMenuItem.Click += new System.EventHandler(this.teilnehmenToolStripMenuItem_Click);
            // 
            // eigeneAngabenToolStripMenuItem
            // 
            this.eigeneAngabenToolStripMenuItem.Name = "eigeneAngabenToolStripMenuItem";
            this.eigeneAngabenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eigeneAngabenToolStripMenuItem.Text = "Eigene Angaben";
            this.eigeneAngabenToolStripMenuItem.Click += new System.EventHandler(this.eigeneAngabenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // turnierStartenToolStripMenuItem
            // 
            this.turnierStartenToolStripMenuItem.Name = "turnierStartenToolStripMenuItem";
            this.turnierStartenToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.turnierStartenToolStripMenuItem.Text = "Turnier starten";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "default";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem netzwerkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbindenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbindungTrennenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigeneAngabenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem turnierStartenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}


namespace prjWinCsFinalProjectPart1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalScientifique = new System.Windows.Forms.ToolStripMenuItem();
            this.breuaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionEnLigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuitProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrpStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrpShortcuts = new System.Windows.Forms.ToolStrip();
            this.toolStrpStandard = new System.Windows.Forms.ToolStripButton();
            this.toolStrpScientific = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBureauxChange = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrpEnLigne = new System.Windows.Forms.ToolStripButton();
            this.statusStrp = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrpShortcuts.SuspendLayout();
            this.statusStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            this.programmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsToolStripMenuItem,
            this.breuaxToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnuQuitProgramme});
            this.programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            this.programmesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.programmesToolStripMenuItem.Text = "Programmes";
            // 
            // calculatorsToolStripMenuItem
            // 
            this.calculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalStandard,
            this.mnuCalScientifique});
            this.calculatorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatorsToolStripMenuItem.Image")));
            this.calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            this.calculatorsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // mnuCalStandard
            // 
            this.mnuCalStandard.Name = "mnuCalStandard";
            this.mnuCalStandard.Size = new System.Drawing.Size(177, 22);
            this.mnuCalStandard.Text = "Version Standard";
            this.mnuCalStandard.Click += new System.EventHandler(this.mnuCalStandard_Click);
            // 
            // mnuCalScientifique
            // 
            this.mnuCalScientifique.Name = "mnuCalScientifique";
            this.mnuCalScientifique.Size = new System.Drawing.Size(177, 22);
            this.mnuCalScientifique.Text = "Version Scientifique";
            this.mnuCalScientifique.Click += new System.EventHandler(this.mnuCalScientifique_Click);
            // 
            // breuaxToolStripMenuItem
            // 
            this.breuaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionLocalToolStripMenuItem,
            this.versionEnLigneToolStripMenuItem});
            this.breuaxToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("breuaxToolStripMenuItem.Image")));
            this.breuaxToolStripMenuItem.Name = "breuaxToolStripMenuItem";
            this.breuaxToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.breuaxToolStripMenuItem.Text = "Bureaux Change";
            // 
            // versionLocalToolStripMenuItem
            // 
            this.versionLocalToolStripMenuItem.Name = "versionLocalToolStripMenuItem";
            this.versionLocalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionLocalToolStripMenuItem.Text = "Version Local";
            this.versionLocalToolStripMenuItem.Click += new System.EventHandler(this.versionLocalToolStripMenuItem_Click);
            // 
            // versionEnLigneToolStripMenuItem
            // 
            this.versionEnLigneToolStripMenuItem.Enabled = false;
            this.versionEnLigneToolStripMenuItem.Name = "versionEnLigneToolStripMenuItem";
            this.versionEnLigneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionEnLigneToolStripMenuItem.Text = "Version En Ligne";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // mnuQuitProgramme
            // 
            this.mnuQuitProgramme.Name = "mnuQuitProgramme";
            this.mnuQuitProgramme.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuQuitProgramme.Size = new System.Drawing.Size(222, 26);
            this.mnuQuitProgramme.Text = "Quitter Programme";
            this.mnuQuitProgramme.Click += new System.EventHandler(this.mnuQuitProgramme_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpToolbar,
            this.toolStrpStatusBar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStrpToolbar
            // 
            this.toolStrpToolbar.Checked = true;
            this.toolStrpToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStrpToolbar.Name = "toolStrpToolbar";
            this.toolStrpToolbar.Size = new System.Drawing.Size(126, 22);
            this.toolStrpToolbar.Text = "Toolbar";
            this.toolStrpToolbar.CheckedChanged += new System.EventHandler(this.toolStrpToolbar_CheckedChanged);
            this.toolStrpToolbar.Click += new System.EventHandler(this.toolStrpToolbar_Click);
            // 
            // toolStrpStatusBar
            // 
            this.toolStrpStatusBar.Checked = true;
            this.toolStrpStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStrpStatusBar.Name = "toolStrpStatusBar";
            this.toolStrpStatusBar.Size = new System.Drawing.Size(126, 22);
            this.toolStrpStatusBar.Text = "Status Bar";
            this.toolStrpStatusBar.CheckedChanged += new System.EventHandler(this.toolStrpStatusBar_CheckedChanged);
            this.toolStrpStatusBar.Click += new System.EventHandler(this.toolStrpStatusBar_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserManual,
            this.toolStripSeparator4,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Aide";
            // 
            // mnuUserManual
            // 
            this.mnuUserManual.Image = ((System.Drawing.Image)(resources.GetObject("mnuUserManual.Image")));
            this.mnuUserManual.Name = "mnuUserManual";
            this.mnuUserManual.Size = new System.Drawing.Size(174, 26);
            this.mnuUserManual.Text = "Manuel Utilisateur";
            this.mnuUserManual.Click += new System.EventHandler(this.mnuUserManual_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(174, 26);
            this.mnuAbout.Text = "A propos";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrpShortcuts
            // 
            this.toolStrpShortcuts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrpShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrpStandard,
            this.toolStrpScientific,
            this.toolStrpBureauxChange,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStrpEnLigne});
            this.toolStrpShortcuts.Location = new System.Drawing.Point(0, 24);
            this.toolStrpShortcuts.Name = "toolStrpShortcuts";
            this.toolStrpShortcuts.Size = new System.Drawing.Size(730, 27);
            this.toolStrpShortcuts.TabIndex = 4;
            this.toolStrpShortcuts.Text = "toolStrip1";
            // 
            // toolStrpStandard
            // 
            this.toolStrpStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpStandard.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpStandard.Image")));
            this.toolStrpStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpStandard.Name = "toolStrpStandard";
            this.toolStrpStandard.Size = new System.Drawing.Size(24, 24);
            this.toolStrpStandard.Text = "Standard";
            this.toolStrpStandard.Click += new System.EventHandler(this.toolStrpStandard_Click);
            // 
            // toolStrpScientific
            // 
            this.toolStrpScientific.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpScientific.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpScientific.Image")));
            this.toolStrpScientific.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpScientific.Name = "toolStrpScientific";
            this.toolStrpScientific.Size = new System.Drawing.Size(24, 24);
            this.toolStrpScientific.Text = "Scientific";
            this.toolStrpScientific.Click += new System.EventHandler(this.toolStrpScientific_Click);
            // 
            // toolStrpBureauxChange
            // 
            this.toolStrpBureauxChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBureauxChange.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpBureauxChange.Image")));
            this.toolStrpBureauxChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBureauxChange.Name = "toolStrpBureauxChange";
            this.toolStrpBureauxChange.Size = new System.Drawing.Size(24, 24);
            this.toolStrpBureauxChange.Text = "Bureaux Change";
            this.toolStrpBureauxChange.Click += new System.EventHandler(this.toolStrpBureauxChange_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrpEnLigne
            // 
            this.toolStrpEnLigne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpEnLigne.Enabled = false;
            this.toolStrpEnLigne.Image = ((System.Drawing.Image)(resources.GetObject("toolStrpEnLigne.Image")));
            this.toolStrpEnLigne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpEnLigne.Name = "toolStrpEnLigne";
            this.toolStrpEnLigne.Size = new System.Drawing.Size(24, 24);
            this.toolStrpEnLigne.Text = "Bureaux Change";
            this.toolStrpEnLigne.Click += new System.EventHandler(this.toolStrpEnLigne_Click);
            // 
            // statusStrp
            // 
            this.statusStrp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrp.Location = new System.Drawing.Point(0, 410);
            this.statusStrp.Name = "statusStrp";
            this.statusStrp.Size = new System.Drawing.Size(730, 22);
            this.statusStrp.TabIndex = 5;
            this.statusStrp.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 432);
            this.Controls.Add(this.statusStrp);
            this.Controls.Add(this.toolStrpShortcuts);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Lasalle College";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrpShortcuts.ResumeLayout(false);
            this.toolStrpShortcuts.PerformLayout();
            this.statusStrp.ResumeLayout(false);
            this.statusStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breuaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCalStandard;
        private System.Windows.Forms.ToolStripMenuItem mnuCalScientifique;
        private System.Windows.Forms.ToolStripMenuItem versionLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionEnLigneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitProgramme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrpShortcuts;
        private System.Windows.Forms.ToolStripButton toolStrpStandard;
        private System.Windows.Forms.ToolStripButton toolStrpScientific;
        private System.Windows.Forms.ToolStripButton toolStrpBureauxChange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStrpEnLigne;
        private System.Windows.Forms.StatusStrip statusStrp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnuUserManual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStrpToolbar;
        private System.Windows.Forms.ToolStripMenuItem toolStrpStatusBar;
    }
}


namespace Zadanie1_Mateusz_Moczarski
{
    partial class OdtwarzaczWavMoczarski
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.filepath = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.loadSyncButton = new System.Windows.Forms.Button();
            this.playSync = new System.Windows.Forms.Button();
            this.playAsync = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.loopAsync = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.loadAsyncButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.następnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poprzedniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileButton = new System.Windows.Forms.Button();
            this.playlist = new System.Windows.Forms.ListBox();
            this.directoriesList = new System.Windows.Forms.ListBox();
            this.filesList = new System.Windows.Forms.ListBox();
            this.clearList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filepath
            // 
            this.filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filepath.Location = new System.Drawing.Point(11, 73);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(463, 22);
            this.filepath.TabIndex = 1;
            this.filepath.TextChanged += new System.EventHandler(this.filepathTextbox_TextChanged);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.Location = new System.Drawing.Point(480, 73);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(23, 21);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "...";
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(11, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(492, 17);
            this.label.TabIndex = 3;
            this.label.Text = "Ścieżka pliku .wav lub adres URL:";
            // 
            // loadSyncButton
            // 
            this.loadSyncButton.Location = new System.Drawing.Point(329, 144);
            this.loadSyncButton.Name = "loadSyncButton";
            this.loadSyncButton.Size = new System.Drawing.Size(174, 80);
            this.loadSyncButton.TabIndex = 4;
            this.loadSyncButton.Text = "Załaduj synchronicznie (wstrzyma GUI)";
            this.loadSyncButton.Click += new System.EventHandler(this.loadSyncButton_Click);
            // 
            // playSync
            // 
            this.playSync.Location = new System.Drawing.Point(329, 230);
            this.playSync.Name = "playSync";
            this.playSync.Size = new System.Drawing.Size(174, 37);
            this.playSync.TabIndex = 5;
            this.playSync.Text = "Start (synchronicznie)";
            this.playSync.Click += new System.EventHandler(this.playOnceSyncButton_Click);
            // 
            // playAsync
            // 
            this.playAsync.Location = new System.Drawing.Point(11, 144);
            this.playAsync.Name = "playAsync";
            this.playAsync.Size = new System.Drawing.Size(312, 37);
            this.playAsync.TabIndex = 6;
            this.playAsync.Text = "Start (asynchroniczne)";
            this.playAsync.Click += new System.EventHandler(this.playOnceAsyncButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(11, 187);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(312, 37);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // loopAsync
            // 
            this.loopAsync.Location = new System.Drawing.Point(11, 230);
            this.loopAsync.Name = "loopAsync";
            this.loopAsync.Size = new System.Drawing.Size(312, 37);
            this.loopAsync.TabIndex = 8;
            this.loopAsync.Text = "Pętla";
            this.loopAsync.Click += new System.EventHandler(this.playLoopAsyncButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 389);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1009, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 9;
            this.statusBar.Text = "Pasek stanu";
            // 
            // loadAsyncButton
            // 
            this.loadAsyncButton.Location = new System.Drawing.Point(11, 101);
            this.loadAsyncButton.Name = "loadAsyncButton";
            this.loadAsyncButton.Size = new System.Drawing.Size(312, 37);
            this.loadAsyncButton.TabIndex = 10;
            this.loadAsyncButton.Text = "Załaduj asynchroniczne";
            this.loadAsyncButton.Click += new System.EventHandler(this.loadAsyncButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(329, 101);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 37);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "<<";
            this.backButton.Click += new System.EventHandler(this.previousSong);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(423, 101);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(80, 37);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = ">>";
            this.nextButton.Click += new System.EventHandler(this.nextSong);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem1,
            this.następnyToolStripMenuItem,
            this.poprzedniToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.playOnceAsyncButton_Click);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.stopToolStripMenuItem1.Text = "Stop";
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // następnyToolStripMenuItem
            // 
            this.następnyToolStripMenuItem.Name = "następnyToolStripMenuItem";
            this.następnyToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.następnyToolStripMenuItem.Text = "Następny";
            this.następnyToolStripMenuItem.Click += new System.EventHandler(this.nextSong);
            // 
            // poprzedniToolStripMenuItem
            // 
            this.poprzedniToolStripMenuItem.Name = "poprzedniToolStripMenuItem";
            this.poprzedniToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.poprzedniToolStripMenuItem.Text = "Poprzedni";
            this.poprzedniToolStripMenuItem.Click += new System.EventHandler(this.previousSong);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wybierzToolStripMenuItem
            // 
            this.wybierzToolStripMenuItem.Name = "wybierzToolStripMenuItem";
            this.wybierzToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.wybierzToolStripMenuItem.Text = "Wybierz...";
            this.wybierzToolStripMenuItem.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // addFileButton
            // 
            this.addFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFileButton.Location = new System.Drawing.Point(509, 230);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(488, 37);
            this.addFileButton.TabIndex = 14;
            this.addFileButton.Text = "Dodaj do playlisty";
            this.addFileButton.Click += new System.EventHandler(this.addFile);
            // 
            // playlist
            // 
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 16;
            this.playlist.Location = new System.Drawing.Point(509, 73);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(488, 148);
            this.playlist.TabIndex = 15;
            this.playlist.DoubleClick += new System.EventHandler(this.selectWave);
            // 
            // directoriesList
            // 
            this.directoriesList.FormattingEnabled = true;
            this.directoriesList.ItemHeight = 16;
            this.directoriesList.Location = new System.Drawing.Point(509, 273);
            this.directoriesList.Name = "directoriesList";
            this.directoriesList.Size = new System.Drawing.Size(237, 100);
            this.directoriesList.TabIndex = 16;
            this.directoriesList.DoubleClick += new System.EventHandler(this.selectDir);
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.ItemHeight = 16;
            this.filesList.Location = new System.Drawing.Point(760, 273);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(237, 100);
            this.filesList.TabIndex = 17;
            this.filesList.DoubleClick += new System.EventHandler(this.filesList_DoubleClick);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(423, 336);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(80, 37);
            this.clearList.TabIndex = 18;
            this.clearList.Text = "Czyść";
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // OdtwarzaczWavMoczarski
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1009, 411);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.directoriesList);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loadAsyncButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.loopAsync);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playAsync);
            this.Controls.Add(this.playSync);
            this.Controls.Add(this.loadSyncButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(310, 165);
            this.Name = "OdtwarzaczWavMoczarski";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Odtwarzacz WAV Moczarski";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button playSync;
        private System.Windows.Forms.Button playAsync;
        private System.Windows.Forms.Button loopAsync;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.Button loadSyncButton;
        private System.Windows.Forms.Button loadAsyncButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem następnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poprzedniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wybierzToolStripMenuItem;
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.ListBox directoriesList;
        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.Button clearList;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1_Mateusz_Moczarski
{
    public partial class OdtwarzaczWavMoczarski : Form
    {
        private SoundPlayer player;
        private string[] list;

        public OdtwarzaczWavMoczarski()
        {
            InitializeComponent();
            EnablePlaybackControls(false);
            InitializeControls();
            InitializeSound();
            InitializeBrowser();
        }

        private void InitializeBrowser()
        {
            list = Directory.GetFiles(@"C:\");
            foreach (string name in list)
            {
                if (File.Exists(name))
                {
                    // This path is a file
                    filesList.Items.Add(name);
                }
            }
            list = Directory.GetDirectories(@"C:\");
            foreach (string name in list)
            {
                if (Directory.Exists(name))
                {
                    // This path is a directory
                    directoriesList.Items.Add(name);
                }

            }
        }

        private void InitializeControls()
        {
            StatusBarPanel panel = new StatusBarPanel();
            panel.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            panel.Text = "Gotowe";
            panel.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBar.ShowPanels = true;
            this.statusBar.Panels.Add(panel);
        }

        private void InitializeSound()
        {
            player = new SoundPlayer();
            player.LoadCompleted += new AsyncCompletedEventHandler(player_LoadCompleted);
            player.SoundLocationChanged += new EventHandler(player_LocationChanged);
        }

        private void selectFileButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.filepath.Text = dlg.FileName;
                    player.SoundLocation = filepath.Text;
                }
                catch (Exception ex)
                {
                    ReportStatus(ex.Message);
                }
            }
        }

        private void ReportStatus(string statusMessage)
        {
            if (!string.IsNullOrEmpty(statusMessage))
            {
                try
                {
                     this.statusBar.Panels[0].Text = statusMessage;
                }
                catch (Exception ex)
                {
                    ReportStatus(ex.Message);
                }
            }
        }

        private void EnablePlaybackControls(bool enabled)
        {
            this.playSync.Enabled = enabled;
            this.playAsync.Enabled = enabled;
            this.loopAsync.Enabled = enabled;
            this.stopButton.Enabled = enabled;
        }

        private void filepathTextbox_TextChanged(object sender, EventArgs e)
        {
            EnablePlaybackControls(false);
        }

        private void loadSyncButton_Click(object sender, System.EventArgs e)
        {
            EnablePlaybackControls(false);

            try
            {
                player.SoundLocation = filepath.Text;
                player.Load();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void loadAsyncButton_Click(System.Object sender, System.EventArgs e)
        {
            EnablePlaybackControls(false);

            try
            {
                player.SoundLocation = this.filepath.Text;
                player.LoadAsync();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void playOnceSyncButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                ReportStatus("Odtwarzanie synchroniczne");
                player.PlaySync();
                ReportStatus("Odtwarzanie synchroniczne zakończone");
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void playOnceAsyncButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                ReportStatus("Odtwarzanie asynchroniczne");
                player.Play();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void playLoopAsyncButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                ReportStatus("Odtwarzanie w pętli");
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void stopButton_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                player.Stop();
                ReportStatus("Odtwarzanie zatrzymane");
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void player_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                string message = String.Format("Załadowano: {0}", this.filepath.Text);
                ReportStatus(message);
                EnablePlaybackControls(true);
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void player_LocationChanged(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("Nowy plik: {0}", player.SoundLocation);
                ReportStatus(message);
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void playSoundFromResource(object sender, EventArgs e)
        {
            try
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream s = a.GetManifestResourceStream("<AssemblyName>.chimes.wav");
                SoundPlayer player = new SoundPlayer(s);
                player.Play();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void addFile(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = dlg.FileName;
                    playlist.Items.Add(filePath);
                }
                catch (Exception ex)
                {
                    ReportStatus(ex.Message);
                }
            }
        }

        private void nextSong(object sender, EventArgs e)
        {
            try
            {
                if (playlist.SelectedIndex < playlist.Items.Count - 1)
                {
                    playlist.SelectedIndex = playlist.SelectedIndex + 1;
                }
                if (playlist.SelectedItem != null)
                {
                    this.filepath.Text = playlist.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void previousSong(object sender, EventArgs e)
        {  
            try
            {
                if (playlist.SelectedIndex > 0)
                {
                    playlist.SelectedIndex = playlist.SelectedIndex - 1;
                }
                if (playlist.SelectedItem != null)
                {
                    this.filepath.Text = playlist.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }

        private void selectWave(object sender, EventArgs e)
        {
            if (playlist.SelectedItem != null)
            {
                this.filepath.Text = playlist.SelectedItem.ToString();
            }
        }

        private void selectDir(object sender, EventArgs e)
        {
            string temp;
            try
            {
                temp = directoriesList.SelectedItem.ToString();
                list = Directory.GetFiles(temp);
                filesList.Items.Clear();

                foreach (string name in list)
                {

                    if (File.Exists(name))
                    {
                        filesList.Items.Add(name);
                    }
                }

                temp = directoriesList.SelectedItem.ToString();
                list = Directory.GetDirectories(temp);
                directoriesList.Items.Clear();

                foreach (string name in list)
                {
                    if (Directory.Exists(name))
                    {
                        directoriesList.Items.Add(name);
                    }

                }
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }

        }

        private void clearList_Click(object sender, EventArgs e)
        {
            directoriesList.Items.Clear();
            filesList.Items.Clear();
            InitializeBrowser();
        }

        private void filesList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = filesList.SelectedItem.ToString();
                playlist.Items.Add(filePath);
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GrooveStation_HARDWARE
{
    public partial class HardwareInterface : Form
    {
        public HardwareInterface()
        {
            InitializeComponent();
            Player.uiMode = "invisible";
            Player.Visible = false;
            Player.settings.autoStart = false;
            Player.settings.volume = 100;
            timer1.Start();
        }

        //FIELDS
        public List<Track> playlist = new List<Track>();
        private bool isTestMode = false;
        private static Random rng = new Random();
        private string selectedSong;
        private int timeLeft = 30;
        private bool isPlaying = false;
        private bool isDragging;
        private Point lastLocation;



        //METHODS
        public void btn_Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Audio files (*.mp3;*.wav)|*.mp3;*.wav|All files (*.*)|*.*";
                open.RestoreDirectory = true;
                string[] filePath;
                string[] fileContent;
                open.InitialDirectory = @"C:\";
                open.Title = "Load Grooves...";
                open.Multiselect = true;
                open.ShowDialog();
                filePath = open.FileNames;
                fileContent = open.FileNames;

                //Loop through the opened files and use the Playlist class to unpack the data.
                for (int i = 0; i < fileContent.Length; i++)
                {
                    Track trackToAdd = new Track();
                    trackToAdd.PlaylistID = i;
                    trackToAdd.TrackTitle = fileContent[i].Substring(fileContent[i].LastIndexOf("\\") + 1);
                    trackToAdd.TrackAddress = fileContent[i];
                    trackToAdd.Runtime = fileContent[i];
                    playlist.Add(trackToAdd);
                }
            }
            lb_FilePath.DataSource = playlist;
            lb_FilePath.DisplayMember = "TrackTitle";
            lb_FilePath.ValueMember = "TrackAddress";

            //Ensure that the first item on the playlist is assigned as globally 'selected' so that user can press 'Preview' button immediately.
            if (lb_FilePath.SelectedValue != null)
            {
                selectedSong = lb_FilePath.SelectedValue.ToString();
            }

            ResetTimer(sender, e);
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            // Only proceed if the listbox has items inside.
            if (lb_FilePath.Items.Count > 0 && lb_FilePath.SelectedIndex != -1)
            {
                if (isTestMode)
                {
                    MessageBox.Show("Test mode is enabled. Transfer-simulation of Audio file(s) complete.", "Test Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Retrieve external device.
                string usbDrivePath = FindUSBDrive();

                if (usbDrivePath == null)
                {
                    MessageBox.Show("No USB drive detected. Please connect your portable device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Create a directory on the USB drive to store the playlist
                    string playlistDirectory = Path.Combine(usbDrivePath, "Playlist");
                    Directory.CreateDirectory(playlistDirectory);

                    // Copy each track in the playlist to the USB drive
                    foreach (Track track in playlist)
                    {
                        string fileName = Path.GetFileName(track.TrackAddress);
                        string destinationPath = Path.Combine(playlistDirectory, fileName);

                        File.Copy(track.TrackAddress, destinationPath, true);
                    }

                    MessageBox.Show("Playlist transferred successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error transferring playlist: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string FindUSBDrive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    return drive.RootDirectory.FullName;
                }
            }
            return null;
        }

        private void lb_FilePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSong = lb_FilePath.SelectedValue.ToString();
            ResetTimer(sender, e);
        }

        public void btn_Shuffle_Click(object sender, EventArgs e)
        {
            var shuffledcards = playlist.OrderBy(_ => rng.Next()).ToList();
            lb_FilePath.DataSource = shuffledcards;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            lb_FilePath.DataSource = null;
            lb_FilePath.Items.Clear();
            lb_FilePath.DataSource = playlist;
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            isTestMode = !isTestMode;
            if (isTestMode)
            {
                btn_Test.BackColor = Color.LightCoral;
                btn_Test.Text = "Disable Test mode";
            }
            else
            {
                btn_Test.BackColor = Color.MediumSeaGreen;
                btn_Test.Text = "Enable Test mode";
            }
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                Player.Ctlcontrols.pause();
                isPlaying = !isPlaying;
                btn_Preview.BackColor = Color.White;
                btn_Preview.Text = "Preview";
                ResetTimer(sender, e);
            }
            else
            if (selectedSong != null)
            {
                Player.URL = selectedSong;
                Player.Ctlcontrols.play();
                isPlaying = !isPlaying;
                btn_Preview.BackColor = Color.LightCoral;
                btn_Preview.Text = "Stop";
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Audio must be loaded into playlist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimeSpan result = TimeSpan.FromSeconds(timeLeft);
                string fromTimeString = result.ToString("mm':'ss");
                lb_Countdown.Text = fromTimeString;
            }
            else
            {
                timer1.Stop();
                lb_Countdown.Text = "00:00";
                lb_IdleWarning.Visible = true;
            }
        }

        private void HardwareInterface_Click(object sender, EventArgs e)
        {
            ResetTimer(sender, e);
        }

        private void label_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HardwareInterface_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
            ResetTimer(sender, e);
        }
        private void HardwareInterface_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void HardwareInterface_MouseMove(object sender, MouseEventArgs e)
        {
            //MOVING THE APP LOCATION
            if (isDragging)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
                ResetTimer(sender, e);
            }
        }

        private void ResetTimer(object sender, EventArgs e)
        {
            timeLeft = 30;
            lb_Countdown.Text = "00:30";
            timer1.Start();
            timer1_Tick(sender, e);
        }
    }


}

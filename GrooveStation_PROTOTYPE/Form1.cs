using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GrooveStation_PROTOTYPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Player.uiMode = "invisible";
            Player.Visible = false;
            Player.settings.autoStart = false;
        }

        //FIELDS

        AxWindowsMediaPlayer Station = new AxWindowsMediaPlayer();
        List<Playlist> playlist = new List<Playlist>();
        private string selectedSong;
        private int volume = 100;
        private bool isDragging;
        private Point lastLocation;


        //FUNCTIONS

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
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
                    Playlist trackToAdd = new Playlist();
                    trackToAdd.PlaylistID = i;
                    trackToAdd.TrackTitle = fileContent[i].Substring(fileContent[i].LastIndexOf("\\") + 1);
                    trackToAdd.TrackAddress = fileContent[i];
                    trackToAdd.Runtime = Player.newMedia(fileContent[i]).durationString;
                    playlist.Add(trackToAdd);
                }

                //Update the TRACKS UI listbox.
                lb_Songs.DataSource = playlist;
                lb_Songs.DisplayMember = "TrackTitle";
                lb_Songs.ValueMember = "TrackAddress";

                //Ensure that the first item on the playlist is assigned as globally 'selected' so that user can press 'Play' button immediately.
                selectedSong = lb_Songs.SelectedValue.ToString();
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if ((Player.playState == WMPPlayState.wmppsUndefined || Player.playState == WMPPlayState.wmppsReady) || (Player.playState == WMPPlayState.wmppsPaused && selectedSong != Player.URL))
            {
                Player.URL = selectedSong;
                Player.Ctlcontrols.play();
                btn_Play.Text = "Pause";
            }
            else if (Player.playState == WMPPlayState.wmppsPlaying)
            {
                Player.Ctlcontrols.pause();
                btn_Play.Text = "Play";
            }
            else if (Player.playState == WMPPlayState.wmppsPaused)
            {
                Player.Ctlcontrols.play();
                btn_Play.Text = "Pause";
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
            progressBar1.Value = (int)Player.Ctlcontrols.currentPosition;
        }
    }
}

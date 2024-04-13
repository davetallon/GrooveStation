using GrooveStation.PRESENTER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;
using System.Threading.Tasks;
using System.Linq;

// ICONS FOUND @  https://icons8.com/ 

namespace GrooveStation
{
    public partial class GrooveStationClass : Form
    {
        // CREATE INSTANCE OF PRESENTER LAYER
        MusicControlsPresenter presenter = new MusicControlsPresenter();

        // CREATE INSTANCE OF TRACK LIST FOR USE HERE (IN VIEW LAYER).
        List<Track> playlist = new List<Track>();


        // PRIVATE FIELDS
        private int volume = 0;
        private int volumeHandler = 0;
        private bool isDragging;
        private int flicker = 0;
        private Point lastLocation;
        PointF offsetHover = new PointF(109, 106);
        PointF offsetStatic = new PointF(104.8f, 103.5f);
        private Bitmap bm_volumeImageHover = Properties.Resources.ART_HOVER_Volume;
        private Bitmap bm_volumeImageStatic = Properties.Resources.ART_BASE_Volume_NOShadow;
        float Angle = 9f;
        private static Random rng = new Random();

        // PUBLIC FIELDS (FOR TESTING) - some functions are also exposed publicly for testing purposes.
        public string selectedSong;


        // CONSTRUCTOR
        public GrooveStationClass()
        {
            InitializeComponent();
            Player.uiMode = "invisible";
            Player.Visible = false;
            Player.settings.autoStart = false;
            Player.settings.volume = 0;

            // SET INITIAL HOVER-IMAGES TO HIDE
            AdjustViewState("SetTransparencies");
            AdjustViewState("DisableHoverImages");

            // EVENT LISTENERS
            presenter.MusicLoaded += Presenter_MusicLoaded;
            Player.PlayStateChange += Player_PlayStateChange;
        }


        // EVENT HANDLERS
        private void Presenter_MusicLoaded(object sender, EventArgs e)
        {
            // Grab the tracklist from the presenter layer
            playlist = presenter.tracklist;

            // Assign the runtime for each song by.
            for (int i = 0; i < playlist.Count; i++)
            {
                playlist[i].Runtime = Player.newMedia(playlist[i].Runtime).durationString;
            }

            // Update the TRACKS UI listbox.
            lb_Songs.DataSource = playlist;
            lb_Songs.DisplayMember = "TrackTitle";
            lb_Songs.ValueMember = "TrackAddress";

            //Update the RUNTIME UI listbox.
            lb_Runtime.DataSource = playlist;
            lb_Runtime.DisplayMember = "Runtime";
            lb_Runtime.ValueMember = "Runtime";

            // Ensure that the first item on the playlist is assigned as globally 'selected' so that user can press 'Play' button immediately.
            if (lb_Songs.SelectedValue != null)
            {
                selectedSong = lb_Songs.SelectedValue.ToString();
            }
        }

        private void Player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPPlayState.wmppsMediaEnded)
            {
                // Play next song if current song ends.
                pb_NextSong_Click(sender, null);
            }
        }


        // LOADING MUSIC
        private void pb_LoadGrooves_Click(object sender, EventArgs e)
        {
            presenter.onLoadingMusic("Local");
        }


        // PLAY CONTROLS (Some publicly exposed for testing purposes.)
        public void PlayTrack()
        {
            if (selectedSong != null)
            {
                timer2.Start();
                Player.Ctlcontrols.play();
                AdjustViewState("Play");
            }
            else
            {
                return;
            }
        }
        public void PauseTrack()
        {
            Player.Ctlcontrols.pause();
            AdjustViewState("Pause");
        }
        private void pb_PlayPause_Click(object sender, EventArgs e)
        {
            if ((Player.playState == WMPPlayState.wmppsUndefined && selectedSong != null) || Player.playState == WMPPlayState.wmppsReady || (Player.playState == WMPPlayState.wmppsPaused && selectedSong != Player.URL))
            {
                Player.URL = selectedSong;
                AdjustViewState("Play");
                PlayTrack();
            }
            else if (Player.playState == WMPPlayState.wmppsPaused)
            {
                AdjustViewState("Play");
                PlayTrack();             
            }
        }
        private void pb_Pause_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPPlayState.wmppsPlaying)
            {
                PauseTrack();
            }
        }



        // SONG NAVIGATION
        private void pb_NextSong_Click(object sender, EventArgs e)
        {
            //FIRST, ERROR-HANDLE MAXIMUM SONG BOUNDS
            if (lb_Songs.SelectedIndex == -1 || lb_Songs.SelectedIndex >= playlist.Count - 1) { return; }

            lb_Songs.SelectedIndex = lb_Songs.SelectedIndex + 1;
            Player.URL = lb_Songs.SelectedValue.ToString();
            Player.Ctlcontrols.next();
            PlayTrack();
        }

        private void pb_PrevSong_Click(object sender, EventArgs e)
        {
            // FIRST, ERROR-HANDLE MINIMUM SONG BOUNDS
            if (lb_Songs.SelectedIndex == -1 || lb_Songs.SelectedIndex == 0) { return; }

            lb_Songs.SelectedIndex = lb_Songs.SelectedIndex - 1;
            Player.URL = lb_Songs.SelectedValue.ToString();
            Player.Ctlcontrols.previous();
            PlayTrack();
        }
        private void lb_Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSong = lb_Songs.SelectedValue.ToString();
        }

        private void lb_Songs_DoubleClick(object sender, EventArgs e)
        {
            Player.URL = selectedSong;
            PlayTrack();
        }



        // MUTE CONTROLS
        private void pb_Headphones_Playing_Click(object sender, EventArgs e)
        {
            Player.settings.mute = !Player.settings.mute;
            AdjustViewState("MuteUnmute");
        }
        private void pb_Headphones_Mute_Click(object sender, EventArgs e)
        {
            Player.settings.mute = !Player.settings.mute;
            AdjustViewState("MuteUnmute");
        }



        // APP INTERACTION
        private void pb_SongProgress_MouseDown(object sender, MouseEventArgs e)
        {
            if(Player.Ctlcontrols.currentPosition != 0)
            {
                Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / pb_SongProgress.Width;
            }
        }
        private void pb_CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GrooveStation_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }
        private void GrooveStation_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void GrooveStation_MouseMove(object sender, MouseEventArgs e)
        {
            // MOVING THE APP LOCATION
            if (isDragging)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }


            // CLOSE APP HOVER
            if (pb_CloseApp.Bounds.Contains(e.Location) && !pb_CloseApp.Visible)
            {
                pb_CloseApp.Show();
            }
            else
            {
                //Double buffered helps prevent flicker.
                DoubleBuffered = true;
                pb_CloseApp.Hide();
            }

            // PLAY HOVER
            if ((pb_PlayPause.Bounds.Contains(e.Location) && !pb_PlayPause.Visible) && (Player.playState == WMPPlayState.wmppsUndefined || Player.playState == WMPPlayState.wmppsReady || Player.playState == WMPPlayState.wmppsPaused))
            {
                pb_PlayPause.Show();
            }
            else
            {
                DoubleBuffered = true;
                pb_PlayPause.Hide();
            }

            // NEXT SONG HOVER
            if (pb_NextSong.Bounds.Contains(e.Location) && !pb_NextSong.Visible)
            {
                pb_NextSong.Show();
            }
            else
            {
                pb_NextSong.Hide();
            }

            // PREV SONG HOVER
            if (pb_PrevSong.Bounds.Contains(e.Location) && !pb_PrevSong.Visible)
            {
                pb_PrevSong.Show();
            }
            else
            {
                pb_PrevSong.Hide();
            }

            // LOAD GROOVES HOVER
            if (pb_LoadGrooves.Bounds.Contains(e.Location) && !pb_LoadGrooves.Visible)
            {
                pb_LoadGrooves.Show();
            }
            else
            {
                pb_LoadGrooves.Hide();
            }

            // CREDITS HOVER
            if (pb_credits.Bounds.Contains(e.Location) && !pb_credits.Visible)
            {
                pb_credits.Show();
            }
            else
            {
                pb_credits.Hide();
            }

            // SHUFFLE HOVER
            if (pb_shuffle_hover.Bounds.Contains(e.Location) && !pb_shuffle_hover.Visible)
            {
                pb_shuffle_hover.Show();
            }
            else 
            {
                DoubleBuffered = true;
                pb_shuffle_hover.Hide(); 
            }
        }
        private void pb_CloseApp_MouseLeave(object sender, EventArgs e)
        {
            pb_CloseApp.Hide();
        }

        private void pb_shuffle_hover_MouseLeave(object sender, EventArgs e)
        {
            pb_shuffle_hover.Hide();
        }
        private void pb_credits_Click(object sender, EventArgs e)
        {
            AdjustViewState("CreditsToggle");
        }
        private void pb_creditsPicture_Click(object sender, EventArgs e)
        {
            AdjustViewState("CreditsToggle");
        }



        // VOLUME
        private void pb_Volume_Click(object sender, EventArgs e)
        {
            AdjustViewState("GrabVolume");
            pb_VolumeHover.Image = presenter.onRotateImage(bm_volumeImageHover, offsetHover, Angle);
            pb_Volume.Image = presenter.onRotateImage(bm_volumeImageStatic, offsetStatic, Angle);
        }
        private void pb_Volume_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Angle = -e.Y / 4;
                pb_Volume_Click(sender, e);

                volumeHandler = (int)(Angle * 0.2);
                tb_Volume.Value = volume + volumeHandler;
                Player.settings.volume = tb_Volume.Value;
            }
        }

        private void pb_Volume_MouseUp(object sender, MouseEventArgs e)
        {
            volume = Player.settings.volume;
            AdjustViewState("ReleaseVolume");
            bm_volumeImageStatic = (Bitmap)pb_Volume.Image;
            bm_volumeImageHover = (Bitmap)pb_VolumeHover.Image;
        }


        // MISCELLANEOUS
        public void AdjustViewState(string viewState)
        {
            switch (viewState)
            {
                case "Play":
                    pb_Pause.Visible = true;
                    pb_PlayPause.Visible = false;
                    pb_Headphones_Playing.Visible = (!Player.settings.mute) ? true : false;
                    pb_valvesPlaying.Visible = true;
                    break;

                case "Pause":
                    pb_Pause.Visible = false;
                    pb_PlayPause.Visible = true;
                    pb_Headphones_Playing.Visible = false;
                    pb_valvesPlaying.Visible = false;
                    pb_ValvesOff.Visible = true;
                    break;

                case "MuteUnmute":
                    pb_Headphones_Mute.Visible = !pb_Headphones_Mute.Visible;
                    pb_Headphones_Playing.Visible = !pb_Headphones_Playing.Visible;
                    pb_Headphones_Playing.Visible = (Player.playState == WMPPlayState.wmppsPaused) ? !pb_Headphones_Playing.Visible : pb_Headphones_Playing.Visible;

                    break;

                case "SetTransparencies":
                    pb_Volume.BackColor = Color.Transparent;
                    pb_VolumeHover.BackColor = Color.Transparent;
                    pb_CloseApp.BackColor = Color.Transparent;
                    pb_Headphones_Playing.BackColor = Color.Transparent;
                    pb_Headphones_Mute.BackColor = Color.Transparent;
                    pb_PlayPause.BackColor = Color.Transparent;
                    pb_Pause.BackColor = Color.Transparent;
                    pb_NextSong.BackColor = Color.Transparent;
                    pb_PrevSong.BackColor = Color.Transparent;
                    pb_LoadGrooves.BackColor = Color.Transparent;
                    pb_valvesPlaying.BackColor = Color.Transparent;
                    pb_credits.BackColor = Color.Transparent;
                    pb_creditsPicture.BackColor = Color.Transparent;
                    pb_shuffle.BackColor = Color.Transparent;
                    pb_shuffle_hover.BackColor = Color.Transparent;
                    break;

                case "DisableHoverImages":
                    pb_Pause.Visible = false;
                    pb_NextSong.Visible = false;
                    pb_PrevSong.Visible = false;
                    pb_LoadGrooves.Visible = false;
                    pb_Headphones_Playing.Visible = false;
                    pb_Headphones_Mute.Visible = false;
                    pb_VolumeHover.Visible = false;
                    pb_valvesPlaying.Visible = false;
                    pb_credits.Visible = false;
                    pb_creditsPicture.Visible = false;
                    pb_shuffle_hover.Visible = false;
                    break;

                case "CreditsToggle":
                    pb_creditsPicture.Visible = !pb_creditsPicture.Visible;
                    break;

                case "GrabVolume":
                    pb_VolumeHover.Visible = true;
                    pb_Volume.Visible = false;
                    break;

                case "ReleaseVolume":
                    pb_VolumeHover.Visible = false;
                    pb_Volume.Visible = true;
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPPlayState.wmppsPlaying)
            {
                pb_SongProgress.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                pb_SongProgress.Value = (int)Player.Ctlcontrols.currentPosition;
            }
        }

        // FLICKER EFFECT FOR VALVES
        private async void timer2_Tick(object sender, EventArgs e)
        {
            if (flicker++ < 8)
            {
                if (flicker <= 4)
                {
                    pb_valvesPlaying.Visible = !pb_valvesPlaying.Visible;
                }
                else
                {
                    await Task.Delay(50);
                    timer2.Interval = 50;
                    pb_valvesPlaying.Visible = !pb_valvesPlaying.Visible;
                }
            }
            else
            {
                timer2.Stop();
                flicker = 0;
                timer2.Interval = 125;
            }
        }

        private void Player_MediaError(object sender, _WMPOCXEvents_MediaErrorEvent e)
        {
            // Error handling in case app encounters error such as invalid URL for track.
            // If the Player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            try
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }

        }

        private void pb_shuffle_hover_Click(object sender, EventArgs e)
        {
            var shuffledcards = playlist.OrderBy(_ => rng.Next()).ToList();
            lb_Songs.DataSource = shuffledcards;
            lb_Runtime.DataSource = shuffledcards;
        }
    }
}


namespace GrooveStation
{
    partial class GrooveStationClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrooveStationClass));
            this.pb_Headphones_Playing = new System.Windows.Forms.PictureBox();
            this.tb_Volume = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_Songs = new System.Windows.Forms.ListBox();
            this.pb_SongProgress = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Runtime = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pb_ValvesOff = new System.Windows.Forms.PictureBox();
            this.pb_Volume = new System.Windows.Forms.PictureBox();
            this.pb_PlayPause = new System.Windows.Forms.PictureBox();
            this.pb_Pause = new System.Windows.Forms.PictureBox();
            this.pb_Headphones_Mute = new System.Windows.Forms.PictureBox();
            this.pb_CloseApp = new System.Windows.Forms.PictureBox();
            this.pb_NextSong = new System.Windows.Forms.PictureBox();
            this.pb_PrevSong = new System.Windows.Forms.PictureBox();
            this.pb_LoadGrooves = new System.Windows.Forms.PictureBox();
            this.pb_VolumeHover = new System.Windows.Forms.PictureBox();
            this.pb_valvesPlaying = new System.Windows.Forms.PictureBox();
            this.pb_credits = new System.Windows.Forms.PictureBox();
            this.pb_creditsPicture = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pb_shuffle = new System.Windows.Forms.PictureBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pb_shuffle_hover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Headphones_Playing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ValvesOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Headphones_Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PrevSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoadGrooves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VolumeHover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_valvesPlaying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_credits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_creditsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_shuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_shuffle_hover)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Headphones_Playing
            // 
            this.pb_Headphones_Playing.Image = global::GrooveStation.Properties.Resources.ART_PLAYING_Headphones;
            this.pb_Headphones_Playing.Location = new System.Drawing.Point(1000, 401);
            this.pb_Headphones_Playing.Name = "pb_Headphones_Playing";
            this.pb_Headphones_Playing.Size = new System.Drawing.Size(94, 65);
            this.pb_Headphones_Playing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Headphones_Playing.TabIndex = 5;
            this.pb_Headphones_Playing.TabStop = false;
            this.pb_Headphones_Playing.Click += new System.EventHandler(this.pb_Headphones_Playing_Click);
            // 
            // tb_Volume
            // 
            this.tb_Volume.Location = new System.Drawing.Point(548, 788);
            this.tb_Volume.Maximum = 100;
            this.tb_Volume.Minimum = -100;
            this.tb_Volume.Name = "tb_Volume";
            this.tb_Volume.Size = new System.Drawing.Size(126, 45);
            this.tb_Volume.TabIndex = 2;
            this.tb_Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_Volume.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_Songs
            // 
            this.lb_Songs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Songs.FormattingEnabled = true;
            this.lb_Songs.Location = new System.Drawing.Point(269, 486);
            this.lb_Songs.Name = "lb_Songs";
            this.lb_Songs.Size = new System.Drawing.Size(168, 143);
            this.lb_Songs.TabIndex = 6;
            this.lb_Songs.SelectedIndexChanged += new System.EventHandler(this.lb_Songs_SelectedIndexChanged);
            this.lb_Songs.DoubleClick += new System.EventHandler(this.lb_Songs_DoubleClick);
            // 
            // pb_SongProgress
            // 
            this.pb_SongProgress.Location = new System.Drawing.Point(269, 677);
            this.pb_SongProgress.Name = "pb_SongProgress";
            this.pb_SongProgress.Size = new System.Drawing.Size(646, 23);
            this.pb_SongProgress.TabIndex = 7;
            this.pb_SongProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_SongProgress_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Runtime
            // 
            this.lb_Runtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Runtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_Runtime.FormattingEnabled = true;
            this.lb_Runtime.Location = new System.Drawing.Point(443, 486);
            this.lb_Runtime.Name = "lb_Runtime";
            this.lb_Runtime.Size = new System.Drawing.Size(59, 143);
            this.lb_Runtime.TabIndex = 8;
            // 
            // pb_ValvesOff
            // 
            this.pb_ValvesOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_ValvesOff.BackgroundImage")));
            this.pb_ValvesOff.Location = new System.Drawing.Point(7, 5);
            this.pb_ValvesOff.Name = "pb_ValvesOff";
            this.pb_ValvesOff.Size = new System.Drawing.Size(1236, 389);
            this.pb_ValvesOff.TabIndex = 13;
            this.pb_ValvesOff.TabStop = false;
            // 
            // pb_Volume
            // 
            this.pb_Volume.Image = global::GrooveStation.Properties.Resources.ART_BASE_Volume;
            this.pb_Volume.Location = new System.Drawing.Point(951, 476);
            this.pb_Volume.Name = "pb_Volume";
            this.pb_Volume.Size = new System.Drawing.Size(231, 248);
            this.pb_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Volume.TabIndex = 15;
            this.pb_Volume.TabStop = false;
            this.pb_Volume.Click += new System.EventHandler(this.pb_Volume_Click);
            this.pb_Volume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Volume_MouseMove);
            this.pb_Volume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_Volume_MouseUp);
            // 
            // pb_PlayPause
            // 
            this.pb_PlayPause.Image = global::GrooveStation.Properties.Resources.ART_HOVER_Play;
            this.pb_PlayPause.Location = new System.Drawing.Point(809, 501);
            this.pb_PlayPause.Name = "pb_PlayPause";
            this.pb_PlayPause.Size = new System.Drawing.Size(111, 112);
            this.pb_PlayPause.TabIndex = 16;
            this.pb_PlayPause.TabStop = false;
            this.pb_PlayPause.Click += new System.EventHandler(this.pb_PlayPause_Click);
            // 
            // pb_Pause
            // 
            this.pb_Pause.Image = global::GrooveStation.Properties.Resources.ART_PLAYING_Pause;
            this.pb_Pause.Location = new System.Drawing.Point(809, 502);
            this.pb_Pause.Name = "pb_Pause";
            this.pb_Pause.Size = new System.Drawing.Size(111, 112);
            this.pb_Pause.TabIndex = 17;
            this.pb_Pause.TabStop = false;
            this.pb_Pause.Click += new System.EventHandler(this.pb_Pause_Click);
            // 
            // pb_Headphones_Mute
            // 
            this.pb_Headphones_Mute.Image = global::GrooveStation.Properties.Resources.ART_HOVER_HeadphonesMute;
            this.pb_Headphones_Mute.Location = new System.Drawing.Point(1000, 401);
            this.pb_Headphones_Mute.Name = "pb_Headphones_Mute";
            this.pb_Headphones_Mute.Size = new System.Drawing.Size(94, 65);
            this.pb_Headphones_Mute.TabIndex = 18;
            this.pb_Headphones_Mute.TabStop = false;
            this.pb_Headphones_Mute.Click += new System.EventHandler(this.pb_Headphones_Mute_Click);
            // 
            // pb_CloseApp
            // 
            this.pb_CloseApp.Image = global::GrooveStation.Properties.Resources.ART_HOVER_Close_B;
            this.pb_CloseApp.Location = new System.Drawing.Point(1237, 365);
            this.pb_CloseApp.Name = "pb_CloseApp";
            this.pb_CloseApp.Size = new System.Drawing.Size(103, 101);
            this.pb_CloseApp.TabIndex = 19;
            this.pb_CloseApp.TabStop = false;
            this.pb_CloseApp.Click += new System.EventHandler(this.pb_CloseApp_Click);
            this.pb_CloseApp.MouseLeave += new System.EventHandler(this.pb_CloseApp_MouseLeave);
            // 
            // pb_NextSong
            // 
            this.pb_NextSong.Image = global::GrooveStation.Properties.Resources.ART_HOVER_NextSong;
            this.pb_NextSong.Location = new System.Drawing.Point(733, 504);
            this.pb_NextSong.Name = "pb_NextSong";
            this.pb_NextSong.Size = new System.Drawing.Size(57, 59);
            this.pb_NextSong.TabIndex = 20;
            this.pb_NextSong.TabStop = false;
            this.pb_NextSong.Click += new System.EventHandler(this.pb_NextSong_Click);
            // 
            // pb_PrevSong
            // 
            this.pb_PrevSong.Image = global::GrooveStation.Properties.Resources.ART_HOVER_PreviousSong;
            this.pb_PrevSong.Location = new System.Drawing.Point(558, 505);
            this.pb_PrevSong.Name = "pb_PrevSong";
            this.pb_PrevSong.Size = new System.Drawing.Size(57, 59);
            this.pb_PrevSong.TabIndex = 21;
            this.pb_PrevSong.TabStop = false;
            this.pb_PrevSong.Click += new System.EventHandler(this.pb_PrevSong_Click);
            // 
            // pb_LoadGrooves
            // 
            this.pb_LoadGrooves.Image = global::GrooveStation.Properties.Resources.ART_HOVER_Load;
            this.pb_LoadGrooves.Location = new System.Drawing.Point(645, 504);
            this.pb_LoadGrooves.Name = "pb_LoadGrooves";
            this.pb_LoadGrooves.Size = new System.Drawing.Size(57, 59);
            this.pb_LoadGrooves.TabIndex = 22;
            this.pb_LoadGrooves.TabStop = false;
            this.pb_LoadGrooves.Click += new System.EventHandler(this.pb_LoadGrooves_Click);
            // 
            // pb_VolumeHover
            // 
            this.pb_VolumeHover.Image = global::GrooveStation.Properties.Resources.ART_HOVER_Volume;
            this.pb_VolumeHover.Location = new System.Drawing.Point(949, 476);
            this.pb_VolumeHover.Name = "pb_VolumeHover";
            this.pb_VolumeHover.Size = new System.Drawing.Size(218, 210);
            this.pb_VolumeHover.TabIndex = 23;
            this.pb_VolumeHover.TabStop = false;
            // 
            // pb_valvesPlaying
            // 
            this.pb_valvesPlaying.Image = global::GrooveStation.Properties.Resources.ART_PLAYING_Valves;
            this.pb_valvesPlaying.Location = new System.Drawing.Point(182, 60);
            this.pb_valvesPlaying.Name = "pb_valvesPlaying";
            this.pb_valvesPlaying.Size = new System.Drawing.Size(1051, 334);
            this.pb_valvesPlaying.TabIndex = 24;
            this.pb_valvesPlaying.TabStop = false;
            // 
            // pb_credits
            // 
            this.pb_credits.Image = global::GrooveStation.Properties.Resources.ART_HOVER_Credits;
            this.pb_credits.Location = new System.Drawing.Point(184, 532);
            this.pb_credits.Name = "pb_credits";
            this.pb_credits.Size = new System.Drawing.Size(50, 49);
            this.pb_credits.TabIndex = 25;
            this.pb_credits.TabStop = false;
            this.pb_credits.Click += new System.EventHandler(this.pb_credits_Click);
            // 
            // pb_creditsPicture
            // 
            this.pb_creditsPicture.Image = global::GrooveStation.Properties.Resources.CREDITS__3_;
            this.pb_creditsPicture.Location = new System.Drawing.Point(475, 297);
            this.pb_creditsPicture.Name = "pb_creditsPicture";
            this.pb_creditsPicture.Size = new System.Drawing.Size(503, 506);
            this.pb_creditsPicture.TabIndex = 26;
            this.pb_creditsPicture.TabStop = false;
            this.pb_creditsPicture.Click += new System.EventHandler(this.pb_creditsPicture_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 125;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pb_shuffle
            // 
            this.pb_shuffle.Image = global::GrooveStation.Properties.Resources.ART_BASE_Shuffle;
            this.pb_shuffle.Location = new System.Drawing.Point(1171, 486);
            this.pb_shuffle.Name = "pb_shuffle";
            this.pb_shuffle.Size = new System.Drawing.Size(40, 40);
            this.pb_shuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_shuffle.TabIndex = 27;
            this.pb_shuffle.TabStop = false;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(548, 743);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(198, 39);
            this.Player.TabIndex = 0;
            this.Player.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.Player_MediaError);
            // 
            // pb_shuffle_hover
            // 
            this.pb_shuffle_hover.Image = global::GrooveStation.Properties.Resources.ART_HOVER_Shuffle1;
            this.pb_shuffle_hover.Location = new System.Drawing.Point(1160, 476);
            this.pb_shuffle_hover.Name = "pb_shuffle_hover";
            this.pb_shuffle_hover.Size = new System.Drawing.Size(61, 65);
            this.pb_shuffle_hover.TabIndex = 28;
            this.pb_shuffle_hover.TabStop = false;
            this.pb_shuffle_hover.Click += new System.EventHandler(this.pb_shuffle_hover_Click);
            this.pb_shuffle_hover.MouseLeave += new System.EventHandler(this.pb_shuffle_hover_MouseLeave);
            // 
            // GrooveStationClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GrooveStation.Properties.Resources.ART_BASE_Amp1;
            this.ClientSize = new System.Drawing.Size(1581, 841);
            this.Controls.Add(this.pb_shuffle_hover);
            this.Controls.Add(this.pb_shuffle);
            this.Controls.Add(this.pb_creditsPicture);
            this.Controls.Add(this.pb_credits);
            this.Controls.Add(this.pb_valvesPlaying);
            this.Controls.Add(this.pb_VolumeHover);
            this.Controls.Add(this.pb_LoadGrooves);
            this.Controls.Add(this.pb_PrevSong);
            this.Controls.Add(this.pb_NextSong);
            this.Controls.Add(this.pb_CloseApp);
            this.Controls.Add(this.pb_Pause);
            this.Controls.Add(this.pb_PlayPause);
            this.Controls.Add(this.pb_Volume);
            this.Controls.Add(this.tb_Volume);
            this.Controls.Add(this.pb_Headphones_Playing);
            this.Controls.Add(this.lb_Runtime);
            this.Controls.Add(this.pb_SongProgress);
            this.Controls.Add(this.lb_Songs);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pb_ValvesOff);
            this.Controls.Add(this.pb_Headphones_Mute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrooveStationClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrooveStation";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GrooveStation_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GrooveStation_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GrooveStation_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Headphones_Playing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ValvesOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Headphones_Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PrevSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoadGrooves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VolumeHover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_valvesPlaying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_credits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_creditsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_shuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_shuffle_hover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lb_Songs;
        private System.Windows.Forms.ProgressBar pb_SongProgress;
        private System.Windows.Forms.TrackBar tb_Volume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lb_Runtime;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pb_ValvesOff;
        private System.Windows.Forms.PictureBox pb_Volume;
        private System.Windows.Forms.PictureBox pb_Headphones_Mute;
        private System.Windows.Forms.PictureBox pb_CloseApp;
        private System.Windows.Forms.PictureBox pb_NextSong;
        private System.Windows.Forms.PictureBox pb_PrevSong;
        private System.Windows.Forms.PictureBox pb_LoadGrooves;
        private System.Windows.Forms.PictureBox pb_VolumeHover;
        private System.Windows.Forms.PictureBox pb_credits;
        private System.Windows.Forms.PictureBox pb_creditsPicture;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pb_shuffle;
        private System.Windows.Forms.PictureBox pb_shuffle_hover;
        public System.Windows.Forms.PictureBox pb_Pause;
        public System.Windows.Forms.PictureBox pb_Headphones_Playing;
        public System.Windows.Forms.PictureBox pb_PlayPause;
        public System.Windows.Forms.PictureBox pb_valvesPlaying;
    }
}


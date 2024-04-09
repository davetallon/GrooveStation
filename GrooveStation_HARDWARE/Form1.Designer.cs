namespace GrooveStation_HARDWARE
{
    partial class HardwareInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareInterface));
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.lb_FilePath = new System.Windows.Forms.ListBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label_Title2 = new System.Windows.Forms.Label();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Countdown = new System.Windows.Forms.Label();
            this.lb_IdleWarning = new System.Windows.Forms.Label();
            this.label_subTitle = new System.Windows.Forms.Label();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label_idleIndicator = new System.Windows.Forms.Label();
            this.label_quit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(33, 138);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(137, 78);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Browse Files";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(488, 138);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(137, 83);
            this.btn_Transfer.TabIndex = 1;
            this.btn_Transfer.Text = "Transfer to Device";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // lb_FilePath
            // 
            this.lb_FilePath.FormattingEnabled = true;
            this.lb_FilePath.Location = new System.Drawing.Point(189, 138);
            this.lb_FilePath.Name = "lb_FilePath";
            this.lb_FilePath.Size = new System.Drawing.Size(284, 238);
            this.lb_FilePath.TabIndex = 3;
            this.lb_FilePath.SelectedIndexChanged += new System.EventHandler(this.lb_FilePath_SelectedIndexChanged);
            // 
            // btn_Test
            // 
            this.btn_Test.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test.Location = new System.Drawing.Point(488, 227);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(137, 31);
            this.btn_Test.TabIndex = 5;
            this.btn_Test.Text = "Enable Test mode";
            this.btn_Test.UseVisualStyleBackColor = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.Location = new System.Drawing.Point(189, 390);
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.Size = new System.Drawing.Size(137, 36);
            this.btn_Shuffle.TabIndex = 6;
            this.btn_Shuffle.Text = "Shuffle List";
            this.btn_Shuffle.UseVisualStyleBackColor = true;
            this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(336, 390);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(137, 36);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear List";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label_Title2
            // 
            this.label_Title2.AutoSize = true;
            this.label_Title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title2.Location = new System.Drawing.Point(33, 55);
            this.label_Title2.Name = "label_Title2";
            this.label_Title2.Size = new System.Drawing.Size(597, 33);
            this.label_Title2.TabIndex = 8;
            this.label_Title2.Text = "GROOVE STATION DATA MIGRATION APP";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(33, 227);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(137, 36);
            this.btn_Preview.TabIndex = 9;
            this.btn_Preview.Text = "Preview Music";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Countdown
            // 
            this.lb_Countdown.AutoSize = true;
            this.lb_Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Countdown.Location = new System.Drawing.Point(121, 351);
            this.lb_Countdown.Name = "lb_Countdown";
            this.lb_Countdown.Size = new System.Drawing.Size(49, 20);
            this.lb_Countdown.TabIndex = 10;
            this.lb_Countdown.Text = "00:30";
            // 
            // lb_IdleWarning
            // 
            this.lb_IdleWarning.AutoSize = true;
            this.lb_IdleWarning.BackColor = System.Drawing.Color.Salmon;
            this.lb_IdleWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdleWarning.Location = new System.Drawing.Point(45, 390);
            this.lb_IdleWarning.Name = "lb_IdleWarning";
            this.lb_IdleWarning.Size = new System.Drawing.Size(125, 13);
            this.lb_IdleWarning.TabIndex = 11;
            this.lb_IdleWarning.Text = "The Device is now Idle...";
            this.lb_IdleWarning.Visible = false;
            // 
            // label_subTitle
            // 
            this.label_subTitle.AutoSize = true;
            this.label_subTitle.Location = new System.Drawing.Point(446, 113);
            this.label_subTitle.Name = "label_subTitle";
            this.label_subTitle.Size = new System.Drawing.Size(179, 13);
            this.label_subTitle.TabIndex = 12;
            this.label_subTitle.Text = "Dock with hardware device via USB";
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(131, 269);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(39, 35);
            this.Player.TabIndex = 13;
            // 
            // label_idleIndicator
            // 
            this.label_idleIndicator.AutoSize = true;
            this.label_idleIndicator.Location = new System.Drawing.Point(44, 351);
            this.label_idleIndicator.Name = "label_idleIndicator";
            this.label_idleIndicator.Size = new System.Drawing.Size(71, 13);
            this.label_idleIndicator.TabIndex = 14;
            this.label_idleIndicator.Text = "Idle Indicator:";
            // 
            // label_quit
            // 
            this.label_quit.AutoSize = true;
            this.label_quit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quit.ForeColor = System.Drawing.Color.Tomato;
            this.label_quit.Location = new System.Drawing.Point(598, 17);
            this.label_quit.Name = "label_quit";
            this.label_quit.Size = new System.Drawing.Size(29, 27);
            this.label_quit.TabIndex = 15;
            this.label_quit.Text = "X";
            this.label_quit.Click += new System.EventHandler(this.label_quit_Click);
            // 
            // HardwareInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 461);
            this.Controls.Add(this.label_quit);
            this.Controls.Add(this.label_idleIndicator);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.label_subTitle);
            this.Controls.Add(this.lb_IdleWarning);
            this.Controls.Add(this.lb_Countdown);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.label_Title2);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Shuffle);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.lb_FilePath);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.btn_Browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HardwareInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardwarePort Interface";
            this.Click += new System.EventHandler(this.HardwareInterface_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HardwareInterface_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HardwareInterface_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HardwareInterface_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.ListBox lb_FilePath;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Shuffle;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label_Title2;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Countdown;
        private System.Windows.Forms.Label lb_IdleWarning;
        private System.Windows.Forms.Label label_subTitle;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Label label_idleIndicator;
        private System.Windows.Forms.Label label_quit;
    }
}


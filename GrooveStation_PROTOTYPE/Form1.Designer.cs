namespace GrooveStation_PROTOTYPE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Load = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_Songs = new System.Windows.Forms.ListBox();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(655, 356);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(120, 84);
            this.btn_Load.TabIndex = 14;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 384);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(189, 45);
            this.trackBar1.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.progressBar1.Location = new System.Drawing.Point(30, 327);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(745, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // lb_Songs
            // 
            this.lb_Songs.FormattingEnabled = true;
            this.lb_Songs.Location = new System.Drawing.Point(480, 60);
            this.lb_Songs.Name = "lb_Songs";
            this.lb_Songs.Size = new System.Drawing.Size(295, 251);
            this.lb_Songs.TabIndex = 11;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(262, 387);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.TabIndex = 10;
            this.btn_Prev.Text = "Previous";
            this.btn_Prev.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(449, 387);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(355, 367);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 62);
            this.btn_Play.TabIndex = 8;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(731, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(44, 29);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(30, 279);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(233, 32);
            this.Player.TabIndex = 17;
            this.Player.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "GrooveStation Prototype";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_Songs);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lb_Songs;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Close;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}


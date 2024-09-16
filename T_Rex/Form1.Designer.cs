namespace T_Rex
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
            this.TRexPictureBox = new System.Windows.Forms.PictureBox();
            this.Obstacle1PictureBox = new System.Windows.Forms.PictureBox();
            this.Obstacle2PictureBox = new System.Windows.Forms.PictureBox();
            this.FloorPictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TRexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TRexPictureBox
            // 
            this.TRexPictureBox.Image = global::T_Rex.Properties.Resources.running;
            this.TRexPictureBox.Location = new System.Drawing.Point(97, 352);
            this.TRexPictureBox.Name = "TRexPictureBox";
            this.TRexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.TRexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TRexPictureBox.TabIndex = 0;
            this.TRexPictureBox.TabStop = false;
            this.TRexPictureBox.Click += new System.EventHandler(this.TRexPictureBox_Click);
            // 
            // Obstacle1PictureBox
            // 
            this.Obstacle1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Obstacle1PictureBox.Image")));
            this.Obstacle1PictureBox.Location = new System.Drawing.Point(346, 349);
            this.Obstacle1PictureBox.Name = "Obstacle1PictureBox";
            this.Obstacle1PictureBox.Size = new System.Drawing.Size(23, 46);
            this.Obstacle1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle1PictureBox.TabIndex = 1;
            this.Obstacle1PictureBox.TabStop = false;
            this.Obstacle1PictureBox.Tag = "obstacle";
            // 
            // Obstacle2PictureBox
            // 
            this.Obstacle2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Obstacle2PictureBox.Image")));
            this.Obstacle2PictureBox.Location = new System.Drawing.Point(556, 362);
            this.Obstacle2PictureBox.Name = "Obstacle2PictureBox";
            this.Obstacle2PictureBox.Size = new System.Drawing.Size(32, 33);
            this.Obstacle2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle2PictureBox.TabIndex = 2;
            this.Obstacle2PictureBox.TabStop = false;
            this.Obstacle2PictureBox.Tag = "obstacle";
            // 
            // FloorPictureBox
            // 
            this.FloorPictureBox.BackColor = System.Drawing.Color.Black;
            this.FloorPictureBox.Location = new System.Drawing.Point(-6, 401);
            this.FloorPictureBox.Name = "FloorPictureBox";
            this.FloorPictureBox.Size = new System.Drawing.Size(809, 55);
            this.FloorPictureBox.TabIndex = 3;
            this.FloorPictureBox.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(24, 37);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(56, 16);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 200;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.FloorPictureBox);
            this.Controls.Add(this.Obstacle2PictureBox);
            this.Controls.Add(this.Obstacle1PictureBox);
            this.Controls.Add(this.TRexPictureBox);
            this.Name = "Form1";
            this.Text = "T-Rex Runner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.TRexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TRexPictureBox;
        private System.Windows.Forms.PictureBox Obstacle1PictureBox;
        private System.Windows.Forms.PictureBox Obstacle2PictureBox;
        private System.Windows.Forms.PictureBox FloorPictureBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}


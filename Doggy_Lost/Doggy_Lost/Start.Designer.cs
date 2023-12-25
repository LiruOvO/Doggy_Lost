namespace Doggy_Lost
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.timerClouds = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.PictureBox();
            this.background1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.clouds1 = new System.Windows.Forms.PictureBox();
            this.clouds2 = new System.Windows.Forms.PictureBox();
            this.gameName = new System.Windows.Forms.PictureBox();
            this.timerGameName = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameName)).BeginInit();
            this.SuspendLayout();
            // 
            // timerClouds
            // 
            this.timerClouds.Interval = 50;
            this.timerClouds.Tick += new System.EventHandler(this.timerClouds_Tick);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Image = global::Doggy_Lost.Properties.Resources.StartButton1;
            this.startBtn.Location = new System.Drawing.Point(300, 328);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(200, 200);
            this.startBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startBtn.TabIndex = 2;
            this.startBtn.TabStop = false;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            this.startBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartBtn_MouseDown);
            this.startBtn.MouseEnter += new System.EventHandler(this.StartBtn_MouseEnter);
            this.startBtn.MouseLeave += new System.EventHandler(this.StartBtn_MouseLeave);
            // 
            // background1
            // 
            this.background1.Image = global::Doggy_Lost.Properties.Resources.StartBackground_NoBorders;
            this.background1.InitialImage = null;
            this.background1.Location = new System.Drawing.Point(8, 8);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(784, 584);
            this.background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background1.TabIndex = 0;
            this.background1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Image = global::Doggy_Lost.Properties.Resources.ExitBtn;
            this.exitBtn.Location = new System.Drawing.Point(733, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(55, 30);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            this.exitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // clouds1
            // 
            this.clouds1.BackColor = System.Drawing.Color.Transparent;
            this.clouds1.Image = global::Doggy_Lost.Properties.Resources.Clouds;
            this.clouds1.Location = new System.Drawing.Point(0, 22);
            this.clouds1.Name = "clouds1";
            this.clouds1.Size = new System.Drawing.Size(1290, 195);
            this.clouds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clouds1.TabIndex = 4;
            this.clouds1.TabStop = false;
            // 
            // clouds2
            // 
            this.clouds2.BackColor = System.Drawing.Color.Transparent;
            this.clouds2.Image = global::Doggy_Lost.Properties.Resources.Clouds;
            this.clouds2.Location = new System.Drawing.Point(1290, 22);
            this.clouds2.Name = "clouds2";
            this.clouds2.Size = new System.Drawing.Size(1290, 195);
            this.clouds2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clouds2.TabIndex = 5;
            this.clouds2.TabStop = false;
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gameName.Image = global::Doggy_Lost.Properties.Resources.GameName;
            this.gameName.Location = new System.Drawing.Point(8, 139);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(784, 115);
            this.gameName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameName.TabIndex = 6;
            this.gameName.TabStop = false;
            // 
            // timerGameName
            // 
            this.timerGameName.Interval = 350;
            this.timerGameName.Tick += new System.EventHandler(this.timerGameName_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.clouds2);
            this.Controls.Add(this.clouds1);
            this.Controls.Add(this.background1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerClouds;
        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.PictureBox startBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox clouds1;
        private System.Windows.Forms.PictureBox clouds2;
        private System.Windows.Forms.PictureBox gameName;
        private System.Windows.Forms.Timer timerGameName;
        private System.Windows.Forms.Timer timerClose;
    }
}


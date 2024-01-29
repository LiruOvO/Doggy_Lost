namespace Doggy_Lost
{
    partial class Park3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Park3));
            this.bg = new System.Windows.Forms.PictureBox();
            this.framePartUp = new System.Windows.Forms.PictureBox();
            this.framePartLeft = new System.Windows.Forms.PictureBox();
            this.framePartRight = new System.Windows.Forms.PictureBox();
            this.framePartDown = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.instruction = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.timerPlayer = new System.Windows.Forms.Timer(this.components);
            this.girl = new System.Windows.Forms.PictureBox();
            this.talkingImg = new System.Windows.Forms.PictureBox();
            this.talkingImgBtn = new System.Windows.Forms.PictureBox();
            this.talkingText = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImgBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg.Image = global::Doggy_Lost.Properties.Resources.ParkBG1;
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(800, 600);
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            // 
            // framePartUp
            // 
            this.framePartUp.Image = global::Doggy_Lost.Properties.Resources.FrameUp;
            this.framePartUp.Location = new System.Drawing.Point(0, 0);
            this.framePartUp.Name = "framePartUp";
            this.framePartUp.Size = new System.Drawing.Size(800, 8);
            this.framePartUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.framePartUp.TabIndex = 16;
            this.framePartUp.TabStop = false;
            // 
            // framePartLeft
            // 
            this.framePartLeft.Image = global::Doggy_Lost.Properties.Resources.FrameLeft;
            this.framePartLeft.Location = new System.Drawing.Point(0, 0);
            this.framePartLeft.Name = "framePartLeft";
            this.framePartLeft.Size = new System.Drawing.Size(8, 600);
            this.framePartLeft.TabIndex = 23;
            this.framePartLeft.TabStop = false;
            // 
            // framePartRight
            // 
            this.framePartRight.Image = global::Doggy_Lost.Properties.Resources.FrameRight;
            this.framePartRight.Location = new System.Drawing.Point(792, 0);
            this.framePartRight.Name = "framePartRight";
            this.framePartRight.Size = new System.Drawing.Size(8, 600);
            this.framePartRight.TabIndex = 24;
            this.framePartRight.TabStop = false;
            // 
            // framePartDown
            // 
            this.framePartDown.Image = global::Doggy_Lost.Properties.Resources.FrameDown;
            this.framePartDown.Location = new System.Drawing.Point(0, 592);
            this.framePartDown.Name = "framePartDown";
            this.framePartDown.Size = new System.Drawing.Size(800, 8);
            this.framePartDown.TabIndex = 25;
            this.framePartDown.TabStop = false;
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
            this.exitBtn.TabIndex = 26;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            this.exitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.BackColor = System.Drawing.Color.DarkSlateGray;
            this.instruction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.instruction.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.Color.MintCream;
            this.instruction.Location = new System.Drawing.Point(12, 12);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(160, 17);
            this.instruction.TabIndex = 27;
            this.instruction.Text = "Поговоріть з дівчинкою";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Doggy_Lost.Properties.Resources.Player_Right;
            this.player.Location = new System.Drawing.Point(119, 243);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(63, 87);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 28;
            this.player.TabStop = false;
            // 
            // timerPlayer
            // 
            this.timerPlayer.Interval = 70;
            this.timerPlayer.Tick += new System.EventHandler(this.timerPlayer_Tick);
            // 
            // girl
            // 
            this.girl.BackColor = System.Drawing.Color.Transparent;
            this.girl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girl.Location = new System.Drawing.Point(486, 111);
            this.girl.Name = "girl";
            this.girl.Size = new System.Drawing.Size(43, 99);
            this.girl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.girl.TabIndex = 29;
            this.girl.TabStop = false;
            this.girl.Click += new System.EventHandler(this.girl_Click);
            // 
            // talkingImg
            // 
            this.talkingImg.BackColor = System.Drawing.Color.Transparent;
            this.talkingImg.Image = global::Doggy_Lost.Properties.Resources.GirlTalk1;
            this.talkingImg.Location = new System.Drawing.Point(12, 161);
            this.talkingImg.Name = "talkingImg";
            this.talkingImg.Size = new System.Drawing.Size(776, 427);
            this.talkingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.talkingImg.TabIndex = 30;
            this.talkingImg.TabStop = false;
            // 
            // talkingImgBtn
            // 
            this.talkingImgBtn.BackColor = System.Drawing.Color.Transparent;
            this.talkingImgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.talkingImgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.talkingImgBtn.Location = new System.Drawing.Point(477, 443);
            this.talkingImgBtn.Name = "talkingImgBtn";
            this.talkingImgBtn.Size = new System.Drawing.Size(70, 46);
            this.talkingImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.talkingImgBtn.TabIndex = 31;
            this.talkingImgBtn.TabStop = false;
            this.talkingImgBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.talkingImgBtn_MouseDown);
            this.talkingImgBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.talkingImgBtn_MouseUp);
            // 
            // talkingText
            // 
            this.talkingText.AutoSize = true;
            this.talkingText.BackColor = System.Drawing.Color.Transparent;
            this.talkingText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.talkingText.ForeColor = System.Drawing.SystemColors.Control;
            this.talkingText.Location = new System.Drawing.Point(65, 282);
            this.talkingText.Name = "talkingText";
            this.talkingText.Size = new System.Drawing.Size(190, 21);
            this.talkingText.TabIndex = 32;
            this.talkingText.Text = "Чим можу допомогти?";
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // Park3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doggy_Lost.Properties.Resources.ParkBG;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.talkingText);
            this.Controls.Add(this.talkingImgBtn);
            this.Controls.Add(this.talkingImg);
            this.Controls.Add(this.girl);
            this.Controls.Add(this.player);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.framePartDown);
            this.Controls.Add(this.framePartRight);
            this.Controls.Add(this.framePartLeft);
            this.Controls.Add(this.framePartUp);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Park3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Park3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Park3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImgBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.PictureBox framePartUp;
        private System.Windows.Forms.PictureBox framePartLeft;
        private System.Windows.Forms.PictureBox framePartRight;
        private System.Windows.Forms.PictureBox framePartDown;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timerPlayer;
        private System.Windows.Forms.PictureBox girl;
        private System.Windows.Forms.PictureBox talkingImg;
        private System.Windows.Forms.PictureBox talkingImgBtn;
        private System.Windows.Forms.Label talkingText;
        private System.Windows.Forms.Timer timerClose;
    }
}
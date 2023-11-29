namespace Doggy_Lost
{
    partial class Forest1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forest1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.man = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.frame = new System.Windows.Forms.PictureBox();
            this.bg = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.instruction = new System.Windows.Forms.Label();
            this.talkingImg = new System.Windows.Forms.PictureBox();
            this.talkingImgBtn = new System.Windows.Forms.PictureBox();
            this.talkingText = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImgBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 70;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // man
            // 
            this.man.BackColor = System.Drawing.Color.Transparent;
            this.man.Cursor = System.Windows.Forms.Cursors.Hand;
            this.man.Location = new System.Drawing.Point(437, 241);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(43, 99);
            this.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.man.TabIndex = 3;
            this.man.TabStop = false;
            this.man.Click += new System.EventHandler(this.man_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Doggy_Lost.Properties.Resources.Player_Right;
            this.player.Location = new System.Drawing.Point(53, 282);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(63, 87);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Transparent;
            this.frame.BackgroundImage = global::Doggy_Lost.Properties.Resources.Frame;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(816, 600);
            this.frame.TabIndex = 2;
            this.frame.TabStop = false;
            // 
            // bg
            // 
            this.bg.Image = ((System.Drawing.Image)(resources.GetObject("bg.Image")));
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(800, 600);
            this.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg.TabIndex = 1;
            this.bg.TabStop = false;
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
            this.exitBtn.TabIndex = 4;
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
            this.instruction.Size = new System.Drawing.Size(374, 17);
            this.instruction.TabIndex = 5;
            this.instruction.Text = "Для пересування використовуйте WASD та/або стрілочки";
            // 
            // talkingImg
            // 
            this.talkingImg.BackColor = System.Drawing.Color.Transparent;
            this.talkingImg.Image = global::Doggy_Lost.Properties.Resources.ManTalk;
            this.talkingImg.Location = new System.Drawing.Point(12, 161);
            this.talkingImg.Name = "talkingImg";
            this.talkingImg.Size = new System.Drawing.Size(776, 427);
            this.talkingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.talkingImg.TabIndex = 6;
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
            this.talkingImgBtn.TabIndex = 7;
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
            this.talkingText.Size = new System.Drawing.Size(336, 21);
            this.talkingText.TabIndex = 8;
            this.talkingText.Text = "Добридень! Чим я можу вам допомогти?";
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // Forest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doggy_Lost.Properties.Resources.ForestBG1;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.talkingText);
            this.Controls.Add(this.talkingImgBtn);
            this.Controls.Add(this.talkingImg);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.player);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.man);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forest1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forest1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Forest1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkingImgBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox frame;
        private System.Windows.Forms.PictureBox man;
        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox talkingImg;
        private System.Windows.Forms.PictureBox talkingImgBtn;
        private System.Windows.Forms.Label talkingText;
        private System.Windows.Forms.Timer timerClose;
    }
}
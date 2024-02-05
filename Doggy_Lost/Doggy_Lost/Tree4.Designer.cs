namespace Doggy_Lost
{
    partial class Tree4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tree4));
            this.treeBG = new System.Windows.Forms.PictureBox();
            this.framePartDown = new System.Windows.Forms.PictureBox();
            this.framePartRight = new System.Windows.Forms.PictureBox();
            this.framePartLeft = new System.Windows.Forms.PictureBox();
            this.framePartUp = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.instruction = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.timerPlayer = new System.Windows.Forms.Timer(this.components);
            this.timerJump = new System.Windows.Forms.Timer(this.components);
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform5 = new System.Windows.Forms.PictureBox();
            this.platform0 = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.labelAgain = new System.Windows.Forms.PictureBox();
            this.labelRestart = new System.Windows.Forms.PictureBox();
            this.restartMenu = new System.Windows.Forms.PictureBox();
            this.doggy = new System.Windows.Forms.PictureBox();
            this.timerDog = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doggy)).BeginInit();
            this.SuspendLayout();
            // 
            // treeBG
            // 
            this.treeBG.BackgroundImage = global::Doggy_Lost.Properties.Resources.TreeBG;
            this.treeBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeBG.Location = new System.Drawing.Point(0, -600);
            this.treeBG.Name = "treeBG";
            this.treeBG.Size = new System.Drawing.Size(800, 1200);
            this.treeBG.TabIndex = 0;
            this.treeBG.TabStop = false;
            // 
            // framePartDown
            // 
            this.framePartDown.Image = global::Doggy_Lost.Properties.Resources.FrameDown;
            this.framePartDown.Location = new System.Drawing.Point(0, 592);
            this.framePartDown.Name = "framePartDown";
            this.framePartDown.Size = new System.Drawing.Size(800, 8);
            this.framePartDown.TabIndex = 29;
            this.framePartDown.TabStop = false;
            // 
            // framePartRight
            // 
            this.framePartRight.Image = global::Doggy_Lost.Properties.Resources.FrameRight;
            this.framePartRight.Location = new System.Drawing.Point(792, 0);
            this.framePartRight.Name = "framePartRight";
            this.framePartRight.Size = new System.Drawing.Size(8, 600);
            this.framePartRight.TabIndex = 28;
            this.framePartRight.TabStop = false;
            // 
            // framePartLeft
            // 
            this.framePartLeft.Image = global::Doggy_Lost.Properties.Resources.FrameLeft;
            this.framePartLeft.Location = new System.Drawing.Point(0, 0);
            this.framePartLeft.Name = "framePartLeft";
            this.framePartLeft.Size = new System.Drawing.Size(8, 600);
            this.framePartLeft.TabIndex = 27;
            this.framePartLeft.TabStop = false;
            // 
            // framePartUp
            // 
            this.framePartUp.Image = global::Doggy_Lost.Properties.Resources.FrameUp;
            this.framePartUp.Location = new System.Drawing.Point(0, 0);
            this.framePartUp.Name = "framePartUp";
            this.framePartUp.Size = new System.Drawing.Size(800, 8);
            this.framePartUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.framePartUp.TabIndex = 26;
            this.framePartUp.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Doggy_Lost.Properties.Resources.Player_Right;
            this.player.Location = new System.Drawing.Point(69, 1040);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 30;
            this.player.TabStop = false;
            this.player.Tag = "player";
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
            this.instruction.Size = new System.Drawing.Size(127, 17);
            this.instruction.TabIndex = 31;
            this.instruction.Text = "Залізьте на дерево";
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
            this.exitBtn.TabIndex = 32;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            this.exitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // timerPlayer
            // 
            this.timerPlayer.Interval = 70;
            this.timerPlayer.Tick += new System.EventHandler(this.timerPlayer_Tick);
            // 
            // timerJump
            // 
            this.timerJump.Enabled = true;
            this.timerJump.Interval = 1;
            this.timerJump.Tick += new System.EventHandler(this.timerJump_Tick);
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.Transparent;
            this.platform2.Location = new System.Drawing.Point(69, 708);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(177, 10);
            this.platform2.TabIndex = 34;
            this.platform2.TabStop = false;
            this.platform2.Tag = "platform";
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.Transparent;
            this.platform3.Location = new System.Drawing.Point(197, 502);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(205, 10);
            this.platform3.TabIndex = 35;
            this.platform3.TabStop = false;
            this.platform3.Tag = "platform";
            // 
            // platform4
            // 
            this.platform4.BackColor = System.Drawing.Color.Transparent;
            this.platform4.Location = new System.Drawing.Point(519, 502);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(205, 10);
            this.platform4.TabIndex = 36;
            this.platform4.TabStop = false;
            this.platform4.Tag = "platform";
            // 
            // platform5
            // 
            this.platform5.BackColor = System.Drawing.Color.Transparent;
            this.platform5.Location = new System.Drawing.Point(455, 320);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(150, 11);
            this.platform5.TabIndex = 37;
            this.platform5.TabStop = false;
            this.platform5.Tag = "platform";
            // 
            // platform0
            // 
            this.platform0.BackColor = System.Drawing.Color.Transparent;
            this.platform0.Location = new System.Drawing.Point(12, 1104);
            this.platform0.Name = "platform0";
            this.platform0.Size = new System.Drawing.Size(776, 34);
            this.platform0.TabIndex = 38;
            this.platform0.TabStop = false;
            this.platform0.Tag = "platform";
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.Transparent;
            this.platform1.Location = new System.Drawing.Point(278, 868);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(178, 10);
            this.platform1.TabIndex = 33;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // labelAgain
            // 
            this.labelAgain.BackColor = System.Drawing.Color.Transparent;
            this.labelAgain.BackgroundImage = global::Doggy_Lost.Properties.Resources.LabelAgain;
            this.labelAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.labelAgain.Location = new System.Drawing.Point(87, 23);
            this.labelAgain.Name = "labelAgain";
            this.labelAgain.Size = new System.Drawing.Size(637, 260);
            this.labelAgain.TabIndex = 39;
            this.labelAgain.TabStop = false;
            // 
            // labelRestart
            // 
            this.labelRestart.BackColor = System.Drawing.Color.Transparent;
            this.labelRestart.Image = global::Doggy_Lost.Properties.Resources.LabelRestart;
            this.labelRestart.Location = new System.Drawing.Point(197, 377);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(408, 83);
            this.labelRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelRestart.TabIndex = 40;
            this.labelRestart.TabStop = false;
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            this.labelRestart.MouseEnter += new System.EventHandler(this.labelRestart_MouseEnter);
            this.labelRestart.MouseLeave += new System.EventHandler(this.labelRestart_MouseLeave);
            // 
            // restartMenu
            // 
            this.restartMenu.BackgroundImage = global::Doggy_Lost.Properties.Resources.RestartMenu;
            this.restartMenu.Location = new System.Drawing.Point(0, 0);
            this.restartMenu.Name = "restartMenu";
            this.restartMenu.Size = new System.Drawing.Size(800, 600);
            this.restartMenu.TabIndex = 41;
            this.restartMenu.TabStop = false;
            // 
            // doggy
            // 
            this.doggy.BackColor = System.Drawing.Color.Transparent;
            this.doggy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doggy.Image = global::Doggy_Lost.Properties.Resources.Dog_TailLeft;
            this.doggy.Location = new System.Drawing.Point(540, 251);
            this.doggy.Name = "doggy";
            this.doggy.Size = new System.Drawing.Size(52, 63);
            this.doggy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doggy.TabIndex = 42;
            this.doggy.TabStop = false;
            this.doggy.Click += new System.EventHandler(this.doggy_Click);
            // 
            // timerDog
            // 
            this.timerDog.Enabled = true;
            this.timerDog.Interval = 500;
            this.timerDog.Tick += new System.EventHandler(this.timerDog_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // Tree4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doggy_Lost.Properties.Resources.TreeBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelAgain);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.restartMenu);
            this.Controls.Add(this.doggy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.platform0);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.framePartDown);
            this.Controls.Add(this.framePartRight);
            this.Controls.Add(this.framePartLeft);
            this.Controls.Add(this.framePartUp);
            this.Controls.Add(this.treeBG);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tree4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tree4_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tree4_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.treeBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doggy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox treeBG;
        private System.Windows.Forms.PictureBox framePartDown;
        private System.Windows.Forms.PictureBox framePartRight;
        private System.Windows.Forms.PictureBox framePartLeft;
        private System.Windows.Forms.PictureBox framePartUp;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Timer timerPlayer;
        private System.Windows.Forms.Timer timerJump;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox platform4;
        private System.Windows.Forms.PictureBox platform5;
        private System.Windows.Forms.PictureBox platform0;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox labelAgain;
        private System.Windows.Forms.PictureBox labelRestart;
        private System.Windows.Forms.PictureBox restartMenu;
        private System.Windows.Forms.PictureBox doggy;
        private System.Windows.Forms.Timer timerDog;
        private System.Windows.Forms.Timer timerClose;
    }
}
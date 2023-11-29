namespace Doggy_Lost
{
    partial class Road2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Road2));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.instruction = new System.Windows.Forms.Label();
            this.timerCarAccident = new System.Windows.Forms.Timer(this.components);
            this.doggy = new System.Windows.Forms.PictureBox();
            this.framePartRight = new System.Windows.Forms.PictureBox();
            this.framePartLeft = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car6 = new System.Windows.Forms.PictureBox();
            this.car5 = new System.Windows.Forms.PictureBox();
            this.framePartDown = new System.Windows.Forms.PictureBox();
            this.framePartUp = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car4 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.roadBG = new System.Windows.Forms.PictureBox();
            this.limit6 = new System.Windows.Forms.PictureBox();
            this.limit5 = new System.Windows.Forms.PictureBox();
            this.limit4 = new System.Windows.Forms.PictureBox();
            this.limit3 = new System.Windows.Forms.PictureBox();
            this.limit2 = new System.Windows.Forms.PictureBox();
            this.limit1 = new System.Windows.Forms.PictureBox();
            this.frame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.doggy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 70;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.instruction.Size = new System.Drawing.Size(159, 17);
            this.instruction.TabIndex = 7;
            this.instruction.Text = "Перейдіть через дорогу";
            // 
            // timerCarAccident
            // 
            this.timerCarAccident.Tick += new System.EventHandler(this.timerCarAccident_Tick);
            // 
            // doggy
            // 
            this.doggy.BackColor = System.Drawing.Color.Transparent;
            this.doggy.Image = global::Doggy_Lost.Properties.Resources.Dog_FrontSit;
            this.doggy.Location = new System.Drawing.Point(1129, 266);
            this.doggy.Name = "doggy";
            this.doggy.Size = new System.Drawing.Size(35, 44);
            this.doggy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doggy.TabIndex = 24;
            this.doggy.TabStop = false;
            this.doggy.Click += new System.EventHandler(this.doggy_Click);
            // 
            // framePartRight
            // 
            this.framePartRight.Image = global::Doggy_Lost.Properties.Resources.FrameRight;
            this.framePartRight.Location = new System.Drawing.Point(792, 0);
            this.framePartRight.Name = "framePartRight";
            this.framePartRight.Size = new System.Drawing.Size(8, 600);
            this.framePartRight.TabIndex = 23;
            this.framePartRight.TabStop = false;
            // 
            // framePartLeft
            // 
            this.framePartLeft.Image = global::Doggy_Lost.Properties.Resources.FrameLeft;
            this.framePartLeft.Location = new System.Drawing.Point(0, 0);
            this.framePartLeft.Name = "framePartLeft";
            this.framePartLeft.Size = new System.Drawing.Size(8, 600);
            this.framePartLeft.TabIndex = 22;
            this.framePartLeft.TabStop = false;
            // 
            // car3
            // 
            this.car3.BackColor = System.Drawing.Color.Transparent;
            this.car3.Image = global::Doggy_Lost.Properties.Resources.Car3Up;
            this.car3.Location = new System.Drawing.Point(970, 692);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(52, 92);
            this.car3.TabIndex = 21;
            this.car3.TabStop = false;
            this.car3.Tag = "car";
            // 
            // car6
            // 
            this.car6.BackColor = System.Drawing.Color.Transparent;
            this.car6.Image = global::Doggy_Lost.Properties.Resources.Car3Down;
            this.car6.Location = new System.Drawing.Point(914, -88);
            this.car6.Name = "car6";
            this.car6.Size = new System.Drawing.Size(52, 88);
            this.car6.TabIndex = 20;
            this.car6.TabStop = false;
            this.car6.Tag = "car";
            // 
            // car5
            // 
            this.car5.BackColor = System.Drawing.Color.Transparent;
            this.car5.Image = global::Doggy_Lost.Properties.Resources.Car2Down;
            this.car5.Location = new System.Drawing.Point(510, -120);
            this.car5.Name = "car5";
            this.car5.Size = new System.Drawing.Size(52, 99);
            this.car5.TabIndex = 19;
            this.car5.TabStop = false;
            this.car5.Tag = "car";
            // 
            // framePartDown
            // 
            this.framePartDown.Image = global::Doggy_Lost.Properties.Resources.FrameDown;
            this.framePartDown.Location = new System.Drawing.Point(0, 592);
            this.framePartDown.Name = "framePartDown";
            this.framePartDown.Size = new System.Drawing.Size(800, 8);
            this.framePartDown.TabIndex = 16;
            this.framePartDown.TabStop = false;
            // 
            // framePartUp
            // 
            this.framePartUp.Image = global::Doggy_Lost.Properties.Resources.FrameUp;
            this.framePartUp.Location = new System.Drawing.Point(0, 0);
            this.framePartUp.Name = "framePartUp";
            this.framePartUp.Size = new System.Drawing.Size(800, 8);
            this.framePartUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.framePartUp.TabIndex = 15;
            this.framePartUp.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::Doggy_Lost.Properties.Resources.Car1Up;
            this.car1.Location = new System.Drawing.Point(199, 710);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(52, 92);
            this.car1.TabIndex = 14;
            this.car1.TabStop = false;
            this.car1.Tag = "car";
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = global::Doggy_Lost.Properties.Resources.Car2Up;
            this.car2.Location = new System.Drawing.Point(569, 710);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(52, 110);
            this.car2.TabIndex = 17;
            this.car2.TabStop = false;
            this.car2.Tag = "car";
            // 
            // car4
            // 
            this.car4.BackColor = System.Drawing.Color.Transparent;
            this.car4.Image = global::Doggy_Lost.Properties.Resources.Car1Down;
            this.car4.Location = new System.Drawing.Point(140, -120);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(52, 91);
            this.car4.TabIndex = 18;
            this.car4.TabStop = false;
            this.car4.Tag = "car";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(12, 266);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(40, 70);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
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
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            this.exitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // roadBG
            // 
            this.roadBG.Image = global::Doggy_Lost.Properties.Resources.RoadBG;
            this.roadBG.Location = new System.Drawing.Point(0, 0);
            this.roadBG.Name = "roadBG";
            this.roadBG.Size = new System.Drawing.Size(1200, 600);
            this.roadBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadBG.TabIndex = 0;
            this.roadBG.TabStop = false;
            // 
            // limit6
            // 
            this.limit6.BackColor = System.Drawing.Color.Transparent;
            this.limit6.Location = new System.Drawing.Point(0, 0);
            this.limit6.Name = "limit6";
            this.limit6.Size = new System.Drawing.Size(129, 237);
            this.limit6.TabIndex = 13;
            this.limit6.TabStop = false;
            this.limit6.Tag = "limits";
            // 
            // limit5
            // 
            this.limit5.BackColor = System.Drawing.Color.Transparent;
            this.limit5.Location = new System.Drawing.Point(0, 0);
            this.limit5.Name = "limit5";
            this.limit5.Size = new System.Drawing.Size(164, 199);
            this.limit5.TabIndex = 12;
            this.limit5.TabStop = false;
            this.limit5.Tag = "limits";
            // 
            // limit4
            // 
            this.limit4.BackColor = System.Drawing.Color.Transparent;
            this.limit4.Location = new System.Drawing.Point(674, 422);
            this.limit4.Name = "limit4";
            this.limit4.Size = new System.Drawing.Size(184, 178);
            this.limit4.TabIndex = 11;
            this.limit4.TabStop = false;
            this.limit4.Tag = "limits";
            // 
            // limit3
            // 
            this.limit3.BackColor = System.Drawing.Color.Transparent;
            this.limit3.Location = new System.Drawing.Point(0, 0);
            this.limit3.Name = "limit3";
            this.limit3.Size = new System.Drawing.Size(184, 136);
            this.limit3.TabIndex = 10;
            this.limit3.TabStop = false;
            this.limit3.Tag = "limits";
            // 
            // limit2
            // 
            this.limit2.BackColor = System.Drawing.Color.Transparent;
            this.limit2.Location = new System.Drawing.Point(0, 0);
            this.limit2.Name = "limit2";
            this.limit2.Size = new System.Drawing.Size(100, 258);
            this.limit2.TabIndex = 9;
            this.limit2.TabStop = false;
            this.limit2.Tag = "limits";
            // 
            // limit1
            // 
            this.limit1.BackColor = System.Drawing.Color.Transparent;
            this.limit1.Location = new System.Drawing.Point(0, 0);
            this.limit1.Name = "limit1";
            this.limit1.Size = new System.Drawing.Size(100, 263);
            this.limit1.TabIndex = 8;
            this.limit1.TabStop = false;
            this.limit1.Tag = "limits";
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Transparent;
            this.frame.Image = global::Doggy_Lost.Properties.Resources.Frame;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(800, 600);
            this.frame.TabIndex = 1;
            this.frame.TabStop = false;
            // 
            // Road2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.doggy);
            this.Controls.Add(this.framePartRight);
            this.Controls.Add(this.framePartLeft);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car6);
            this.Controls.Add(this.car5);
            this.Controls.Add(this.framePartDown);
            this.Controls.Add(this.framePartUp);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.player);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.roadBG);
            this.Controls.Add(this.limit6);
            this.Controls.Add(this.limit5);
            this.Controls.Add(this.limit4);
            this.Controls.Add(this.limit3);
            this.Controls.Add(this.limit2);
            this.Controls.Add(this.limit1);
            this.Controls.Add(this.frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Road2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Road2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Road1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Road1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.doggy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framePartUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox roadBG;
        private System.Windows.Forms.PictureBox frame;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox limit1;
        private System.Windows.Forms.PictureBox limit2;
        private System.Windows.Forms.PictureBox limit3;
        private System.Windows.Forms.PictureBox limit4;
        private System.Windows.Forms.PictureBox limit5;
        private System.Windows.Forms.PictureBox limit6;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox framePartUp;
        private System.Windows.Forms.PictureBox framePartDown;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car4;
        private System.Windows.Forms.PictureBox car5;
        private System.Windows.Forms.PictureBox car6;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.Timer timerCarAccident;
        private System.Windows.Forms.PictureBox framePartLeft;
        private System.Windows.Forms.PictureBox framePartRight;
        private System.Windows.Forms.PictureBox doggy;
    }
}
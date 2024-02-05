namespace Doggy_Lost
{
    partial class TheEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheEnd));
            this.theEndBG = new System.Windows.Forms.PictureBox();
            this.timerDog = new System.Windows.Forms.Timer(this.components);
            this.doggy = new System.Windows.Forms.PictureBox();
            this.endPB = new System.Windows.Forms.PictureBox();
            this.restartPB = new System.Windows.Forms.PictureBox();
            this.exitPB = new System.Windows.Forms.PictureBox();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.theEndBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doggy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).BeginInit();
            this.SuspendLayout();
            // 
            // theEndBG
            // 
            this.theEndBG.Image = global::Doggy_Lost.Properties.Resources.EndBg;
            this.theEndBG.Location = new System.Drawing.Point(0, 0);
            this.theEndBG.Name = "theEndBG";
            this.theEndBG.Size = new System.Drawing.Size(800, 600);
            this.theEndBG.TabIndex = 0;
            this.theEndBG.TabStop = false;
            // 
            // timerDog
            // 
            this.timerDog.Enabled = true;
            this.timerDog.Interval = 500;
            this.timerDog.Tick += new System.EventHandler(this.timerDog_Tick);
            // 
            // doggy
            // 
            this.doggy.BackColor = System.Drawing.Color.Transparent;
            this.doggy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.doggy.Location = new System.Drawing.Point(382, 307);
            this.doggy.Name = "doggy";
            this.doggy.Size = new System.Drawing.Size(208, 140);
            this.doggy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doggy.TabIndex = 43;
            this.doggy.TabStop = false;
            // 
            // endPB
            // 
            this.endPB.BackColor = System.Drawing.Color.Transparent;
            this.endPB.Image = global::Doggy_Lost.Properties.Resources.TheEnd;
            this.endPB.Location = new System.Drawing.Point(165, 25);
            this.endPB.Name = "endPB";
            this.endPB.Size = new System.Drawing.Size(470, 105);
            this.endPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.endPB.TabIndex = 44;
            this.endPB.TabStop = false;
            // 
            // restartPB
            // 
            this.restartPB.BackColor = System.Drawing.Color.Transparent;
            this.restartPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restartPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartPB.Image = global::Doggy_Lost.Properties.Resources.LabelRestart;
            this.restartPB.Location = new System.Drawing.Point(31, 473);
            this.restartPB.Name = "restartPB";
            this.restartPB.Size = new System.Drawing.Size(396, 78);
            this.restartPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restartPB.TabIndex = 45;
            this.restartPB.TabStop = false;
            this.restartPB.Click += new System.EventHandler(this.restartPB_Click);
            this.restartPB.MouseEnter += new System.EventHandler(this.restartPB_MouseEnter);
            this.restartPB.MouseLeave += new System.EventHandler(this.restartPB_MouseLeave);
            // 
            // exitPB
            // 
            this.exitPB.BackColor = System.Drawing.Color.Transparent;
            this.exitPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPB.Image = global::Doggy_Lost.Properties.Resources.LabelExitBtn;
            this.exitPB.Location = new System.Drawing.Point(488, 473);
            this.exitPB.Name = "exitPB";
            this.exitPB.Size = new System.Drawing.Size(265, 78);
            this.exitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPB.TabIndex = 46;
            this.exitPB.TabStop = false;
            this.exitPB.Click += new System.EventHandler(this.exitPB_Click);
            this.exitPB.MouseEnter += new System.EventHandler(this.exitPB_MouseEnter);
            this.exitPB.MouseLeave += new System.EventHandler(this.exitPB_MouseLeave);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            // 
            // TheEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doggy_Lost.Properties.Resources.EndBg;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.exitPB);
            this.Controls.Add(this.restartPB);
            this.Controls.Add(this.endPB);
            this.Controls.Add(this.doggy);
            this.Controls.Add(this.theEndBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheEnd";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TheEnd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.theEndBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doggy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox theEndBG;
        private System.Windows.Forms.Timer timerDog;
        private System.Windows.Forms.PictureBox doggy;
        private System.Windows.Forms.PictureBox endPB;
        private System.Windows.Forms.PictureBox restartPB;
        private System.Windows.Forms.PictureBox exitPB;
        private System.Windows.Forms.Timer timerClose;
    }
}
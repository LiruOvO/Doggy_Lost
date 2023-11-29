namespace Doggy_Lost
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.frame = new System.Windows.Forms.PictureBox();
            this.introBG = new System.Windows.Forms.PictureBox();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.instruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introBG)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Transparent;
            this.frame.Image = global::Doggy_Lost.Properties.Resources.Frame;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(800, 600);
            this.frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame.TabIndex = 1;
            this.frame.TabStop = false;
            // 
            // introBG
            // 
            this.introBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.introBG.Image = global::Doggy_Lost.Properties.Resources.Intro;
            this.introBG.Location = new System.Drawing.Point(0, 0);
            this.introBG.Name = "introBG";
            this.introBG.Size = new System.Drawing.Size(802, 1600);
            this.introBG.TabIndex = 0;
            this.introBG.TabStop = false;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.BackColor = System.Drawing.Color.Transparent;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instruction.ForeColor = System.Drawing.Color.Gainsboro;
            this.instruction.Location = new System.Drawing.Point(644, 31);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(143, 26);
            this.instruction.TabIndex = 2;
            this.instruction.Text = "Space - пришвидшення\r\nEnter - пропуск";
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.introBG);
            this.Controls.Add(this.frame);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Introduction_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Introduction_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox introBG;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox frame;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Label instruction;
    }
}
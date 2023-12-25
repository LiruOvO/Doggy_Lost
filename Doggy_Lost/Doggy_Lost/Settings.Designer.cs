namespace Doggy_Lost
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.settingsMenu = new System.Windows.Forms.PictureBox();
            this.labelSettings = new System.Windows.Forms.PictureBox();
            this.labelReset = new System.Windows.Forms.PictureBox();
            this.labelExit = new System.Windows.Forms.PictureBox();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.settingsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelExit)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsMenu
            // 
            this.settingsMenu.BackColor = System.Drawing.Color.Transparent;
            this.settingsMenu.Image = global::Doggy_Lost.Properties.Resources.SettingsMenu;
            this.settingsMenu.Location = new System.Drawing.Point(100, 75);
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(600, 450);
            this.settingsMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsMenu.TabIndex = 10;
            this.settingsMenu.TabStop = false;
            // 
            // labelSettings
            // 
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Image = global::Doggy_Lost.Properties.Resources.LabelSettings;
            this.labelSettings.Location = new System.Drawing.Point(81, 26);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(438, 91);
            this.labelSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelSettings.TabIndex = 13;
            this.labelSettings.TabStop = false;
            // 
            // labelReset
            // 
            this.labelReset.BackColor = System.Drawing.Color.Transparent;
            this.labelReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReset.Image = global::Doggy_Lost.Properties.Resources.LabelReset;
            this.labelReset.Location = new System.Drawing.Point(145, 238);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(310, 69);
            this.labelReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelReset.TabIndex = 14;
            this.labelReset.TabStop = false;
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            this.labelReset.MouseEnter += new System.EventHandler(this.labelReset_MouseEnter);
            this.labelReset.MouseLeave += new System.EventHandler(this.labelReset_MouseLeave);
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Image = global::Doggy_Lost.Properties.Resources.LabelExitBtn;
            this.labelExit.Location = new System.Drawing.Point(210, 330);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(180, 50);
            this.labelExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelExit.TabIndex = 15;
            this.labelExit.TabStop = false;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.LabelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 50;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doggy_Lost.Properties.Resources.StartBackground_Blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.settingsMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.settingsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox settingsMenu;
        private System.Windows.Forms.PictureBox labelSettings;
        private System.Windows.Forms.PictureBox labelReset;
        private System.Windows.Forms.PictureBox labelExit;
        private System.Windows.Forms.Timer timerClose;
    }
}
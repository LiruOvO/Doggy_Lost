namespace Doggy_Lost
{
    partial class ExitMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitMenuForm));
            this.exitMenu = new System.Windows.Forms.PictureBox();
            this.labelExit = new System.Windows.Forms.PictureBox();
            this.labelYes = new System.Windows.Forms.PictureBox();
            this.labelNo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelNo)).BeginInit();
            this.SuspendLayout();
            // 
            // exitMenu
            // 
            this.exitMenu.BackColor = System.Drawing.Color.Transparent;
            this.exitMenu.Image = global::Doggy_Lost.Properties.Resources.ExitMenu;
            this.exitMenu.Location = new System.Drawing.Point(100, 75);
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(600, 450);
            this.exitMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitMenu.TabIndex = 9;
            this.exitMenu.TabStop = false;
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Image = global::Doggy_Lost.Properties.Resources.LabelExit;
            this.labelExit.Location = new System.Drawing.Point(55, 65);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(497, 100);
            this.labelExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelExit.TabIndex = 12;
            this.labelExit.TabStop = false;
            // 
            // labelYes
            // 
            this.labelYes.BackColor = System.Drawing.Color.Transparent;
            this.labelYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelYes.Image = global::Doggy_Lost.Properties.Resources.LabelYes;
            this.labelYes.Location = new System.Drawing.Point(75, 285);
            this.labelYes.Name = "labelYes";
            this.labelYes.Size = new System.Drawing.Size(188, 60);
            this.labelYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelYes.TabIndex = 13;
            this.labelYes.TabStop = false;
            this.labelYes.Click += new System.EventHandler(this.LabelYes_Click);
            this.labelYes.MouseEnter += new System.EventHandler(this.LabelYes_MouseEnter);
            this.labelYes.MouseLeave += new System.EventHandler(this.LabelYes_MouseLeave);
            // 
            // labelNo
            // 
            this.labelNo.BackColor = System.Drawing.Color.Transparent;
            this.labelNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNo.Image = global::Doggy_Lost.Properties.Resources.LabelNo;
            this.labelNo.Location = new System.Drawing.Point(335, 285);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(190, 60);
            this.labelNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelNo.TabIndex = 14;
            this.labelNo.TabStop = false;
            this.labelNo.Click += new System.EventHandler(this.LabelNo_Click);
            this.labelNo.MouseEnter += new System.EventHandler(this.LabelNo_MouseEnter);
            this.labelNo.MouseLeave += new System.EventHandler(this.LabelNo_MouseLeave);
            // 
            // ExitMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::Doggy_Lost.Properties.Resources.StartBackground_Blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labelYes);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.exitMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExitMenuForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.exitMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitMenu;
        private System.Windows.Forms.PictureBox labelExit;
        private System.Windows.Forms.PictureBox labelYes;
        private System.Windows.Forms.PictureBox labelNo;
    }
}
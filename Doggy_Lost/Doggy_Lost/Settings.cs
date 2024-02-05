using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doggy_Lost
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";

            labelSettings.Parent = settingsMenu;
            labelReset.Parent = settingsMenu;
            labelExit.Parent = settingsMenu;            
        }        



        //Анімація кнопок
        private void LabelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.Image = Properties.Resources.LabelExitBtn_Hover;
        }
        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.Image = Properties.Resources.LabelExitBtn;
        }        
        private void labelExit_Click(object sender, EventArgs e)
        {
            ExitMenuForm exit = new ExitMenuForm();
            exit.Show();
            timerClose.Start();
        }

        private void labelReset_MouseEnter(object sender, EventArgs e)
        {
            labelReset.Image = Properties.Resources.LabelReset_Hover;
        }
        private void labelReset_MouseLeave(object sender, EventArgs e)
        {
            labelReset.Image = Properties.Resources.LabelReset;
        }
        private void labelReset_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Saving.txt", "Doggy_Lost.Start");            
            HideAllForms();            
        }
        //Початок гри спочатку
        private void HideAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            Start start = new Start();
            start.Show();
        }

        //Плавний перехід між формами
        public int i = 1;
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (i < 2) i++; else this.Hide();
        }
    }
}

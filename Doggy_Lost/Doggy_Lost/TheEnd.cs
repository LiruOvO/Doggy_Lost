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
    public partial class TheEnd : Form
    {
        public byte o;
        public TheEnd()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";

            //Збереження прогресу
            File.WriteAllText("Saving.txt", "Doggy_Lost.TheEnd");
        }

        private void TheEnd_KeyDown(object sender, KeyEventArgs e)
        {
            //Меню виходу
            if (e.KeyCode == Keys.Escape)
            {
                Settings set = new Settings();
                set.Show();
            }
        }

        private void timerDog_Tick(object sender, EventArgs e)
        {
            if (o == 0)
            {
                doggy.Image = Properties.Resources.Dog_TailRight;
                o = 1;
            }
            else if (o == 1)
            {
                doggy.Image = Properties.Resources.Dog_TailLeft;
                o = 0;
            }
        }

        private void restartPB_MouseEnter(object sender, EventArgs e)
        {
            restartPB.Image = Properties.Resources.LabelRestart_Hover;
        }

        private void restartPB_MouseLeave(object sender, EventArgs e)
        {
            restartPB.Image = Properties.Resources.LabelRestart;
        }
        private void restartPB_Click(object sender, EventArgs e)
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



        private void exitPB_MouseEnter(object sender, EventArgs e)
        {
            exitPB.Image = Properties.Resources.LabelExitBtn_Hover;
        }
        private void exitPB_MouseLeave(object sender, EventArgs e)
        {
            exitPB.Image = Properties.Resources.LabelExitBtn;
        }
        private void exitPB_Click(object sender, EventArgs e)
        {
            ExitMenuForm exit = new ExitMenuForm();
            exit.Show();
            timerClose.Start();
        }


        //Плавний перехід між формами
        public int i = 1;
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (i < 2) i++; else this.Hide();
        }
    }
}

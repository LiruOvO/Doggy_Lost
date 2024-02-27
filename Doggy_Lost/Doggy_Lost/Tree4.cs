using Doggy_Lost.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doggy_Lost
{
    public partial class Tree4 : Form
    {
        public byte o;
        public Tree4()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";

            exitBtn.Parent = treeBG;
            exitBtn.Top = 612;
            timerPlayer.Start();

            player.Parent = treeBG; doggy.Parent = treeBG; platform1.Parent = treeBG; platform2.Parent = treeBG;
            platform0.Parent = treeBG; platform3.Parent = treeBG; platform4.Parent = treeBG; platform5.Parent = treeBG;

            doggy.BringToFront();

            labelAgain.Hide(); labelRestart.Hide(); restartMenu.Hide();
            labelAgain.Parent = restartMenu; labelRestart.Parent = restartMenu;

            //Збереження прогресу
            File.WriteAllText("Saving.txt", "Doggy_Lost.Tree4");
        }




        //Пересування гравця та його анімація
        private PlayerAnimation playerAnimation = new PlayerAnimation();
        bool goLeft = false, goRight = false, jump = false; int i = 0;
        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            //гравець
            if (goLeft == true && player.Left > 10) playerAnimation.MoveLeft(player);
            if (goRight == true && player.Left + (player.Width + 10) < this.ClientSize.Width) playerAnimation.MoveRight(player);
          
        }
        private void Tree4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) goLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) goRight = true;
            if (e.KeyCode == Keys.Space) jump = true;
            //Меню налаштувань
            if (e.KeyCode == Keys.Escape)
            {
                Settings set = new Settings();
                set.Show();
            }
        }
        private void Tree4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { goLeft = false; player.Image = Properties.Resources.Player_Left; }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { goRight = false; player.Image = Properties.Resources.Player_Right; }
        }
         



        //Прижок гравця
        private void timerJump_Tick(object sender, EventArgs e)
        {
            if (jump == false)//гравітація
            {
                player.Top += 2;
                foreach (Control x in treeBG.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            player.Top = treeBG.PointToClient(x.Parent.PointToScreen(x.Location)).Y - player.Height;
                        }
                    }
                }
            }
            if (jump == true)//сам прижок
            {
                if (i < 28)//вверх
                {
                    player.Top -= 7;
                    if (treeBG.Top < 0) 
                    {
                        treeBG.Top += 7;
                        exitBtn.Top -= 7;
                    }
                    i++;
                }
                else if (i > 27 && i < 56)//вниз
                {
                    foreach (Control x in treeBG.Controls)
                    {
                        if (x is PictureBox && (string)x.Tag == "platform")
                        {
                            if (player.Bounds.IntersectsWith(x.Bounds))
                            {
                                player.Top = treeBG.PointToClient(x.Parent.PointToScreen(x.Location)).Y - player.Height;
                                jump = false;
                                i = 0;
                            }
                        }
                    }
                    player.Top += 7;
                    if (treeBG.Top < 0) 
                    {
                        treeBG.Top -= 7;
                        exitBtn.Top += 7;
                    }
                    i++;
                }
                else if (i == 56)
                {
                    jump = false;
                    i = 0;
                }
            }
            if (!this.ClientRectangle.Contains(this.PointToClient(player.Parent.PointToScreen(player.Location))))
            {
                labelAgain.Show(); labelRestart.Show(); restartMenu.Show();
                timerJump.Stop();
            }

            if (player.Bounds.IntersectsWith(doggy.Bounds))
            {
                timerJump.Stop(); timerPlayer.Stop();
                instruction.Text = "Погладьте песика";
            }
        }



        //Нажаття на песика
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
        private void doggy_Click(object sender, EventArgs e)
        {
            TheEnd end = new TheEnd();
            end.Show();
            timerClose.Start();
        }




        //Плавний перехід між формами
        public int a = 1;
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (a < 2) a++; else this.Hide();
        }




        //Кнопка Виходу
        private void exitBtn_Click(object sender, EventArgs e)
        {
            ExitMenuForm exit = new ExitMenuForm();
            exit.Show();
        }
        private void ExitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            exitBtn.Image = Properties.Resources.ExitBtn_Click;
        }
        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.Image = Properties.Resources.ExitBtn;
        }
        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.Image = Properties.Resources.ExitBtn_Hover;
        }




        //Рестарт
        private void labelRestart_Click(object sender, EventArgs e)
        {
            exitBtn.Top = 612;
            restartMenu.Hide(); labelAgain.Hide(); labelRestart.Hide(); 
            treeBG.Top = -600; 
            timerJump.Start();
            player.Location = new Point(69, 1040);
        }
        private void labelRestart_MouseLeave(object sender, EventArgs e)
        {
            labelRestart.Image = Properties.Resources.LabelRestart;
        }
        private void labelRestart_MouseEnter(object sender, EventArgs e)
        {
            labelRestart.Image = Properties.Resources.LabelRestart_Hover;
        }
    } 
}
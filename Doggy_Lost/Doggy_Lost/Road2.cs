using Doggy_Lost.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace Doggy_Lost
{
    public partial class Road2 : Form
    {
        public Road2()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";
            frame.Parent = roadBG;
            exitBtn.Parent = frame;
            player.Parent = frame;
            car1.Parent = frame; car2.Parent = frame; car3.Parent = frame; car4.Parent = frame; car5.Parent = frame; car6.Parent = frame;

            /////////////////////////////
            doggy.Parent = frame;

            timer.Start();
            timerCarAccident.Start();
            //Збереження прогресу
            File.WriteAllText("Saving.txt", "Doggy_Lost.Road2");
            
        }



        //
        //ТРЕБА ЗНАЙТИ СПОСІБ ДЛЯ ЗУПИНКИ ГРАВЦЯ ПРИ ДОТОРКАННІ ДО ЛІМІТІВ
        //





        //Пересування фону, гравця та його анімація, рух машинок
        private PlayerAnimation playerAnimation = new PlayerAnimation();
        bool goLeft = false, goRight = false, goUp = false, goDown = false;
        int backgroundSpeed = 4; int q, w, ee, r, t, y;        

        bool img = false;
        private void timer_Tick(object sender, EventArgs e)
        {//гравець
            if (goLeft == true && player.Left > 10) playerAnimation.MoveLeft(player);
            if (goRight == true && player.Left + (player.Width + 10) < this.ClientSize.Width) playerAnimation.MoveRight(player);            
            if (goUp == true && player.Top >10) playerAnimation.MoveUp(player);
            if (goDown == true && player.Top + (player.Height + 12) < this.ClientSize.Height) playerAnimation.MoveDown(player);
            //фон та машинки
            if (goLeft == true && roadBG.Left < 0)
            {
                roadBG.Left += backgroundSpeed;
                frame.Left -= backgroundSpeed;
                /////////////////////////////
                doggy.Left += backgroundSpeed;

                car1.Left += backgroundSpeed; car2.Left += backgroundSpeed; car3.Left += backgroundSpeed; car4.Left += backgroundSpeed; car5.Left += backgroundSpeed; car6.Left += backgroundSpeed;
            }
            if(goRight ==true && roadBG.Left > -400)
            {
                roadBG.Left -= backgroundSpeed;
                frame.Left += backgroundSpeed;
                /////////////////////////////
                doggy.Left -= backgroundSpeed;

                car1.Left -= backgroundSpeed; car2.Left -= backgroundSpeed; car3.Left -= backgroundSpeed; car4.Left -= backgroundSpeed; car5.Left -= backgroundSpeed; car6.Left -= backgroundSpeed;
            }

            //Рух машинок
            car1.Top -= 12; car2.Top -= 15; car3.Top -= 12;
            car4.Top += 16; car5.Top += 13; car6.Top += 17;
            if (car1.Top < -92) { q++; if (q == 10) { car1.Top = 692; q = 0; if (img) { car1.Image = Properties.Resources.Car3Up; img = false; } else { car1.Image = Properties.Resources.Car1Up; img = true; } } }
            if (car2.Top < -110) { w++; if (w == 10) { car2.Top = 710; w = 0; if (img) { car2.Image = Properties.Resources.Car1Up; img = false; } else { car2.Image = Properties.Resources.Car2Up; img = true; } } }
            if (car3.Top < -92) { ee++; if (ee == 10) { car3.Top = 692; ee = 0; if (img) { car3.Image = Properties.Resources.Car1Up; img = false; } else { car3.Image = Properties.Resources.Car3Up; img = true; } } }

            if (car4.Top > 691) { r++; if (r == 10) { car4.Top = -91; r = 0; if (!img) { car4.Image = Properties.Resources.Car3Down; img = false; } else { car4.Image = Properties.Resources.Car1Down; img = true; } } }
            if (car5.Top > 699) { t++; if (t == 10) { car5.Top = -99; t = 0; if (!img) { car5.Image = Properties.Resources.Car1Down; img = false; } else { car5.Image = Properties.Resources.Car2Down; img = true; } } }
            if (car6.Top > 688) { y++; if (y == 10) { car6.Top = -88; y = 0; if (!img) { car6.Image = Properties.Resources.Car1Down; img = false; } else { car6.Image = Properties.Resources.Car3Down; img = true; } } }

            
        }
        /////////////////////////////////////////////////////
        private void doggy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ви пройшли гру");
            this.Close();
        }

        int sleep = 0;



        //Врізання гравця в машику та запуск спочатку
        private void timerCarAccident_Tick(object sender, EventArgs e)
        {
            if (player.Bounds.IntersectsWith(car1.Bounds) || player.Bounds.IntersectsWith(car2.Bounds) || player.Bounds.IntersectsWith(car3.Bounds) ||
                player.Bounds.IntersectsWith(car4.Bounds) || player.Bounds.IntersectsWith(car5.Bounds) || player.Bounds.IntersectsWith(car6.Bounds))
            {
                if (sleep < 10) 
                { 
                    timer.Stop();
                    player.Image = Properties.Resources.Player_Dead;
                    sleep++;
                }
                else
                {
                    timer.Start();
                    player.Image = Properties.Resources.Player_Right;
                    player.Left = 12; roadBG.Left = 0; frame.Left = 0;
                    car1.Left = 199; car2.Left = 569; car3.Left = 970; car4.Left = 140; car5.Left = 510; car6.Left = 914;
                    sleep = 0;
                }                
            }
        }



        //Натискання кнопок
        private void Road1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) goLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) goRight = true;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) goUp = true;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) goDown = true;
            
            //Меню виходу
            if (e.KeyCode == Keys.Escape)
            {
                ExitMenuForm form2 = new ExitMenuForm();
                form2.Show();
            }
        }
        private void Road1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { goLeft = false; player.Image = Properties.Resources.Player_Left; }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { goRight = false; player.Image = Properties.Resources.Player_Right; }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) { goUp = false; player.Image = Properties.Resources.Player_Back; }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) { goDown = false; player.Image = Properties.Resources.Player_Front; }
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
    }
}

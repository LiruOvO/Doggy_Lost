using Doggy_Lost.Resources;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Doggy_Lost
{
    public partial class Park3 : Form
    {
        public Park3()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";

            timerPlayer.Start();

            girl.Parent = bg;
            talkingImg.Hide(); talkingImgBtn.Hide(); talkingText.Hide();
            File.WriteAllText("Saving.txt", "Doggy_Lost.Park3");
        }



        //Пересування персонажу та анімація
        private PlayerAnimation playerAnimation = new PlayerAnimation();
        bool goLeft = false, goRight = false, goUp = false, goDown = false;
        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            if (goLeft == true && player.Left > 96) playerAnimation.MoveLeft(player);
            if (goRight == true && player.Left < 725) playerAnimation.MoveRight(player);
            if (goUp == true && player.Top > 151) playerAnimation.MoveUp(player);
            if (goDown == true && player.Top < 276) playerAnimation.MoveDown(player);
        }
        private void Park3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) goLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) goRight = true;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) goUp = true;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) goDown = true;
            if (player.Left > 720 && instruction.Text == "Ідіть до кінця парку")
            {
                Road2 roadTeleport = new Road2();
                roadTeleport.Show();
                timerClose.Start();
            }
            //Меню виходу
            if (e.KeyCode == Keys.Escape)
            {
                Settings set = new Settings();
                set.Show();
            }
        }
        private void Park3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { goLeft = false; player.Image = Properties.Resources.Player_Left; }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { goRight = false; player.Image = Properties.Resources.Player_Right; }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) { goUp = false; player.Image = Properties.Resources.Player_Back; }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) { goDown = false; player.Image = Properties.Resources.Player_Front; }
        }



        //Розмова з дівчинкою
        private void girl_Click(object sender, EventArgs e)
        {
            girl.Hide(); player.Hide();
            instruction.Hide();
            //Розташування елементів
            talkingImg.Show(); talkingImgBtn.Show(); talkingText.Show();
            talkingImgBtn.Parent = talkingImg; talkingText.Parent = talkingImg;
            talkingImgBtn.Location = new Point(466, 282); talkingText.Location = new Point(60, 120);
        }
        public int num = 0;
        private void talkingImgBtn_MouseDown(object sender, MouseEventArgs e)
        {
            talkingImgBtn.Image = Properties.Resources.BtnTalk;
            if (num == 0) { talkingText.Text = "Добрий день! Я шукаю свого песика\nкоричневого кольору. \n\nВи, часом, не бачили його?"; talkingImg.Image = Properties.Resources.YouTalk; num++; }
            else if (num == 1) { talkingText.Text = "Хмм... Точно! Він побіг далі та поліз на пагорб."; talkingImg.Image = Properties.Resources.GirlTalk; num++; }
            else if (num == 2) { talkingText.Text = "Велике вам дякую!"; talkingImg.Image = Properties.Resources.YouTalk; num++; }
            else if (num == 3) { talkingText.Text = "Навзаєм :)"; talkingImg.Image = Properties.Resources.GirlTalk; num++; }
            else if (num == 4) { talkingImg.Hide(); talkingImgBtn.Hide(); talkingText.Hide(); girl.Show(); player.Show(); instruction.Show(); instruction.Text = "Ідіть до кінця парку"; num++; }
            if (num == 5) { talkingText.Text = "Я можу ще чимось допомогти?"; talkingImg.Image = Properties.Resources.GirlTalk; num++; }
            else if (num == 6) { talkingText.Text = "Дякую вам, гарного дня!"; talkingImg.Image = Properties.Resources.YouTalk; num = 4; }
        }
        private void talkingImgBtn_MouseUp(object sender, MouseEventArgs e)
        {
            talkingImgBtn.Image = null;
        }



        //Плавний перехід між формами
        public int i = 1;
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (i < 2) i++; else this.Hide();
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

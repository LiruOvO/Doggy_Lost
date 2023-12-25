using Doggy_Lost.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;
//Початок гри, розмова з чоловіком
namespace Doggy_Lost
{
    public partial class Forest1 : Form
    {        
        public Forest1()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";

            frame.Parent = bg;
            man.Parent = frame;
            talkingImg.Hide();talkingImgBtn.Hide();talkingText.Hide();
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



        //Пересування персонажу та анімація
        private PlayerAnimation playerAnimation = new PlayerAnimation();
        bool goLeft = false, goRight = false, goUp = false, goDown = false;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (goLeft == true && player.Left > 14) playerAnimation.MoveLeft(player);
            if (goRight == true && player.Left < 725) playerAnimation.MoveRight(player);
            if (goUp == true && player.Top > 260) playerAnimation.MoveUp(player);
            if (goDown == true && player.Top < 310) playerAnimation.MoveDown(player);
                    
        }
        public bool text = true;
        private void Forest1_KeyDown(object sender, KeyEventArgs e)
        {
            if (text) { instruction.Text = "Підійдіть до чоловіка та поговоріть з ним"; text = false; }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) goLeft = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) goRight = true;
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) goUp = true;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) goDown = true;
            if (player.Left > 720 && instruction.Text == "Ідіть до кінця дороги")
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

            timer.Start();
        }
        private void Forest1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) { goLeft = false; player.Image = Properties.Resources.Player_Left; }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { goRight = false; player.Image = Properties.Resources.Player_Right; }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) { goUp = false; player.Image = Properties.Resources.Player_Back; }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) { goDown = false; player.Image = Properties.Resources.Player_Front; }
        }



        //Плавний перехід між формами
        public int i = 1;
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (i < 2) i++; else this.Hide();
        }



        //Взаємодія з перехожим
        private void man_Click(object sender, EventArgs e)
        {
            man.Parent = this;
            man.BringToFront();
            instruction.Hide(); man.Hide();
            //Розташування елементів
            talkingImg.Show(); talkingImgBtn.Show(); talkingText.Show();
            talkingImgBtn.Parent = talkingImg; talkingText.Parent = talkingImg;
            talkingImgBtn.Location = new Point(466,282); talkingText.Location = new Point(60,120);
            UpdateDisplayOrder();
        }        
        public int num = 0;
        //Розмова з перехожим
        private void talkingImgBtn_MouseDown(object sender, MouseEventArgs e)
        {
            talkingImgBtn.Image = Properties.Resources.BtnTalk;
            if (num == 0) { talkingText.Text = "Добридень! Ви часом не бачили песика \nкоричневого кольору з блакитним нашийником?\n\nВін, наче, побіг у цю сторону ;("; talkingImg.Image = Properties.Resources.YouTalk; num++; }
            else if (num == 1) { talkingText.Text = "О, так, бачив такого. Він побіг далі в сторону шосе."; talkingImg.Image = Properties.Resources.ManTalk; num++; }
            else if (num == 2) { talkingText.Text = "Дякую вам, гарного дня!"; talkingImg.Image = Properties.Resources.YouTalk; num++; }
            else if (num == 3) { talkingText.Text = "І тобі також, хай щастить, хлопче!"; talkingImg.Image = Properties.Resources.ManTalk; num++; }
            else if (num == 4) { talkingImg.Hide(); talkingImgBtn.Hide(); talkingText.Hide(); man.Show(); instruction.Show(); instruction.Text = "Ідіть до кінця дороги"; num++; }
            if (num == 5) { talkingText.Text = "Я можу ще чимось допомогти?"; talkingImg.Image = Properties.Resources.ManTalk; num++; }
            else if (num == 6) { talkingText.Text = "Дякую вам, гарного дня!"; talkingImg.Image = Properties.Resources.YouTalk; num=4; }
        }
        private void talkingImgBtn_MouseUp(object sender, MouseEventArgs e)
        {
            talkingImgBtn.Image = null;
            if (num == 6) UpdateDisplayOrder();
        }
        private void UpdateDisplayOrder()//Зберігає порядок відображення елементів, щоб man був під player
        {
            man.BringToFront();
            player.BringToFront();
            talkingImg.BringToFront();
            talkingImgBtn.BringToFront();
            talkingText.BringToFront();
        }
       
    }
}


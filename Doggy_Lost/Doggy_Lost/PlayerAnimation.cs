using System.Windows.Forms;
//Анімація та пересування ігрока
namespace Doggy_Lost.Resources
{
    internal class PlayerAnimation
    {
        public int frame = 0;
        public void MoveRight(PictureBox player)
        {
            if (frame == 0 || frame == 1 )
            {
                player.Image = Properties.Resources.Player_Right1;
                player.Left += 6;
                frame++;
            }
            else if (frame == 2 || frame == 3 )
            {
                player.Image = Properties.Resources.Player_Right;
                player.Left += 6;
                frame++;
            }
            else if (frame == 4 || frame == 5 )
            {
                player.Image = Properties.Resources.Player_Right2;
                player.Left += 6;
                frame++;
            }
            else if (frame == 6 || frame == 7)
            {
                player.Image = Properties.Resources.Player_Right;
                player.Left += 6;
                if (frame == 6 ) frame++; else frame = 0;
            }
        }


        public void MoveLeft(PictureBox player)
        {
            if (frame == 0 || frame == 1)
            {
                player.Image = Properties.Resources.Player_Left1;
                player.Left -= 6;
                frame++;
            }
            else if (frame == 2 || frame == 3)
            {
                player.Image = Properties.Resources.Player_Left;
                player.Left -= 6;
                frame++;
            }
            else if (frame == 4 || frame == 5)
            {
                player.Image = Properties.Resources.Player_Left2;
                player.Left -= 6;
                frame++;
            }
            else if (frame == 6 || frame == 7)
            {
                player.Image = Properties.Resources.Player_Left;
                player.Left -= 6;
                if (frame == 6) frame++; else frame = 0;
            }
        }


        public void MoveUp(PictureBox player)
        {
            if (frame == 0 || frame == 1)
            {
                player.Image = Properties.Resources.Player_Back1;
                player.Top -= 6;
                frame++;
            }
            else if (frame == 2 || frame == 3)
            {
                player.Image = Properties.Resources.Player_Back;
                player.Top -= 6;
                frame++;
            }
            else if (frame == 4 || frame == 5)
            {
                player.Image = Properties.Resources.Player_Back2;
                player.Top -= 6;
                frame++;
            }
            else if (frame == 6 || frame == 7)
            {
                player.Image = Properties.Resources.Player_Back;
                player.Top -= 6;
                if (frame == 6) frame++; else frame = 0;
            }
        }


        public void MoveDown(PictureBox player)
        {
            if (frame == 0 || frame == 1)
            {
                player.Image = Properties.Resources.Player_Front1;
                player.Top += 6;
                frame++;
            }
            else if (frame == 2 || frame == 3)
            {
                player.Image = Properties.Resources.Player_Front;
                player.Top += 6;
                frame++;
            }
            else if (frame == 4 || frame == 5)
            {
                player.Image = Properties.Resources.Player_Front2;
                player.Top += 6;
                frame++;
            }
            else if (frame == 6 || frame == 7)
            {
                player.Image = Properties.Resources.Player_Front;
                player.Top += 6;
                if (frame == 6) frame++; else frame = 0;
            }
        }
    }
}

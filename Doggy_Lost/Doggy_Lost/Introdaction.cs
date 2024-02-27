using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
//Форма розповіді історії
namespace Doggy_Lost
{
    public partial class Introduction : Form
    {
        Forest1 forest1 = new Forest1();
        public Introduction()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";
            instruction.Parent = introBG;
            frame.Parent = introBG;
            timer.Start();


            File.WriteAllText("Saving.txt", "Doggy_Lost.Introduction");
        }



        //Сповзання вікна
        public int o = 1, i = 1, speed = 1;
        private void timer_Tick(object sender, EventArgs e)
        {            
            if (o<150) { o++; } //Затримка перед запуском таймеру
            else {
                introBG.Top -= speed;
                frame.Top += speed;
                instruction.Hide();
            }
            if (introBG.Top == -1000)
            {
                Thread.Sleep(3000);                                
                forest1.Show();                
                timerClose.Start();
            }
        }



        //Плавний перехід між формами
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (i < 2) i++; else this.Hide();
        }



        //Space - пришвидшення сповзання вікна
        //Enter - пропуск інтро, перехід на наступну форму
        //Escape - відкриття форми виходу зі гри
        private void Introduction_KeyDown(object sender, KeyEventArgs e)
        {
            if (introBG.Top < -1000)
            {
                timer.Stop();
                Thread.Sleep(3000);
                forest1.Show();
                timerClose.Start();
            }
            if (e.KeyCode == Keys.Space) speed = 4;
            if (e.KeyCode == Keys.Enter) {
                forest1.Show();
                //Збереження прогресу
                File.WriteAllText("Saving.txt", "Doggy_Lost.Forest1");
                timerClose.Start();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Settings set = new Settings();
                set.Show();
            }
        }
        private void Introduction_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) speed = 1;
        }
    }
}

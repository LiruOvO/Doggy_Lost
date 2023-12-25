using System;
using System.IO;
using System.Windows.Forms;
//Форма старту гри
namespace Doggy_Lost
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";
            timerClouds.Start();
            timerGameName.Start();

            clouds1.Parent = background1;
            clouds2.Parent = background1;

            //Збереження прогресу(Вікна на якому ви зупинились при останньому виході з гри)
            File.WriteAllText("Saving.txt", "Doggy_Lost.Start");
        }



        //Кнопка Старту
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Introduction intro = new Introduction();
            intro.Show();
            timerClose.Start();
        }
        private void StartBtn_MouseEnter(object sender, EventArgs e)
        {
            startBtn.Image = Properties.Resources.StartButton_Hover;
        }
        private void StartBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.Image = Properties.Resources.StartButton1;
        }
        private void StartBtn_MouseDown(object sender, MouseEventArgs e)
        {
            startBtn.Image = Properties.Resources.StartButton_Click;
        }



        //Кнопка Виходу
        private void ExitBtn_Click(object sender, EventArgs e)
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
        
       


        //Анімація Хмар
        private void timerClouds_Tick(object sender, EventArgs e)
        {
            int speed = 1;
            clouds1.Left -= speed;
            clouds2.Left -= speed;           

            if (clouds1.Left < -1290)
                clouds1.Left = 1290;
            if (clouds2.Left < -1290)
                clouds2.Left = 1290;
        }



        //Анімація назви гри
        private bool isImage1 = true;
        private void timerGameName_Tick(object sender, EventArgs e)
        {
            if (isImage1)
            {
                gameName.Image = Properties.Resources.GameName1; 
            }
            else
            {
                gameName.Image = Properties.Resources.GameName; 
            }
            isImage1 = !isImage1;
        }



        //Плавне відкриття вікна
        public int i = 1;
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (i < 2) i++; else this.Hide();
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Settings set = new Settings();
                set.Show();
            }
        }
    }    
}

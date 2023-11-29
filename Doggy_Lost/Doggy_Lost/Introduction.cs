using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//Форма розповіді історії
namespace Doggy_Lost
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";
            timer.Start();
        }        

        //Зповзання вікна
        public int o = 1;
        private void timer_Tick(object sender, EventArgs e)
        {            
            if (o<90) { o++; } //Затримка перед запуском таймеру
            else {
                int speed = 1;
                IntroBG.Top -= speed;
            }            
        }
    }
}

using System;
using System.Windows.Forms;
//Форма підтвердження виходу з гри
namespace Doggy_Lost
{
    public partial class ExitMenuForm : Form
    {
        public ExitMenuForm()
        {
            InitializeComponent();
            this.Text = "Doggy_Lost";

            labelExit.Parent = exitMenu;
            labelYes.Parent = exitMenu;
            labelNo.Parent = exitMenu;
        }


        //Кнопки виходу з гри та вихід з меню виходу
        private void LabelYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LabelNo_Click(object sender, EventArgs e)
        {
            this.Hide();                   
        }


        //Анімація кнопок
        private void LabelYes_MouseEnter(object sender, EventArgs e)
        {
            labelYes.Image = Properties.Resources.LabelYes_Hover;
        }
        private void LabelYes_MouseLeave(object sender, EventArgs e)
        {
            labelYes.Image = Properties.Resources.LabelYes;
        }
        private void LabelYes_MouseDown(object sender, MouseEventArgs e)
        {
            labelYes.Image = Properties.Resources.LabelYes_Click;
        }
        private void LabelNo_MouseEnter(object sender, EventArgs e)
        {
            labelNo.Image = Properties.Resources.LabelNo_Hover;
        }
        private void LabelNo_MouseLeave(object sender, EventArgs e)
        {
            labelNo.Image = Properties.Resources.LabelNo;
        }
        private void LabelNo_MouseDown(object sender, MouseEventArgs e)
        {
            labelNo.Image = Properties.Resources.LabelNo_Click;
        }
    }
}

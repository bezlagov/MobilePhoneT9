using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhoneT9.Controller;


namespace MobilePhoneT9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            TimerController.Instance.StartMainTimer();
        }
        private void OnOneButtonClick(object sender, EventArgs e)
        {
            txtScreen.Text = DataController.Data().MainScreenText += "1";
        }

        private void OnDeleteButtonClick(object sender, EventArgs e)
        {
            txtScreen.Text = MobileFunctions.Instance.DeleteSymbol();
        }

        private void OnChangeLenguageClick(object sender, EventArgs e)
        {
            label2.Text = View.Show.SetLengText(MobileFunctions.Instance.LenguageChanger());
        }

        private void On2KeyDown(object sender, MouseEventArgs e)
        {
            TimerController.Instance.StartButtonTimer();
        }

        private void On2KeyUp(object sender, MouseEventArgs e)
        {
            if (TimerController.Instance.GetCurrentTimerValue() >= 4)
            {
                MessageBox.Show("Число " + TimerController.Instance.GetCurrentTimerValue().ToString());
            }
            else if (TimerController.Instance.GetCurrentTimerValue() <= 1)
            {
                MessageBox.Show("Следующая на кнопке " + TimerController.Instance.GetCurrentTimerValue().ToString());
            }
            else
            {

                MessageBox.Show("Тот же символ " + TimerController.Instance.GetCurrentTimerValue().ToString());
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            TimerController.Instance.StopMainTimer();
        }
    }
}

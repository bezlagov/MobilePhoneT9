using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhoneT9.Model;
using MobilePhoneT9.Controller;


namespace MobilePhoneT9
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void OnOneButtonClick(object sender, EventArgs e)
        {
            txtScreen.Text = TelephoneData.Instance.MainScreenText += "1";
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
            TelephoneData.Instance.CurrentTimer = 0;
            TelephoneData.Instance.timer.Start();
            TelephoneData.Instance.timer.Interval = 100;
            TelephoneData.Instance.timer.Tick += SetCur;
        }

        private void SetCur(object sender, EventArgs e)
        {
            TelephoneData.Instance.CurrentTimer += 0.1;
        }

        private void On2KeyUp(object sender, MouseEventArgs e)
        {
            if (TelephoneData.Instance.timer.Interval > 3000)
            {
                TelephoneData.Instance.timer.Stop();
                MessageBox.Show(TelephoneData.Instance.CurrentTimer.ToString());
            }
            MessageBox.Show(TelephoneData.Instance.CurrentTimer.ToString());

        }
    }
}

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
        private string tNineString;
        private double _tempTimerValue = 0;
        private bool _isFirsTuch = true;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            TimerController.Instance.StartMainTimer();
            DatabaseProvider.Instance.LoadData();
            tNineString = "";
            //ThreadingController.Instance.StartTimerX();
        }

        private void OnDeleteButtonClick(object sender, EventArgs e)
        {
            txtScreen.Text = MobileFunctions.Instance.DeleteSymbol();
            if (tNineString.Length > 0)
                tNineString = tNineString.Remove(tNineString.Length - 1, 1);
            lblT9.Text = MobileFunctions.Instance.SudgestWords(tNineString);
        }

        private void OnChangeLenguageClick(object sender, EventArgs e)
        {
            label2.Text = View.Show.SetLengText(MobileFunctions.Instance.LenguageChanger());
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            TimerController.Instance.StopMainTimer();
        }

        private void ButtonClickProcessor(int value)
        {
            if (TimerController.Instance.GetCurrentTimerValue() >= 3)
            {
                txtScreen.Text = DataController.Data().MainScreenText += value;
            }
            else if (TimerController.Instance.GetCurrentTimerValue() <= 1)
            {
                if (_tempTimerValue + 2 >= TimerController.Instance.GetMainTimerValue())
                {
                    if (_isFirsTuch)
                    {
                        txtScreen.Text = DataController.Data().MainScreenText += ButtonController.GetSymbol(value);
                        T9Control(ButtonController.GetSymbol(value));
                        lblT9.Text = MobileFunctions.Instance.SudgestWords(tNineString);
                        ButtonController.IncrementValue(value);
                        _isFirsTuch = false;
                        _tempTimerValue = TimerController.Instance.GetMainTimerValue();
                        return;
                    }
                    else
                    {
                        _isFirsTuch = false;
                        txtScreen.Text = MobileFunctions.Instance.DeleteSymbol();
                        txtScreen.Text = DataController.Data().MainScreenText += ButtonController.GetSymbol(value);
                        T9Control(ButtonController.GetSymbol(value));
                        lblT9.Text = MobileFunctions.Instance.SudgestWords(tNineString);
                        ButtonController.IncrementValue(value);
                        _tempTimerValue = TimerController.Instance.GetMainTimerValue();
                        return;
                    }
                }
                else
                {
                    _isFirsTuch = true;
                    ButtonController.ClearValue();
                    txtScreen.Text = DataController.Data().MainScreenText += ButtonController.GetSymbol(value);
                    T9Control(ButtonController.GetSymbol(value));
                    lblT9.Text = MobileFunctions.Instance.SudgestWords(tNineString);
                    _tempTimerValue = TimerController.Instance.GetMainTimerValue();
                    return;
                }
            }
        }
        #region ButtonBehaviour
        private void On2KeyDown(object sender, MouseEventArgs e)
        {
            TimerController.Instance.StartButtonTimer();
        }

        private void On2KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.TWO_BUTTON);
        }

        private void On3KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.THREE_BUTTON);
        }
        private void On4KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.FOUR_BUTTON);
        }

        private void On5KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.FIVE_BUTTON);
        }

        private void On6KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.SIX_BUTTON);
        }

        private void On7KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.SEVEN_BUTTON);
        }

        private void On8KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.EIGHT_BUTTON);
        }

        private void On9KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.NINE_BUTTON);
        }

        private void On0KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.ZERO_BUTTON);
        }
        private void On1KeyUp(object sender, MouseEventArgs e)
        {
            ButtonClickProcessor((int)Buttons.ONE_BUTTON);
        }

        private void OnCaseChange(object sender, EventArgs e)
        {
            lblCase.Text = View.Show.SetCase(MobileFunctions.Instance.CaseChange());
        }
        #endregion
        private void T9Control(string value)
        {
            if (value == " ") tNineString = "";
            else tNineString += value;
            //for (int i = DataController.Data().MainScreenText.Length; i < 0; i--)
            //{
            //    if (DataController.Data().MainScreenText[i].ToString()==" ")
            //    {
            //        tNineString=DataController.Data().MainScreenText.Substring(i);
            //    }
            //}
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            while (DataController.Data().MainScreenText.Length == 0)
            {
                if (DataController.Data().MainScreenText.EndsWith(" ")) break;
                DataController.Data().MainScreenText=DataController.Data().MainScreenText.Remove(DataController.Data().MainScreenText.Length - 1, 1);
            }
            DataController.Data().MainScreenText += lblT9.Text;
            lblT9.Text = "";
            txtScreen.Text = DataController.Data().MainScreenText;
            T9Control(" ");
        }

        private void OnUpClick(object sender, EventArgs e)
        {
            lblCase.Text = tNineString;
        }
    }
}

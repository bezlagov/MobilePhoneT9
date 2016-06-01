using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneT9.Model;

namespace MobilePhoneT9.Controller
{
    public static class ButtonController
    {
        public static string SecondButtonPressed(int value)
        {
            return TelephoneData.Instance.GetSecondButtonValue(value);
        }
        public static int ButtonCurrentValue(int button)
        {
            return TelephoneData.Instance.GetTimesPressed(button);
        }
        public static string GetSymbol(int button)
        {
            switch (button)
            {
                case 0:
                    return TelephoneData.Instance.GetzeroButtonValue(TelephoneData.Instance.ButtonZero);
                case 1:
                    return TelephoneData.Instance.GetFirstButtonValue(TelephoneData.Instance.ButtonOne);
                case 2:
                    return TelephoneData.Instance.GetSecondButtonValue(TelephoneData.Instance.ButtonTwo);
                case 3:
                    return TelephoneData.Instance.GetThirdButtonValue(TelephoneData.Instance.ButtonThree);
                case 4:
                    return TelephoneData.Instance.GetFourthButtonValue(TelephoneData.Instance.ButtonFour);
                case 5:
                    return TelephoneData.Instance.GetFifthButtonValue(TelephoneData.Instance.ButtonFive);
                case 6:
                    return TelephoneData.Instance.GetSixButtonValue(TelephoneData.Instance.ButtonSix);
                case 7:
                    return TelephoneData.Instance.GetSeventhButtonValue(TelephoneData.Instance.ButtonSeven);
                case 8:
                    return TelephoneData.Instance.GetEightButtonValue(TelephoneData.Instance.ButtonEight);
                case 9:
                    return TelephoneData.Instance.GetNineButtonValue(TelephoneData.Instance.ButtonNine);
            }
            return "";
        }

        public static void IncrementValue(int button)
        {
            TelephoneData.Instance.ButtonIncrementer(button);
        }
        public static void ClearValue()
        {
            TelephoneData.Instance.ButtonClearValue();
        }
    }
}

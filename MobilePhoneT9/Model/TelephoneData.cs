using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MobilePhoneT9.Model
{
    public class TelephoneData
    {
        public string MainScreenText { get; set; } = "";
        public bool isRusSeted { get; set; } = true;
        public int ButtonOne { get; set; } = 0;
        public int ButtonTwo { get; set; } = 0;
        public int ButtonThree { get; set; } = 0;
        public int ButtonFour { get; set; } = 0;
        public int ButtonFive { get; set; } = 0;
        public int ButtonSix { get; set; } = 0;
        public int ButtonSeven { get; set; } = 0;
        public int ButtonEight { get; set; } = 0;
        public int ButtonNine { get; set; } = 0;
        public int ButtonZero { get; set; } = 0;
        public int ButtonSharp { get; set; } = 0;
        public int ButtonMultiply { get; set; } = 0;
        private static TelephoneData _instance;
        public static TelephoneData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TelephoneData();
                return _instance;
            }
        }
        private TelephoneData()
        {
        }

        public string GetSecondButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return "а";
                    case 1:
                        return "б";
                    case 2:
                        return "в";
                    case 3:
                        return "г";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return "a";
                    case 1:
                        return "b";
                    case 2:
                        return "c";
                }
            }
            return "";
        }
        public string GetThirdButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return "д";
                    case 1:
                        return "е";
                    case 2:
                        return "ж";
                    case 3:
                        return "з";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return "d";
                    case 1:
                        return "e";
                    case 2:
                        return "f";
                }
            }
            return "";
        }
        public string GetFourthButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return "и";
                    case 1:
                        return "й";
                    case 2:
                        return "к";
                    case 3:
                        return "л";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return "g";
                    case 1:
                        return "h";
                    case 2:
                        return "i";
                }
            }
            return "";
        }
        public string GetFifthButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return "м";
                    case 1:
                        return "н";
                    case 2:
                        return "о";
                    case 3:
                        return "п";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return "j";
                    case 1:
                        return "k";
                    case 2:
                        return "l";
                }
            }
            return "";
        }
        public string GetSixButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return "р";
                    case 1:
                        return "с";
                    case 2:
                        return "т";
                    case 3:
                        return "у";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return "m";
                    case 1:
                        return "n";
                    case 2:
                        return "u";
                }
            }
            return "";
        }
        public string GetSeventhButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return "ф";
                    case 1:
                        return "х";
                    case 2:
                        return "ц";
                    case 3:
                        return "ч";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:

                        return "p";
                    case 1:
                        return "q";
                    case 2:
                        return "r";
                    case 3:
                        return "s";


                }
            }
            return "";
        }
        public int GetTimesPressed(int button)
        {
            switch (button)
            {
                case 0:
                    return ButtonOne;
                case 1:
                    return ButtonTwo;
                case 2:
                    return ButtonThree;
                case 3:
                    return ButtonFour;
                case 4:
                    return ButtonFive;
                case 5:
                    return ButtonSix;
                case 6:
                    return ButtonSeven;
                case 7:
                    return ButtonEight;
                case 8:
                    return ButtonNine;
                case 9:
                    return ButtonZero;
                case 10:
                    return ButtonMultiply;
                case 11:
                    return ButtonSharp;
            }
            return 0;
        }

        public void ButtonIncrementer(int button)
        {
            switch (button)
            {
                case 0:
                    ButtonOne++;
                    if (ButtonOne > 3) ButtonOne = 0;
                    break;
                case 1:
                    ButtonTwo++;
                    if (ButtonTwo > 3) ButtonTwo = 0;
                    break;
                case 2:
                    ButtonThree++;
                    if (ButtonThree > 3) ButtonThree = 0;
                    break;
                case 3:
                    ButtonFour++;
                    if (ButtonFour > 3) ButtonFour = 0;
                    break;
                case 4:
                    ButtonFive++;
                    if (ButtonFive > 3) ButtonFive = 0;
                    break;
                case 5:
                    ButtonSix++;
                    if (ButtonSix > 3) ButtonSix = 0;
                    break;
                case 6:
                    ButtonSeven++;
                    if (ButtonSeven > 3) ButtonSeven = 0;
                    break;
                case 7:
                    ButtonEight++;
                    if (ButtonEight > 3) ButtonEight = 0;
                    break;
                case 8:
                    ButtonNine++;
                    if (ButtonNine > 3) ButtonNine = 0;
                    break;
                case 9:
                    ButtonZero++;
                    if (ButtonZero > 2) ButtonZero = 0;
                    break;
                case 10:
                    ButtonMultiply++;
                    if (ButtonMultiply > 2) ButtonMultiply = 0;
                    break;
                case 11:
                    ButtonSharp++;
                    if (ButtonSharp > 2) ButtonSharp = 0;
                    break;
            }
        }
    }
}
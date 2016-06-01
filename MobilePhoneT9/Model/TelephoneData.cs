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
        public bool IsLowerCase { get; set; } = true;
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
        public string GetFirstButtonValue(int value)
        {

            switch (value)
            {
                case 0:
                    return "1";
                case 1:
                    return " ";
            }
            return "";
        }
        public string GetSecondButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return IsLowerCase?"а":"А";
                    case 1:
                        return IsLowerCase ? "б":"Б";
                    case 2:
                        return IsLowerCase ? "в":"В";
                    case 3:
                        return IsLowerCase ? "г":"Г";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return IsLowerCase ? "a":"A";
                    case 1:
                        return IsLowerCase ? "b":"B";
                    case 2:
                        return IsLowerCase ? "c":"C";
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
                        return IsLowerCase ? "д" : "Д";
                    case 1:
                        return IsLowerCase ? "е" : "Е";
                    case 2:
                        return IsLowerCase ? "ж" : "Ж";
                    case 3:
                        return IsLowerCase ? "з" : "З";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return IsLowerCase ? "d" : "D";
                    case 1:
                        return IsLowerCase ? "e" : "E";
                    case 2:
                        return IsLowerCase ? "f" : "F";
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
                        return IsLowerCase ? "и" : "И";
                    case 1:
                        return IsLowerCase ? "й" : "Й";
                    case 2:
                        return IsLowerCase ? "к" : "К";
                    case 3:
                        return IsLowerCase ? "л" : "Л";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return IsLowerCase ? "g" : "G";
                    case 1:
                        return IsLowerCase ? "h" : "H";
                    case 2:
                        return IsLowerCase ? "i" : "I";
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
                        return IsLowerCase ? "м" : "М";
                    case 1:
                        return IsLowerCase ? "н" : "Н";
                    case 2:
                        return IsLowerCase ? "о" : "О";
                    case 3:
                        return IsLowerCase ? "п" : "П";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return IsLowerCase ? "j" : "J";
                    case 1:
                        return IsLowerCase ? "k" : "K";
                    case 2:
                        return IsLowerCase ? "l" : "L";
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
                        return IsLowerCase ? "р" : "Р";
                    case 1:
                        return IsLowerCase ? "с" : "С";
                    case 2:
                        return IsLowerCase ? "т" : "Т";
                    case 3:
                        return IsLowerCase ? "у" : "У";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return IsLowerCase ? "m" : "M";
                    case 1:
                        return IsLowerCase ? "n" : "N";
                    case 2:
                        return IsLowerCase ? "o" : "O";
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
                        return IsLowerCase ? "ф" : "Ф";
                    case 1:
                        return IsLowerCase ? "х" : "Х";
                    case 2:
                        return IsLowerCase ? "ц" : "Ц";
                    case 3:
                        return IsLowerCase ? "ч" : "Ч";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                    case 3:
                        return IsLowerCase ? "p" : "P";
                    case 1:
                        return IsLowerCase ? "q" : "Q";
                    case 2:
                        return IsLowerCase ? "r" : "R";
                }
            }
            return "";
        }
        public string GetEightButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return IsLowerCase ? "ш" : "Ш";
                    case 1:
                        return IsLowerCase ? "щ" : "Щ";
                    case 2:
                        return IsLowerCase ? "ъ" : "Ъ";
                    case 3:
                        return IsLowerCase ? "ы" : "Ы";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                        return IsLowerCase ? "s" : "S";
                    case 1:
                        return IsLowerCase ? "t" : "T";
                    case 2:
                        return IsLowerCase ? "u" : "U";
                    case 3:
                        return IsLowerCase ? "v" : "V";
                }
            }
            return "";
        }
        public string GetNineButtonValue(int value)
        {
            if (isRusSeted)
            {
                switch (value)
                {
                    case 0:
                        return IsLowerCase ? "ь" : "Ь";
                    case 1:
                        return IsLowerCase ? "э" : "Э";
                    case 2:
                        return IsLowerCase ? "ю" : "Ю";
                    case 3:
                        return IsLowerCase ? "я" : "Я";
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                        return IsLowerCase ? "w" : "W";
                    case 1:
                        return IsLowerCase ? "x" : "X";
                    case 2:
                        return IsLowerCase ? "y" : "Y";
                    case 3:
                        return IsLowerCase ? "z":"Z";
                }
            }
            return "";
        }
        public string GetzeroButtonValue(int value)
        {

            switch (value)
            {
                case 0:
                    return "0";
                case 1:
                    return "+";
            }
            return "";
        }
        public string GetMultiplyButtonValue(int value)
        {
            return "*";
        }
        public string GetSharpButtonValue(int value)
        {
            return "#";
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
                case 1:
                    ButtonOne++;
                    if (ButtonOne > 1) ButtonOne = 0;
                    break;
                case 2:
                    ButtonTwo++;
                    if (ButtonTwo > 3) ButtonTwo = 0;
                    break;
                case 3:
                    ButtonThree++;
                    if (ButtonThree > 3) ButtonThree = 0;
                    break;
                case 4:
                    ButtonFour++;
                    if (ButtonFour > 3) ButtonFour = 0;
                    break;
                case 5:
                    ButtonFive++;
                    if (ButtonFive > 3) ButtonFive = 0;
                    break;
                case 6:
                    ButtonSix++;
                    if (ButtonSix > 3) ButtonSix = 0;
                    break;
                case 7:
                    ButtonSeven++;
                    if (ButtonSeven > 3) ButtonSeven = 0;
                    break;
                case 8:
                    ButtonEight++;
                    if (ButtonEight > 3) ButtonEight = 0;
                    break;
                case 9:
                    ButtonNine++;
                    if (ButtonNine > 3) ButtonNine = 0;
                    break;
                case 0:
                    ButtonZero++;
                    if (ButtonZero > 1) ButtonZero = 0;
                    break;
                case 10:
                    ButtonMultiply++;
                    if (ButtonMultiply > 1) ButtonMultiply = 0;
                    break;
                case 11:
                    ButtonSharp++;
                    if (ButtonSharp > 1) ButtonSharp = 0;
                    break;
            }
        }
        public void ButtonClearValue()
        {
            ButtonOne = ButtonTwo = ButtonThree = ButtonFour = ButtonFive = ButtonSix = ButtonSeven = ButtonEight = ButtonNine = ButtonZero = ButtonSharp = ButtonMultiply = 0;
        }
    }
}
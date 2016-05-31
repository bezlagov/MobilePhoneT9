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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneT9.View
{
    public static class Show
    {
        public static string SetLengText(bool value)
        {
            if (value)
                return "RUS";
            else return "ENG";
        }
    }
}

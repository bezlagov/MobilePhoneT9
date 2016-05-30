using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneT9.Model;

namespace MobilePhoneT9.Controller
{
    public static class DataController
    {
        public static TelephoneData Data()
        {
            return TelephoneData.Instance;
        }
    }
}

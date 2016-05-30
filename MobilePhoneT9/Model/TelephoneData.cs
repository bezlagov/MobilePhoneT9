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
    }
}

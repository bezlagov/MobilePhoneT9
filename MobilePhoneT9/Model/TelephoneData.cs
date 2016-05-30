using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MobilePhoneT9.Model
{
    class TelephoneData
    {
        public string MainScreenText { get; set; } = "";
        public bool isRusSeted { get; set; } = true;
        public Timer timer = new Timer();
        public double CurrentTimer { get; set; }
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

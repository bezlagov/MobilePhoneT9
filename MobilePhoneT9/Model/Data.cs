using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneT9.Model
{
    class Data
    {
        private static Data _instance;
        public static Data Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }
        
        public List<Dict> dictionaryData;
        private Data()
        {
            dictionaryData = new List<Dict>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneT9.Controller
{
    class DatabaseProvider
    {
        private static DatabaseProvider _instance;
        public static DatabaseProvider Instance
        {
            get
            {
                if (_instance == null)  _instance = new DatabaseProvider();
                return _instance;
            }
        }
        DatabaseProvider()
        {
            
        }

    }
}

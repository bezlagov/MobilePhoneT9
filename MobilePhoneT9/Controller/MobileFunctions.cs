using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneT9.Model;

namespace MobilePhoneT9.Controller
{
    class MobileFunctions
    {
        private static MobileFunctions _instance;
        public static MobileFunctions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MobileFunctions();
                return _instance;
            }
        }

        private MobileFunctions()
        { }
        public bool LenguageChanger()
        {
            if (TelephoneData.Instance.isRusSeted)
                TelephoneData.Instance.isRusSeted = false;
            else
                TelephoneData.Instance.isRusSeted = true;
            return TelephoneData.Instance.isRusSeted;
        }
        public bool CaseChange()
        {
            if (TelephoneData.Instance.IsLowerCase)
                TelephoneData.Instance.IsLowerCase = false;
            else
                TelephoneData.Instance.IsLowerCase = true;
            return TelephoneData.Instance.IsLowerCase;
        }
        public string DeleteSymbol()
        {
            if (TelephoneData.Instance.MainScreenText.Length > 0)
                //  return TelephoneData.Instance.MainScreenText = TelephoneData.Instance.MainScreenText.Substring(0, TelephoneData.Instance.MainScreenText.Length - 1);
                return TelephoneData.Instance.MainScreenText = TelephoneData.Instance.MainScreenText.Remove(TelephoneData.Instance.MainScreenText.Length - 1, 1);
            return null;
        }
    }
}

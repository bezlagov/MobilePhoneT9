using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneT9.Model;

namespace MobilePhoneT9.Controller
{
    class TimerController
    {
        private static TimerController _instance;
        public static TimerController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TimerController();
                return _instance;
            }
        }

        private TimerController()
        { }

        public void StartButtonTimer()
        {
            ApplicationTimer.Instance.StartTimer();
        }

        public void StopButtonTimer()
        {
            ApplicationTimer.Instance.StopTimer();
        }

        public double GetCurrentTimerValue()
        {
            return ApplicationTimer.Instance.currentTimer;
        }
    }
}

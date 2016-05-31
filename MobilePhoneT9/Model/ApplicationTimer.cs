using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MobilePhoneT9.Model
{
    class ApplicationTimer
    {
        private static ApplicationTimer _instance;
        private Timer _buttonTimer = new Timer();
        private Timer _mainTimer = new Timer();
        public double CurrentTimer { get; set; }
        public double MainTimerTiker { get; set; }
        public static ApplicationTimer Instance
        {
            get
            {
                if (_instance == null)
                    return _instance = new ApplicationTimer();
                return _instance;
            }
        }
        private ApplicationTimer()
        {
            _buttonTimer.Interval = 100;
            _buttonTimer.Tick += SetCurrentTimer;
            _mainTimer.Interval = 100;
            _mainTimer.Tick += SetCurrentMainTimer;
        }

        private void SetCurrentTimer(object sender, EventArgs e)
        {
            CurrentTimer += 0.1;
        }
        private void SetCurrentMainTimer(object sender, EventArgs e)
        {
            MainTimerTiker += 0.1;
        }

        public void StartTimer()
        {
            CurrentTimer = 0;
            _buttonTimer.Start();
        }

        public void StartMainTimer()
        {
            MainTimerTiker = 0;
            _mainTimer.Start();
        }

        public void StopTimer()
        {
            _buttonTimer.Stop();
        }

        public void StopMainTimer()
        {
            _mainTimer.Stop();
        }
    }
}

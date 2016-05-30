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
        public double currentTimer { get; set; }
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
        }

        private void SetCurrentTimer(object sender, EventArgs e)
        {
            currentTimer += 0.1;
        }

        public void StartTimer()
        {
            currentTimer = 0;
            _buttonTimer.Start();
        }

        public void StopTimer()
        {
            _buttonTimer.Stop();
        }
    }
}

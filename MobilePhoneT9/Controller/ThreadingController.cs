using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;


namespace MobilePhoneT9.Controller
{
    class ThreadingController
    {
        private static ThreadingController _instance;
        public static ThreadingController Instance
        {
            get
            {
                if (_instance == null) _instance = new ThreadingController();
                return _instance;
            }
        }
        private ThreadingController()
        {
        }
        public void ThreadFunc1(object obj)
        {
            TimerController.Instance.StartMainTimer();

        }
        public void StartTimerX()
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(ThreadFunc1));
            t1.Start();
        }

    }
}

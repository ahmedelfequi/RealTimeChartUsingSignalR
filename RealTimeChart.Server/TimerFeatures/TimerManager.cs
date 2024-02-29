using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RealTimeChart.Server.TimerFeatures
{
    public class TimerManager
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private Action _action;
        public bool IsTimerStarted;
        public DateTime TimerStarted;

        public void PrepareTimer(Action action)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            _timer = new Timer(TimerCallBack, _autoResetEvent, 1000, 2000);
            IsTimerStarted = true;
            TimerStarted = DateTime.Now;
        }

        private void TimerCallBack(object state)
        {
            _action();

            if((DateTime.Now - TimerStarted).TotalSeconds > 60)
            {
                IsTimerStarted = false;
                _timer.Dispose();
            }
        }
    }
}

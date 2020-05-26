using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MultiThreadTasks.Model.TaskLauncher
{
    class Launcher
    {
        private Stopwatch stopwatch;
        public Launcher()
        {
            stopwatch = new Stopwatch();
        }

        public void StartTimer()
        {
            stopwatch.Start();
        }

        protected void StopTimer()
        {
            stopwatch.Stop();
        }

        public long GetExecutionTime()
        {
            StopTimer();
            long executionTime = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
            return executionTime;
        }
    }
}

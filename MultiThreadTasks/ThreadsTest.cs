using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadTasks
{
    class ThreadsTest
    {
        public Func<string> funcArg;
        private int count;
        public ThreadsTest()
        {
            count = 0;
            funcArg = getCount;
        }

        private string getCount()
        {
            return (count++).ToString();
        }
    }
}

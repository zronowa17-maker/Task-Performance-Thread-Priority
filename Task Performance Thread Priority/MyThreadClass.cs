using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_Performance_Thread_Priority
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name + " Process = " + loopCount);
            }
        }
    }
}


     
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            {
                Thread.Sleep(1000);

                for (int LoopCount = 1; LoopCount <= 5; LoopCount++)
                {
                    Thread thread = Thread.CurrentThread;
                    Console.WriteLine("Name of Thread: " + thread.Name + " = " + LoopCount);

                    Thread.Sleep(1500);
                }   
            }
        }
    }
}

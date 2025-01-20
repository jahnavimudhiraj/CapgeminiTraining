using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class MultiThreadingEX
    { 
        static void SomeFunc()
        {
            string name = Thread.CurrentThread.Name;
            lock (typeof(MultiThreadingEX))
            {
                ConsoleIOEx.LoopThru(10, $"Some big tasks {name}");
            }
        }
        //async shall have the task object or Task<T> as its return type
        static async Task LongRunningOperationAsync()
        {
            Console.WriteLine("The task has started");
            ConsoleIOEx.LoopThru(10, "Task Message");
            Console.WriteLine("Task is completed");
            await Task.Delay(2000);
            //Console.WriteLine("Task has Ended");
        }
        static async Task Main(String[] args)
        {
            //threadingClass();
            //taskExample();
            Console.WriteLine("Main Started");
            Task t1 = LongRunningOperationAsync();
            ConsoleIOEx.LoopThru(5, "Main doing its job");
            await t1;
            Console.WriteLine("The main is terminated");

        }

        private static void taskExample()
        {
           
        }

        private static void threadingClass()
        {
            threadingClass();
            Console.WriteLine("Main started");
            Thread thread = new Thread(SomeFunc);
            thread.Name = "First Thread";
            thread.Start();
            Thread thread1 = new Thread(SomeFunc);
            thread1.Name = "Second Thread";
            thread1.Start();
            ConsoleIOEx.LoopThru(5, "Main doing its job");
            Console.WriteLine("Main ended");
        }
    }
}

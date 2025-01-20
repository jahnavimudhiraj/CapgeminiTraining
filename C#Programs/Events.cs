using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Programs
{
    public delegate void Trigger(string message);
    

    class AlarmClock
    {
        private DateTime _alarmTime;
        public event Trigger RaiseAlarm;
        public AlarmClock(DateTime alarmTime)
        {
            _alarmTime = alarmTime;
        }
        public void DisplayClock()
        {
            do
            {
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                Thread.Sleep(1000);
                Console.Clear();
                if (DateTime.Now.Minute == _alarmTime.Minute)
                {
                    RaiseAlarm?.Invoke("Time to pactice");
                }
            } while (true);
        }
    }

    internal class Events
    {
        static void Main(String[]args)
        {
            AlarmClock clock = new AlarmClock(DateTime.Now.AddMinutes(1));
            clock.RaiseAlarm += Clock_RaiseAlarm;
            clock.DisplayClock();
        }
        private static void Clock_RaiseAlarm(string message)
        {
            Console.WriteLine(message);
        }
    }

}

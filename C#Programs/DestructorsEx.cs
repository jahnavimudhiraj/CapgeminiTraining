using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    class SampleClassDestructor : IDisposable
    {
        private readonly string _name;
        public SampleClassDestructor(string name)
        {
            _name = name;
            Console.WriteLine($"The obj {name} created is ");
        }
        //Syntax for destructor. Dont have access specifiers and no parameters. 
        ~SampleClassDestructor()
        {
            Console.WriteLine($"The obj {_name} is destroyed");

        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Call this function to free any C/C++ Destructors");
        }
        internal class DestructorsEx
        {
            static void Main(string[] args)
            {
                for (int i = 0; i < 100; i++)
                {
                    using (SampleClassDestructor cls = new SampleClassDestructor(i.ToString()))
                    {
                        GC.Collect();//Starts a new thread to destroy all the garbage data. 
                        GC.WaitForPendingFinalizers();

                    }
                }
                Console.WriteLine("now the program is ending");
            }
        }
    }
}

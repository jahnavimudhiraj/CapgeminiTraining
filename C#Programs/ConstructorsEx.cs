using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    class ConstructorClass
    {
        static ConstructorClass()
        {
            Console.WriteLine("Static constructor");
        }
        public ConstructorClass()
        {
            Console.WriteLine("Normal constructor");
        }
        class EmpDatabase
        {
            private List<string> _employees;
            public EmpDatabase(int initialSize = 1)
            {
                _employees = new List<string>(initialSize);
            }
            public void AddEmployee(string employee)
            {
                _employees.Add(employee);
            }
        }
    }
        internal class ConstructorsEx
        {
        static ConstructorsEx()
        {
            Console.WriteLine("Executed even before main");
        }
                static void Main(string[] args)
                {
                    StaticConstructorsDemo();
                }
            
                private static void StaticConstructorsDemo()
            {
                //Note: Static constructor is called only once.
                for (int i = 0; i < 10; i++)
                {
                    //called so many no of times. 
                    ConstructorClass cls = new ConstructorClass();
                }
            }
        }
}
    


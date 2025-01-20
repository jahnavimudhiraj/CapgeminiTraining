using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double salary { get; set; }
        public static Employee operator + (Employee lhs , double rhs)
        {
            lhs.salary += rhs;
            return lhs;
        }
        public static Employee operator -(Employee lhs, double rhs)
        {
            lhs.salary -= rhs;
            return lhs;
        }
        public static implicit operator double(Employee lhs)
        {
            return lhs.salary;
        }
    }
    internal class Ex21OperatorOverloading
    {
        public static void Main(String[] args)
        {
            Employee e1 = new Employee();
            e1.salary = 2000;
            

            //U R setting the salary for the e1
            e1.salary = 7000;
            double salary = e1; //The Emp objct is implicitly converted to double as double is overloaded for the Emp object
            Console.WriteLine("The current salary is " + e1.salary);
            e1 += 2000;

            Console.WriteLine("The current salary is " + e1.salary);
            e1 -= 500;
            Console.WriteLine("The current salary is " + e1.salary);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    delegate double MyMethod(int first, int  second);
    internal class DeligatesExample
    {
        static void InvokeSquareFunc(double d1 ,Func<double, double> method)
        {
            var result = method(d1);
            Console.WriteLine(result);
        }
        static void InvokeUsingFunc(int first, int sec, Func<int ,int, double> method)
        {
            //check all business rules
            var result = method(first, sec);
            Console.WriteLine(result);
        }
        static void InvokeArithematicMethod(int v1, int v2, MyMethod method)
        {
            //Check all the rules
            var result = method(v1 , v2);
            Console.WriteLine(result);
        }
        //static double addFunc(int v1, int v2)
        //{
        //    return v1 + v2;
        //}
        static void Main(String[] args)
        {
            //MyMethod func = new MyMethod(addFunc);
            //InvokeArithematicMethod(123, 12 ,func);    ----->1st version
            //InvokeArithematicMethod(123, 12, addFunc);    -------->2nd Version
            //InvokeArithematicMethod(123, 21, (a1, a2) => a1 + a2);   // ------->3rd version no need of writing the addFunc method
            Func<int, int, double> myFunc = new Func<int, int, double>(( i1,i2)=> 
            {
                return i1 + i2;
            });

            //or
            // Func <int,int,double> myFunc = new Func<int, int, double>(( i1,i2)=> i1 + i2);
            InvokeUsingFunc(123, 23, myFunc);

            Func<double, double> sqr = new Func<double, double>((d1) => d1 * d1);
            InvokeSquareFunc(12, sqr);
        }

    }
}

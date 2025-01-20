using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    enum PaymentMode { Cash, Cheque, UPI, Card }
    class FatherClass
    {

        public virtual void MakePayment(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.Cash || mode == PaymentMode.Cheque)
            {
                string output = $"the payment of {amount:C} is paid via {mode}";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid Payment");
            }
        }
        public void PayVendor(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.Cheque)
            {
                Console.WriteLine($"the payment of{amount:C}is paid via{mode}");
            }
            else
            {
                Console.WriteLine("Invalid Payment");
            }
        }
        class SonClass : FatherClass
        {
            public override void MakePayment(PaymentMode mode, int amount)
            {
                if(mode==PaymentMode.Card || mode==PaymentMode.UPI)
                {
                    string output = $"the payment of{amount:C} is paid via{mode}";
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine("Invalid payment mode");
                }

                }
            public void PayVendor(PaymentMode mode,int amount)
            {
                if (mode == PaymentMode.Card)
                {
                    Console.WriteLine($"the payment of{amount:C}is paid via{mode}");
                }
                else
                {
                    Console.WriteLine("Invalid Payment");
                }
            }
            }


        internal class MethodOverriding
        {
            static void Main(string[] args)
            {
                FatherClass business = new FatherClass();
                business.MakePayment(PaymentMode.Cash, 5000);
                business.PayVendor(PaymentMode.UPI ,3000);

                business = new SonClass();
                business.MakePayment(PaymentMode.UPI, 10000);
                business.PayVendor(PaymentMode.Cheque, 3000);//Shall call the base version only

                //PS: If U intend to call the Child version, U should do downcasting. 
                SonClass tempInstance = (SonClass)business;
                tempInstance.PayVendor(PaymentMode.UPI, 76000);
            }
        }
        }

    
}


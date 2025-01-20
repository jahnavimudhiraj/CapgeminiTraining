using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class ClassesAndObjects
    {
                static void Main(string[] args)
                {
                Test test = new Test();
                test.Testfn();
                Console.WriteLine("Enter the amount to start with: ");
                double amount = double.Parse(Console.ReadLine());
                ExpenseManager Manager = new ExpenseManager(amount);
                Console.WriteLine("The title is : Trip Expense Manager");
            
            Console.WriteLine("Enter the amount to add");
            amount = double.Parse(Console.ReadLine());

            Manager.Addamount(amount);
            Console.WriteLine("The amount after adding is:" + Manager.GetBalance());


            Manager.MakePayment(50);
            Console.WriteLine("The amount after deduction is :" + Manager.GetBalance());

            ExpenseManager foodExp = new ExpenseManager(10000);
            foodExp.SetTitle("Food Expenses");
            foodExp.DisplayTitle();
            Manager.DisplayTitle();

        }
        class Test
        {
            //intended to be used within the class. Probably by the public methods
            private void PersonalFn()
            {
                Console.WriteLine("hello");
            }
            public void Testfn()
            {
                Console.WriteLine("hiii");
                PersonalFn();
            }
        }

        class ExpenseManager
        {
            double amount;
            static string Title = String.Empty;
            public ExpenseManager(double amount)
            {
                this.amount = amount;

            }
            public void Addamount(double amount)
            {
                this.amount += amount;
            }
            public double GetBalance()
            {
                return amount;
            }
            public void MakePayment(double amount)
            {
                if (amount > this.amount)
                {
                    throw new System.Exception("Insufficient Funds");
                }
                this.amount -= amount;
            }
            public void SetTitle(string title)
            {
                ExpenseManager.Title = title;
                Console.WriteLine(ExpenseManager.Title);
            }
            public void DisplayTitle()
            {
                ExpenseManager.Title = Title;
                Console.WriteLine(ExpenseManager.Title);
            }

        }

    }

}
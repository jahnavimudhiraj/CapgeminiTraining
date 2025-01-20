using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_Programs
{
    internal class AbstractClass
    {
        abstract class account
        {
            public int Accountno { get; set; }
            public string AccountHolderName { get; set; }
            public double Balance { get; set; }
            public void credit(int amount)
            {
                Balance += amount;
            }
            public void debit(int amount)

            {
                if (amount > Balance)
                {
                    throw new System.Exception("Invalid Fund");
                }
                else
                {
                    Balance -= amount;
                }

            }
            public abstract void CalculateIntrest();



        }
        class SBAccount : account //inheritance
        {
            public override void CalculateIntrest()
            {
                double term = 0.25;
                double rateofintrest = 0.065;
                var intrest = this.Balance * term * rateofintrest;
                credit((int)intrest);
            }
        }
        class RDAccount : account
        {
            public override void CalculateIntrest()
            {
                throw new NotImplementedException();
            }
        }
        class FDAccount : account
        {
            public override void CalculateIntrest()
            {
                throw new NotImplementedException();
            }
        }
        enum AccountType { SB, RD, FD }
        class Accountfactory
        {
            public static account Createaccount(AccountType accType)
            {
                account acc = null;
                switch (accType)
                {
                    case AccountType.SB:
                        acc = new SBAccount();
                        break;
                    case AccountType.RD:
                        acc = new RDAccount();
                        break;
                    case AccountType.FD:
                        acc = new FDAccount();
                        break;
                    default:
                        break;
                }
                return acc;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of Account from the values below:");
            var accTypes = Enum.GetValues(typeof(AccountType));
            foreach (var accType in accTypes)
            {
                Console.WriteLine(accType);

                var type = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine(), true);
                var account = Accountfactory.Createaccount(type);
                account.Accountno = 143;
                account.AccountHolderName = "Jahnavi";
                account.credit(10000);
                account.CalculateIntrest();
                Console.WriteLine($"the current bal is{account.Balance}");
            }
        }
    }
}
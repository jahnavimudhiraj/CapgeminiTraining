using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    class HandlingException: Exception
    {
        public HandlingException()
        {

        }
        public HandlingException(string message) :base(message)
        {
            
        }
        public HandlingException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
    internal class ExceptionHandling
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number");
            RETRY:
            try
            {
                int no = int.Parse(Console.ReadLine());
                if (no >= 200 || no < 100)
                {
                    throw new HandlingException("no should be within 100 to 200");
                }
                Console.WriteLine("the number entered is " + no);
            }
            catch (FormatException)
            {
                Console.WriteLine("U must enter a valid integer value, please try again");
                goto RETRY;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The integer value is too big to hold.please enter again");
                goto RETRY;
            }
            catch(HandlingException exe)
            {
                Console.WriteLine(exe.Message);
                goto RETRY;
            }
            catch(Exception exec)
            {
                Console.WriteLine($"We actually dont know what went wrong!, The system has given the detail as : {exec.Message}. Please try again: ");
                goto RETRY;
            }
            finally
            {
                Console.WriteLine("All has ended properly");
            }
        }
    }
}

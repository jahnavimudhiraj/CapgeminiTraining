using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class Functions
    {
        static void Main(string[] args)
        {
            //CalProgram();
            DefaultFunction();

        }

        private static void DefaultFunction(/*string question="How are you Doing today?"*/)
        {
            string question = "How are you Doing today?";
               // Console.ReadLine();
            var answer=GetString(question);
            Console.WriteLine($"The answer is {answer}");
            
        }

        //it holds the title for the console window when the calculator program runs.
        const string Title = "Math Calc Program";

            /// <summary>
            /// Function to get string input from the user after asking a Question
            /// </summary>
            /// <param name="question">The Question to print</param>
            /// <returns>A string input given by the User.</returns>
            
           static  string GetString(string question)
            {
            Console.WriteLine(question);
            return Console.ReadLine();

            }
        static int GetValue(string question)
        {
            string answer=GetString(question);
            return Convert.ToInt32(answer);
        }
        private static void CalProgram()
        {
            Console.Title = Title;
            do
            {
                Console.Clear();
                int firstval = GetValue("Enter the first Value");
                int secval = GetValue("Enter thge sec value");
                string choice = GetString("enter your choice as +,-,*,/");
                double result = ProcessChoice(firstval, secval, choice);
                Console.WriteLine("The result of this Operation is " + result);
            } while (GetString("press Y to continue").ToUpper() == "Y");
        }
            private static double ProcessChoice(int firstval, int secval, string choice)
        {
            double result = 0.0;
            switch (choice)
            {

                case "+": result= firstval + secval;break;
                case "-":result=  firstval - secval; break;
                case "*": result= firstval * secval; break;
                case "/": result= firstval / secval; break;
                default:
                    break;

            }
            return result;
        }

        }

        }
    


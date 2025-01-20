using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class ConsoleIOEx
    {


        
            /// <summary>
            /// Function to get string input from the user after asking a Question
            /// </summary>
            /// <param name="question">The Question to print</param>
            /// <returns>A string input given by the User.</returns>
            public static string GetString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            /// <summary>
            /// Function to get integer value from the User after asking a Question
            /// </summary>
            /// <param name="question">The Question to print</param>
            /// <returns>A Valid integer.</returns>
            public static int GetValue(string question)
            {
                string answer = GetString(question);
                return Convert.ToInt32(answer);
            }

            public static void LoopThru(int times, string message)
            {
                for (int i = 0; i < times; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(message);
                }
            }
        
    }
}



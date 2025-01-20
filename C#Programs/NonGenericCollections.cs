using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class NonGenericCollections
    {
        static void Main(String[] args)
        {
            //ArrayListExample();
            HashTableExample();
        }

        private static void HashTableExample()
        {
            string menu = File.ReadAllText(@"C:\Users\AMBJAHNA\Desktop\MyTrainingWork\Training\C#Programs\TextFile1.txt");
            //Collection of data in the form or key-value pairs
            Hashtable user = new Hashtable();
            do
            {
                var choice = ConsoleIO.GetString(menu);

                switch (choice)
                {
                    case "1":
                    Retry:
                        string UN = ConsoleIO.GetString("Enter  the username to signup");
                        string pwd = ConsoleIO.GetString("Enter the Password");
                        if (user.ContainsKey(UN))
                        {
                            Console.WriteLine("User already exist");
                            goto Retry;
                        }
                        user[UN] = pwd;//If the username already exists, it shall replace the value. 
                        Console.WriteLine("the current userlist is :" + user.Count);
                        break;

                    case "2":
                        UN = ConsoleIO.GetString("Enter the username to login");
                        pwd = ConsoleIO.GetString("Enter the password");
                        pwd = Console.ReadLine();
                        if (!user.ContainsKey(UN))
                        {
                            Console.WriteLine("Invalid Username");

                        }
                        else
                        {
                            if (user[UN].ToString() != pwd)
                            {
                                Console.WriteLine("Invalid password");
                            }
                            else
                            {
                                Console.WriteLine($"Welcome MS{UN}");
                            }


                        }
                        break;
                            case "3":
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid details");
                        break;

                }



            } while (true);
        }

        private static void ArrayListExample()
        {
            ArrayList list = new ArrayList();
            list.Add("Mangoes");
            list.Add("Apples");
            list.Add("Kiwi");
            list.Add("Watermelon");
            list.Add("Oranges");
            Console.WriteLine("The total number of fruits are :"+ list.Count);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove("Watermelon");
            //list.Insert(3, 1234);//Collection classes are not typesafe.
            Console.WriteLine("the total number of fruits are :" + list.Count);
        }
    }
 }



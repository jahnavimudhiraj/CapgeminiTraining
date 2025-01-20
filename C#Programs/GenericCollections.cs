using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class GenericCollections
    {
        static void Main(String[] args)
        {
            //ListExample();
            //HashSetExample();
            HashSetOnEmployee();
        }
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double salary { get; set; }
        }

        private static void HashSetOnEmployee()
        {
            HashSet<Employee> employees = new HashSet<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Jahnavi", salary = 26000.0 });
            employees.Add(new Employee { Id = 2, Name = "Pradeep", salary = 50000.0 });
            foreach(Employee emp in employees)
            {
                Console.WriteLine($"the name is {emp.Name} and hashcode is{emp.GetHashCode()}");
            }
            var list = employees.ToList();
            Console.WriteLine(list[0] == list[1]);
            Console.WriteLine("The count: " + employees.Count);
        }
        

        private static void HashSetExample()
        {
            HashSet<string> list = new HashSet<string>();
            list.Add("Jahnavi");
            list.Add("Pradeep");
            list.Add("Akhil");
            list.Add("Akshay");
            list.Add("srinivas");
            if (!list.Add("Sujatha"))
            {
                Console.WriteLine("Item already exist");
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            //list.contain is used to check if the item is in the list or not
            Console.WriteLine("The list count is :" + list.Count);
        }

        private static void ListExample()
        {
            List<string> list = new List<string>();
            list.Add("Mangoes");
            list.Add("Apples");
            list.Add("Kiwi");
            list.Add("sapota");
            list.Insert(4, "Oranges");
            list.Remove("sapota");
            list.RemoveAt(1);
            list.IndexOf(list[2]);
            foreach(string items in list)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("The total count is :" + list.Count);
        }
    }
}

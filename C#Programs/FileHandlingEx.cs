using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class FileHandlingEx
    {
        class Employee
        {
            public int EmpId;
            public string EmpName;

            static void Main(String[] args)
            {
                WritingToFile();

            }
            public static void WritingToFile()
            {
                string FileName = "Info.txt";
                File.WriteAllText(FileName, "Sample Content of file");
                //if the file exists opens the file for writing else, creates the file and writes to it
                File.AppendAllText(FileName, "\nSome more content to write");
            }

        }
    }
}

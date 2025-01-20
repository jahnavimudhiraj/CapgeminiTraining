using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDll
{
    public  interface IStringComponent
    {
        string GetUpperCase(string value);
    }
    public class StringComponent : IStringComponent
    { 
        public string GetUpperCase(string value) {
            return value; 
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    internal class RunTimePolymorphism
    {
        class BaseClass
        {
            public virtual void BaseFun()
            {
                Console.WriteLine("Base Function");
            }
            class DerivedClass : BaseClass//indentation syntax
            {
                public override void BaseFun()
                {
                    {
                        Console.WriteLine("Derived Class");
                    }
                }
                    class objectfactory
                {
                    public static BaseClass CreateObj(string ObjTyp)
                    {
                        if(ObjTyp == "Base")
                        {
                            return new BaseClass();
                        }
                        else if(ObjTyp =="Derived")
                            {
                            return new DerivedClass();
                        }
                        else
                        {
                            throw new System.Exception("invalid");
                        }
                    }
                }

                static void Main(string[] args)
                {
                    Console.WriteLine("Enter the type of obj to create ");
                    string answer=Console.ReadLine();
                    var obj = objectfactory.CreateObj(answer);
                    obj.BaseFun();
                }
            }

        }
    }
}

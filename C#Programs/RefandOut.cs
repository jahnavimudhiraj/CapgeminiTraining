using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace C_Programs{
    class RefAndOutExample
    {
        static void Main(string[] args)
        {
            string arg = "Jaanu";
            //TestFunc(ref arg);
            Console.WriteLine("the arg value after the function call is " + arg);
            
            //Calling Mathoperation:
            int addedVal = 0, subval = 0, mulVal = 0;
            double divVal;
            CallingMathOperations(123, 23, ref addedVal, ref subval, ref mulVal, out divVal);
            Console.WriteLine($"The Added value: {addedVal}\nThe Subtracted Value: {subval}\nThe multiplied value: {mulVal}\n The DividentValue is :{divVal}");
            double SquArea, RectArea, RhomArea;
            CalculateArea(10, 5, out RectArea, out SquArea, out RhomArea);
            Console.WriteLine($"Area of rectangle is :{RectArea}\n Area of Square is : {SquArea}\n The Area of Rhombus is :{RhomArea}");
            
        }

        private static void CalculateArea(int length, int height, out double areaOfRect, out double areaOfSquare, out double areaOfRhombus)
        {
            areaOfRect = length * height;
            areaOfSquare = length * length;
            areaOfRhombus = 0.5 * length * height;

        }

        private static void CallingMathOperations(int val1, int val2, ref int iAddValue, ref int iSubValue, ref int iMulValue, out double iDivideValue)
        {
            iAddValue = val1 + val2;
            iSubValue = val1 - val2;
            iMulValue = val1 * val2;
            iDivideValue = val1 / val2;

            if (val2 != 0)
            {
                //as iDivVal is out parameter, the function must assign some value to it before it returns to the caller. 
                iDivideValue = val1 / val2;
            }
            else
            {
                iDivideValue = 0;
            }
        }

        private static void TestFunc(ref string arg)
        {
            Console.WriteLine("the arg is "+arg);
            arg = "changing the arg value";
            
        }
    }


}

using System;

namespace C_Programs
{
    class ParamsKeyword
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumber(123));
            Console.WriteLine(AddNumber(234,345,567,235));
            Console.WriteLine(AddNumber(456,890,267));
            Console.WriteLine(AddNumber(123,123,345,678,789,901));
            Console.WriteLine(AddNumber(8790,123,691));

        }

        private static long AddNumber(params int[] inputs)
        {
            long result = 0;
            foreach (var input in inputs)
            {
                result += input;
            }
            return result;
        }
    }
}
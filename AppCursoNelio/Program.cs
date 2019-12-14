
using System;

namespace AppCursoNelio
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 127;

            int num = 1000;
            int num2 = 2147483647;
            long num3 = 214748364754;

            bool admin = false;
            char gender = '\u0041';

            float n4 = 4.5155f;
            double n5 = 4.5;

            string eliza = "queen";
            eliza += "jose";



            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(eliza);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(x);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(gender);
        }
    }
}

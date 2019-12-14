
using System;
using System.Globalization;

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

            
            // with coma 
            Console.WriteLine(n5.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(gender);


            int idade = 32;
            double saldo = 100.00;
            string nome= "maria";

            Console.WriteLine("{0} tem {1} e tem saldo igual a: {2:F1}", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a: {saldo:F1}");
            Console.WriteLine(nome + " tem" + idade + " e tem saldo igual a:" + saldo);

        }
    }
}

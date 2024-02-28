using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não negativo");
            string s = Console.ReadLine();
            byte m = byte.Parse(s);

            Console.WriteLine(--m);
            Console.WriteLine(++m);

        }
    }
}

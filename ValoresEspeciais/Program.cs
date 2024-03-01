using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: mínimo = {byte.MinValue}, máximo = {byte.MaxValue}");
            Console.WriteLine($"int: mínimo = {int.MinValue}, máximo = {int.MaxValue}");
            Console.WriteLine($"float: mínimo = {float.MinValue}, máximo = {float.MaxValue}");
            Console.WriteLine($"decimal: mínimo = {decimal.MinValue}, máximo = {decimal.MaxValue}");
            Console.WriteLine($"char: mínimo = {(int)char.MinValue}, máximo = {(int)char.MaxValue}");
                    Console.WriteLine($"bool: mínimo = {bool.FalseString}, máximo = {bool.TrueString}");
            
        }
    }
}

﻿using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: mínimo = {byte.MinValue}, máximo = {byte.MaxValue}");
            Console.WriteLine($"int: mínimo = {int.MinValue}, máximo = {int.MaxValue}");
            Console.WriteLine($"uint: mínimo = {uint.MinValue}, máximo = {uint.MaxValue}");
            Console.WriteLine($"float: mínimo = {float.MinValue}, máximo = {float.MaxValue}");
            Console.WriteLine($"decimal: mínimo = {decimal.MinValue}, máximo = {decimal.MaxValue}");
            Console.WriteLine($"char: mínimo = {(int)char.MinValue}, máximo = {(int)char.MaxValue}");
            Console.WriteLine($"bool: mínimo = {bool.FalseString}, máximo = {bool.TrueString}");


        uint overflow = maxValue + 1;
        Console.WriteLine($"overflow uint: {overflow}");

        float overflowfloat = maxValue + 1.0;
        Console.WriteLine($"overflow float: {overflowfloat}");

        float overflowfloatm = minValue - 1.0;
        Console.WriteLine($"overflow float: {overflowfloatm}");
        


        }
    }
}

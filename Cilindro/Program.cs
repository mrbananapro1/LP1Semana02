using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a altura do cilindro");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o raio do cilindro");
            float raio = float.Parse(Console.ReadLine());
        
            float volume = MathF.PI * raio * raio * altura;

            float areaSuperficie = 2 * MathF.PI * raio * (raio + altura);

            Console.WriteLine($"O volume é: {volume}")
        }
    }
}

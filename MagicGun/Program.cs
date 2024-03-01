using System;

namespace BreakContinue
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string shots;
            
            Console.Write("How many shots: ");
            shots = Console.ReadLine();
            int shotsx = int.Parse(shots);
            int rounds = 1;
            while (true)
            {
                rounds++;


                if (shotsx % 3 == 0 && shotsx % 5 == 0)
                {
                    Console.WriteLine($"{shots}: Magic Fire! Electric Fire!");
                }


                if (shotsx % 3 == 0)
                {
                    Console.WriteLine($"{shots}: Magic Fire!");
                }

                if (shotsx % 5 == 0)
                {
                    Console.WriteLine($"{shots}: Electric Fire!");
                }

                // Print turn number
                Console.WriteLine("Normal fire :/");
            }

            // Print number of last turn
            Console.WriteLine($"Last turn was {rounds}");
        }
    }
}


using System;

namespace BreakContinue
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string shots;
            
            Console.Write("How many shots");
            shots = Console.ReadLine();
            int shotsx = int.Parse(shots);
            int rounds = 1;
            while (true)
            {
                rounds++;

                // Ends loop if we're over the maximum number of turns
                if (shotsx > rounds)
                {
                    break;
                }

        // Skips current cycle if current turn is divisible by 3 or equal to 10
                if (rounds % 3 == 0 || rounds == 10)
                {
                    continue;
                }

                // Print turn number
                Console.WriteLine("Normal fire :/");
            }

            // Print number of last turn
            Console.WriteLine($"Last turn was {rounds}");
        }
    }
}


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
            for (int rounds = 1; rounds <= shotsx; rounds++)
            {


                if (rounds % 3 == 0 && rounds % 5 == 0)
                {
                    Console.WriteLine($"{rounds}: Magic Fire! Electric Fire!");
                    continue;
                }


                else if (rounds % 3 == 0)
                {
                    Console.WriteLine($"{rounds}: Magic Fire!");
                    
                }

                else if (rounds % 5 == 0) 
                {
                    Console.WriteLine($"{rounds}: Electric Fire!");
                    
                }

                else
                {
                    Console.WriteLine($"{rounds}: Normal fire :/");
                }
                }
                
                
            }

 
            
        }
    }



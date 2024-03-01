using System;
using System.Formats.Asn1;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            string question, answer;
            //loop

            do
            {
                Console.Write("What can i help you with today: ");
                question = Console.ReadLine();

                switch (question)
                {
                    case "Who are you?":
                        answer = "A program made by a very handsome man";
                        break;

                    case "Where are you from?":
                        answer = "The insides of your computer";
                        break;

                    case "Are you a paid actor?":
                        answer = "I wouldn't say i am";
                        break;

                    case "Are we in a simulation?":
                        answer = "You're not ready for that answer";
                        break;

                    case "EXIT":
                        return;

                    default:
                        answer = "I'm not answering that";
                        break;
                    
                }

                Console.WriteLine($"ChatGPTOne: {answer}\n");

            } while (true);


        }
    }
}

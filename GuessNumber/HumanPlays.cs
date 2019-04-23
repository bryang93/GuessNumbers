using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class HumanPlays
    {
        private int NumSelected { get; set; }

        private int ComputersNumber { get; set; }
        private int Max { get; set; }
        private int Min { get; set; }
        private void ComputersPick(Random random) //Computer chooses number
        {
            ComputersNumber = random.Next(1, 1000);
        }

        public void Operate(Random random)
        {
            ComputersPick(random); //Computer selects number
            Max = 1000;
            Min = 0;
            int loopCount = 0;
            do
            {
                loopCount++;
                Console.Clear();
                Console.WriteLine($"Guess number between {Min} - {Max}\n" +
                    $"Number of Guesses: {loopCount}");
                int input = int.Parse(Console.ReadLine());
                if (input < Min || input > Max)
                {
                    loopCount--;
                    Console.WriteLine("Invalid Selection");
                    Console.ReadLine();
                }
                else if (input < ComputersNumber)
                {
                    Console.WriteLine("That's a low guess");
                    Console.ReadLine();
                    Min = input;
                }
                else if (input > ComputersNumber)
                {
                    Console.WriteLine("That's a high guess");
                    Console.ReadLine();
                    Max = input;
                }
                else if (input == ComputersNumber)
                {
                    break;
                }
            } while (Min < Max);
            Console.Clear();
            Console.WriteLine($"Correct! The number was {ComputersNumber}\n" +
                $"It took you {loopCount} tries!");
        }

    }
}

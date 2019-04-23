using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class ComputerPlays
    {
        private int NumSelected { get; set; }
        private int RandomNumber { get; set; }
        private int Max { get; set; }
        private int Min { get; set; }
        private void SelectNumber()
        {
            Console.WriteLine("Select number between 1 - 100");
            NumSelected = int.Parse(Console.ReadLine());
            if (NumSelected < 1 || NumSelected > 100)
            {
                Console.Clear();
                SelectNumber();
            }
        }

        private void GuessNumber(Random random)
        {
            RandomNumber = random.Next(Min + 1, Max - 1);
        }
        private void HighGuess()
        {
            Max = RandomNumber;
        }

        private void LowGuess()
        {
            Min = RandomNumber;
        }
        public void Operate(Random random)
        {
            SelectNumber();
            Max = 101;
            Min = 0;
            int loopCount = 0;
            do
            {
                loopCount++;
                Console.Clear();
                GuessNumber(random);
                Console.WriteLine($"Is your number {RandomNumber}?\n" +
                    $"1 = Too High     2 = Too Low     3 = You got it!\n" +
                    $"\n" +
                    $"Number of Guesses: {loopCount}");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {

                    HighGuess();
                }
                else if (input == 2)
                {
                    LowGuess();
                }
                else if (input == 3)
                {
                    Console.WriteLine($"Your number is {NumSelected}");

                }
                else if (input < 0 || input > 3)
                {
                    loopCount--;
                    Console.WriteLine("Invalid Selection");
                }
            } while (Min < Max);
            Console.Clear();
            Console.WriteLine($"Your number is {NumSelected}\n" +
                $"It took me {loopCount} tries!");
        }
    }
}

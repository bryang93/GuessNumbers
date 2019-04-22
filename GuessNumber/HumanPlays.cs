using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class HumanPlays
    {
        // 100 numbers to choose from
        // computer guesses number
        //human says too high or low or correct
        // Display value, guess, each repetition
        int NumSelected { get; set; }
        int RandomNumber { get; set; }
        int Max = 100;
        public void SelectNumber()
        {
            Console.WriteLine("Select number between 1 - 100");
            NumSelected = int.Parse(Console.ReadLine());
            if (NumSelected < 1 || NumSelected > 100)
            {
                SelectNumber();
            }
        } 

        public void GuessNumber(Random random)
        {
            RandomNumber = random.Next(Max)+1;
        }
        public void HighGuess()
        {
            Max -= (Max - RandomNumber);
        }

        public void LowGuess()
        {
            Max-= 
        }

        public void Operate(Random random)
        {
            SelectNumber();
            GuessNumber(random);

        }
    }
}

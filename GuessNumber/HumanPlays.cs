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
        private int Max { get; set; }
        private int Min { get; set; }


        private void GuessNumber()
        {
            Console.WriteLine("Guess number between {Min} - {Max}");
            NumSelected = int.Parse(Console.ReadLine());
            if (NumSelected < Min || NumSelected > Max)
            {
                Console.Clear();
                GuessNumber();
            }
        }

    }
}

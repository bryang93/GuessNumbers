﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static List<int> Numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            BiSection bi = new BiSection();
            ComputerPlays comP = new ComputerPlays();
            HumanPlays humanP = new HumanPlays();
            Random random = new Random();



            Console.WriteLine("Select Number");
            Console.WriteLine("1.) # Bisections    2.)Human Guess    3.)Computer Guess");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        Console.Clear();
                        bi.FindNumber(Numbers);
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        humanP.Operate(random);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        comP.Operate(random);
                        break;
                    }
            }

        }
    }
}

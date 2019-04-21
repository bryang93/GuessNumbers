using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Number");
            Console.WriteLine("1.) # Bisections    2.)Human Guess    3.)Computer Guess");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }


            Console.WriteLine("enter number");
            int input = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool findLoop = false;
            while (findLoop == false)
            {
                if (input == numbers[numbers.Count / 2])
                {
                    Console.WriteLine($"You're number is: {numbers[numbers.Count / 2]}");
                    findLoop = true;
                }
                else if (input < numbers[numbers.Count / 2])
                {
                    numbers.Reverse();
                    numbers.RemoveRange(0, numbers.Count / 2);
                    Console.WriteLine("Numbers Available");
                    foreach (var i in numbers)
                    {
                        Console.WriteLine(i);
                    }
                    numbers.Reverse();
                }
                else if (input > numbers[numbers.Count / 2])
                {
                    numbers.RemoveRange(0, numbers.Count / 2);
                    Console.WriteLine("Numbers Available");
                    foreach (var i in numbers)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}

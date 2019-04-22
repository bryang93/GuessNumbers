using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class BiSection
    {
       public void FindNumber(List<int> numbers)
        {
            Console.WriteLine("enter number");
            int input = int.Parse(Console.ReadLine());
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
                    NumbersAvailable(numbers);
                    numbers.Reverse();
                }
                else if (input > numbers[numbers.Count / 2])
                {
                    numbers.RemoveRange(0, numbers.Count / 2);
                    NumbersAvailable(numbers);
                }
            }
        }


        private void NumbersAvailable(List<int> numbers)
        {
            Console.WriteLine("Numbers Available");
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class BiSection
    {
        public List<int> Numbers { get; set; }
        public int Input { get; set; }


        public void NumbersAvailable()
        {
            Console.WriteLine("Numbers Available");
            foreach (var i in this.Numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}

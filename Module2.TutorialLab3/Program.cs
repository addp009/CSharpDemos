using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.TutorialLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Counter is at: {counter}.");
            }

            // nested loop

            int inner;
            int outer;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                {
                    if ((outer % inner) == 0) break; // factor found, not prime
                }
                if (inner > (outer / inner))
                {
                    Console.WriteLine("{0} is prime", outer);
                }
                    
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 2;

            int secondVar;
            secondVar = 10;

            int sum = myVar + secondVar;
            int product = myVar * secondVar;
            int remainder = myVar % secondVar;
            double value = (double)myVar / (double)secondVar;


            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(remainder);
            Console.WriteLine(value);


            string firstName = "Tom";
            string lastName = "Sawyer";

            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);
            Console.WriteLine("The full name is {0} {1}", firstName, lastName);


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1.TutorialLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables of different data types
            // initialize with a "default" value

            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // Assign some values
            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Forth Street";
            city = "Anytown";
            country = "MyCountry";
            birthDate = new DateTime(1932, 6, 1);

            // output to console windown
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // placeholder style
            Console.WriteLine("{0} years old.", age);

            // string concatenation
            Console.WriteLine(street + ", " + city + " ," + country);

            // string interpolation
            Console.WriteLine($"Born on {birthDate}");

        }
    }
}

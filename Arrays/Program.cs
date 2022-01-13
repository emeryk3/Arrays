using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* We can identify an array by the square brackets []
             * The below example will print out 'BMW' as it is the second string in the car array (as arrays start at 1).
             * Additionally, the numbers of values in the brackets (it’s currently 5) must match the array size, so if you added another car company, for example Honda, it would give a compile-time error. When you declare the array type like ‘string’ or ‘integer’, you cannot store a double or any other data type.*/

            /*
            string[] car = new string[5] { "Audi", "BMW", "Ferrari", "Dodge", "Lexus" };
            Console.WriteLine(car [1]); Console.ReadLine();
            */

            /* Looping through arrays
             * Using a foreach statement you can loop through an array and get all the values.*/

            /*
            string[] cars = new string[] { "Audi", "BMW", "Toyota", "Honda", "Lexus" };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
            */

            /* Sorting Arrays
             * Arrays can be sorted in order, either ascending or descending. You can use the sort() method to sort the array.
             * SYNTAX: Array.Sort(arrayname); */

            /*
            string[] cars = new string[] { "Audi", "BMW", "Toyota", "Honda", "Lexus" };

            Array.Sort(cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
            */

            // Sorting the arrays but in descending order.

            /*
            string[] cars = new string[] { "Audi", "BMW", "Toyota", "Honda", "Lexus" };

            Array.Sort(cars);
            Array.Reverse(cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
            */

            /* Array of any size:
             * In the above example the array has a size of 5, however you can create an array of any size.
             * SYNTAX: string[] <array name> =  {array items};
             * In the below example, the output is Snickers. */

            string[] chocolates = { "Snickers", "Bounty", "Twix", "Flake", "Twirl" };

            Console.WriteLine(chocolates[0]);
            Console.ReadLine(); // "Snickers"

        }
    }
}

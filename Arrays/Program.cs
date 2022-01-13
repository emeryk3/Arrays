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

            string[] car = new string[5] { "Audi", "BMW", "Ferrari", "Dodge", "Lexus" };
            Console.WriteLine(car [1]); Console.ReadLine();
        }
    }
}

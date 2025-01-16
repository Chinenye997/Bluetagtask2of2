using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluetagtask2of2
{
    class PythagoreanTheorem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pythagorean Theorem");
            Console.WriteLine("This is the Formula: a² + b² = c² ");

            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            // Calculate the hypotenuse using the Pythagorean theorem
            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadLine();
        }
    }
}

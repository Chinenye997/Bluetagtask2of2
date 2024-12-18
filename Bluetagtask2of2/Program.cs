using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluetagtask2of2
{

    /*PythagoreanTheorem Theorem = new PythagoreanTheorem();
    Theorem.*/
    class PythagoreanTheorem
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side C:");
            double c = Convert.ToDouble(Console.ReadLine());


            double d = Math.Sqrt((a * a) + (b * b) + (c * c));

            Console.WriteLine("The hypotenuse is:" + d);

            Console.ReadLine();
        }
    }
}

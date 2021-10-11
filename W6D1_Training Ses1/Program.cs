using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace W6D1_Training_Ses1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(12.65, 6.69);
            Console.WriteLine("Complex number is {0}" , complex1);

            Complex complex2 = new Complex(8, 4);
            Console.WriteLine("2nd Complex number is {0}", complex2);

            Console.WriteLine("sum of 2 complex number " + (complex1+complex2));

            Complex complex3 = new Complex(-1, 0);
            Console.WriteLine("Sqrt of complex number is " + Complex.Sqrt(complex3));
            Console.WriteLine("complex number in format" + complex2.Real + "+" + complex2.Imaginary + "i"));
            Console.WriteLine("complex number in string " + complex2.ToString());
            Console.ReadLine();
        }
    }
}

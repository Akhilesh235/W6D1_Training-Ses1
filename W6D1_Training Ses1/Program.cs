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
            BigInteger bigInteger = new BigInteger(178546464654.3654);
            Console.WriteLine(bigInteger);
            BigInteger bigInteger2 = new BigInteger(454646464646546);
            Console.WriteLine(bigInteger2);

            string str = "454646464646546";
            BigInteger bigInteger3 = BigInteger.Parse(str);
            Console.WriteLine("Value from string " + bigInteger3);


            Console.WriteLine("Power of big int is : " + BigInteger.Pow(bigInteger,3));
            Console.WriteLine("Add in big int is : " + BigInteger.Add(bigInteger,bigInteger2));
            Console.ReadLine();
            
            //Complex complex1 = new Complex(12.65, 6.69);
            //Console.WriteLine("Complex number is {0}" , complex1);

            //Complex complex2 = new Complex(8, 4);
            //Console.WriteLine("2nd Complex number is {0}", complex2);

            //Console.WriteLine("sum of 2 complex number " + (complex1+complex2));

            //Complex complex3 = new Complex(-1, 0);
            //Console.WriteLine("Sqrt of complex number is " + Complex.Sqrt(complex3));
            //Console.WriteLine("complex number in format" + complex2.Real + "+" + complex2.Imaginary + "i"));
            //Console.WriteLine("complex number in string " + complex2.ToString());
            //Console.ReadLine();
        }
    }
}

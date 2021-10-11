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

            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();

            Console.WriteLine("Equality check " + (guid1 == guid2));

            var bytes = new Byte[16];
            var guid3 = new Guid(bytes);
            Console.WriteLine($"guid value for " + guid3);

            var guid4 = Guid.Empty;
            Console.WriteLine("Equality check with empty guid " + (guid3 == Guid.Empty));

            for (int i=0; i<10;i++)
            {
                var guid = Guid.NewGuid();
                Console.WriteLine($"Guid value for {i+1}th iteration : " + guid);
            }
            Console.ReadLine();
            
            
            
            //BigInteger bigInteger3;
            //Console.WriteLine("Input first big int: ");
            //bigInteger3 = BigInteger.Parse(Console.ReadLine());
            //BigInteger bigInteger4;
            //Console.WriteLine("Input second big int: ");
            //bigInteger4 = BigInteger.Parse(Console.ReadLine());

            //Console.WriteLine("Addition of both big int is : " + BigInteger.Add(bigInteger3, bigInteger4));
            //Console.WriteLine("Subtraction of both big int is : " + BigInteger.Subtract(bigInteger3, bigInteger4));
            //Console.WriteLine("Multiplication of both big int is : " + BigInteger.Multiply(bigInteger3, bigInteger4));
            //Console.WriteLine("Division of both big int is : " + BigInteger.Divide(bigInteger3, bigInteger4));
            //Console.WriteLine("Remainder of both big int is : " + BigInteger.Remainder(bigInteger3, bigInteger4));
            //Console.ReadLine();

            //BigInteger bigInteger1 = new BigInteger (9090909009009009090);
            //BigInteger bigInteger2 = new BigInteger(10101010101010101010);
            //Console.WriteLine("Addition of both big int is : " + BigInteger.Add(bigInteger1, bigInteger2));
            //Console.WriteLine("Subtraction of both big int is : " + BigInteger.Subtract(bigInteger1, bigInteger2));
            //Console.WriteLine("Multiplication of both big int is : " + BigInteger.Multiply(bigInteger1, bigInteger2));
            //Console.WriteLine("Division of both big int is : " + BigInteger.Divide(bigInteger1, bigInteger2));
            //Console.WriteLine("Remainder of both big int is : " + BigInteger.Remainder(bigInteger1, bigInteger2));
            //Console.ReadLine();



            //BigInteger bigInteger = new BigInteger(178546464654.3654);
            //Console.WriteLine(bigInteger);
            //BigInteger bigInteger2 = new BigInteger(454646464646546);
            //Console.WriteLine(bigInteger2);

            //string str = "454646464646546";
            //BigInteger bigInteger3 = BigInteger.Parse(str);
            //Console.WriteLine("Value from string " + bigInteger3);


            //Console.WriteLine("Power of big int is : " + BigInteger.Pow(bigInteger,3));
            //Console.WriteLine("Add in big int is : " + BigInteger.Add(bigInteger,bigInteger2));
            //Console.ReadLine();

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

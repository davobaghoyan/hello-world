using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(6, -3);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Complex c3 = c1 + c2;
            Console.WriteLine(c3);
            c3 = c2 - c1;
            Console.WriteLine(c3);
            c3 = c1 * c2;
            Console.WriteLine(c3);
            c3 = c2 / c1;
            Console.WriteLine(c3);
            Console.WriteLine(c1.absolute_value());
            Console.WriteLine(c1.argument());
            Console.Read();

        }
    }
}

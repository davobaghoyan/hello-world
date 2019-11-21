using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrs
{
    class Complex
    {
        private double re;
        private double im;

        public double Real { get => re; set { this.re = value; } }
        public double Im { get => im; set { this.im = value; } }

       public  Complex ()
        { }

       public Complex (double x, double y )
        {
            re = x;
            im = y;
        }

        public static Complex operator+(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.re = a.re + b.re;
            result.im = a.im + b.im;
            return result;
        }

        public static Complex operator-(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.re = a.re - b.re;
            result.im = a.im - b.im;
            return result;
        }
     
        public static Complex operator* (Complex a, Complex b)
        {
            Complex result = new Complex();
            result.re = a.re * b.re + (a.im * b.im) * (-1);
            result.im = a.im * b.re + b.im * a.re;
            return result;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            Complex b1 = new Complex(b.re, -b.im);
            Complex k = b * b1;
            double d = k.re;
            Console.WriteLine(d);
            k = a * b1;
            Complex result = new Complex(k.re / d, k.im / d);
            return result;
        }

        public double absolute_value ()
        {
             double result = Math.Sqrt(this.re * this.re + this.im * this.im);
            return result;
        }

        public string argument ()
        {
            double tg = this.im / this.re;
            string arg = $"arctg   {tg}";
            return arg;
        }
        public override string ToString()
        {
            if (im > 0)
            return $"{re} + {im}i";
            return $"{re} - {-im}i";

        }
    }
}

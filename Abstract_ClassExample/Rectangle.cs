using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    class Rectangle : Shape
    {
        public Rectangle(double l,double b)
        {
            length = l;
            breadth = b;

        }
        public override void area()
        {
            double a;
            a = length * breadth;
            Console.WriteLine("Area of rectangle is " + a);
        }

        public override void perimeter()
        {
            double p;
            p = 2 * (length + breadth);
            Console.WriteLine("Perimeter of rectangle is " + p);
        }
    }
}

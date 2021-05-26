using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    class Circle : Shape
    {
       public Circle(double r)
        {
            radius = r;
        }

        public override void area()
        {
            double a;
            a = 3.14 * radius * radius;
            Console.WriteLine("Area of circle is " + a);
        }

        public override void perimeter()
        {
            double p;
            p = 2 * 3.14 * radius;
            Console.WriteLine("Perimeter is " + p);
        }

    }
}

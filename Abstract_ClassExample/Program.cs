using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Circle\n2.Rectangle");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("Enter radius of the circle");
                double rad = double.Parse(Console.ReadLine());
                Circle obj1 = new Circle(rad);
                obj1.area();
                obj1.perimeter();
            
            }
            if(n==2)
            {
                Console.WriteLine("Enter length and breadth of the rectangle");
                double l = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Rectangle obj2 = new Rectangle(l, b);
                obj2.area();
                obj2.perimeter();
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = int.Parse(Console.ReadLine());
            int p, q, r, s;
            Calc(num1, num2, out p, out q, out r, out s);
            Console.WriteLine("Addition is " + p);
            Console.WriteLine("Subtraction is " + q);
            Console.WriteLine("Multiplication is " + r);
            Console.WriteLine("Division is " + s);
            Console.Read();

        }
        public static void Calc(int a,int b,out int c,out int d,out int e,out int f)
        {
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFactorial
{
    class Program 
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any number");
            num = int.Parse(Console.ReadLine());
            Program obj = new Program();
            int fact = obj.GetFact(num);
            Console.WriteLine("Factorial is " + fact);
            Console.Read();
        }


            public int GetFact(int n)
            {
                int fact=1;
                while (n!=0)
                {
                    fact = fact * n;
                    n--;
                }
                return fact;
            }
        
        }
    }


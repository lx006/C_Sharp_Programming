using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            char ch = 'A';
            for ( i = 1; i <= 5; i++)
            {
                for ( j = 1; j <= i ; j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine("\n");

            }
            Console.Read();
        }
    }
}

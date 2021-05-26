using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingExample
{
    class Class2
    {
        public void display()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Class 2 starts");
                Thread.Sleep(1000);
            }
           
        }
    }
}

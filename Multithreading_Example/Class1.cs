using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingExample
{
    class Class1
    {
        public void show()
        {
            for(int i=1;i<10;i++)
            {
                Console.WriteLine("Class 1 starts");
                Thread.Sleep(1000);
            }
        }
    }
}

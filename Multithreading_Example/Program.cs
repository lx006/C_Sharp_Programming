using System;
using System.Threading;

namespace MultithreadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();


            Thread T1 = new Thread(obj1.show);
            Thread T2 = new Thread(obj2.display);

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            Console.WriteLine("Main ends");
            Console.Read();
        }
    }
}

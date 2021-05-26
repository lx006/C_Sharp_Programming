using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter size");
            size = int.Parse(Console.ReadLine());

            int[] a = new int[size];

            Program obj = new Program();

            int large = obj.GetSecLarg(a);
            Console.WriteLine("The secondmost largest element in the list is " + large);
            Console.Read();
        }

        public int GetSecLarg(int []arr)
        {
            Console.WriteLine("Enter elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max1 = arr[0];
            int max2 = arr[0];
            for (int j = 1; j < arr.Length; j++)
            {
                if (max1<arr[j])
                {
                    max1 = arr[j];
                }
            } 
           for (int j = 1; j< arr.Length; j++)
           {
                if(arr[j]>max2 && arr[j]<max1)
                {
                    max2 = arr[j];
                }
            }
            return max2;
        }
    }
}

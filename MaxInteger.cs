using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign2
{
    internal class MaxInteger
    {
        public void Max(int[] arr)
        {
            int max;
            max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if(max<arr[i])
                {
                    max= arr[i];

                }

            }
            Console.WriteLine($"Max integer in array is {max}");

        }

        static void Main()
        {
            int size;
            Console.WriteLine("Enter Size of array");
            size = int.Parse(Console.ReadLine());
            MaxInteger m = new MaxInteger();
            int[] arr = new int[size];
            Console.WriteLine("Enter Numbers:");
            for(int i =0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()) ;
            }
            m.Max(arr);

        }
    }
}

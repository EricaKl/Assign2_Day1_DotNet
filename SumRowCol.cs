using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign2
{
    internal class SumRowCol
    {
        public void ColWise(int[,]arr1 ,int row, int col)
        {
            //int[,] arr3 = new int[1,3];
            int [] sum = new int[10];
            for(int i = 0; i < row; i++)
            {
                sum[i] = 0;
                for(int j=0; j<col;j++)
                {
                    sum[i] += arr1[j,i];

                }
                
            }
            Console.WriteLine("Column Wise Sum");
            for(int i = 0; i < row;i++)
            {
                Console.Write(sum[i] + " ");
            }
         Console.WriteLine();
        }

        public void RowWise(int[,] arr1,int row, int col)
        {
            int[] sum = new int[10];
            for (int i = 0; i < row; i++)
            {
                sum[i] = 0;
                for (int j = 0; j < col; j++)
                {
                    sum[i] += arr1[i,j];

                }

            }
            Console.WriteLine("Row Wise Sum");
            for (int i = 0; i < row; i++)
            {
                Console.Write(sum[i] + " ");
            }

        }

        static void Main()
        {
            int row, col;
            Console.WriteLine("Enter Size of Rows");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Size of Cols");
            col = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[row, col];
            int[,] arr2 = new int[row, col];

            Console.WriteLine("Enter Array1:");
            for(int i=0; i<row; i++)
            {
                for(int j =0; j<col; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }

            }
            //Console.WriteLine("Enter Array2:");
            //for (int i=0;i<row; i++)
            //{
            //    for(int j =0; j < col; j++)
            //    {
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            SumRowCol s = new SumRowCol();
            s.ColWise(arr1, row , col);
            s.RowWise(arr1, row, col);
        }
    }
}

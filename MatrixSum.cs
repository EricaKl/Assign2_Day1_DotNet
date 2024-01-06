using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign2
{
    internal class MatrixSum
    {
        public void SumMatrix(int[,]arr1, int[,]arr2, int row, int col)
        {
            int[,] sum = new int[3, 3];
            for(int i = 0; i < row; i++)
            {
                for(int j =0; j<row; j++)
                {
                    sum[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("Sum of 3 X 3 matrix is");
            for(int i = 0; i<row;i++)
            {
                for(int j =0; j<col; j++)
                {
                    Console.Write(sum[i,j] + " ");
                   // Console.Write("\n"); 
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int row = 3;
            int col = 3;
            int [,]arr1= new int[row, col];
            int [,]arr2= new int[row, col];
            Console.WriteLine("Enter First Matrix");
            for(int  i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    arr1[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Second Matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            MatrixSum m = new MatrixSum();
            m.SumMatrix(arr1, arr2, row , col);


        }
    }
}

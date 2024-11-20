using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace pascal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            for(int a = 0; i<5; i++)
            {
                for(int j = 10; k > i; k--)
                {
                     Console.Write("t");
                }
                
                for(int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j-1] + arr[i - 1, j];
                    }
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}

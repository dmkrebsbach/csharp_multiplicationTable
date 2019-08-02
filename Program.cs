using System;
using System.Collections.Generic;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication Table
            int[,] multiplicationTable = new int[11,11];
            for (int i=1; i<=10; i++)
                {
                for (int j=1; j<=10; j++)
                {
                    multiplicationTable[i,j]=i*j;
                    if (i*j < 10)
                    {
                        Console.Write(multiplicationTable[i,j]+"  "); // tableformatting for single digit numbers
                    }
                    else
                    {
                        Console.Write(multiplicationTable[i,j]+" "); // table formatting for double digit numbers
                    }
                }
                Console.WriteLine(); // starts next line for i once first pass-through of j is completed
            }
        }
    }
}

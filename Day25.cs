using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Console.WriteLine("Say Daxil Edin:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Elementleri Daxil Edin");
        for (int i = 0; i<n; i++)
        {
            int elementOfArray = int.Parse(Console.ReadLine());
            array[i] = elementOfArray;
        }
        int primaryTester = 0;
        for (int i = 0; i<n; i++)
        {
            for (int j = 2; j<Math.Sqrt(array[i]); j++)
            {
                if (array[i]%j==0)
                {
                    primaryTester++;
                }
            }
            if(primaryTester>0)
            {
                Console.WriteLine("Not prime");
                primaryTester=0;
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
        Console.ReadKey();
    }
}
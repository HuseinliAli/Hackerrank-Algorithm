using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int StringNumber=int.Parse(Console.ReadLine());
        for(int i = 0; i<StringNumber; i++)
        {
            string formatting = Console.ReadLine();
            StringSplit(formatting);
        }
        Console.ReadKey();
    }
    static void StringSplit(string formatting)
    {
        string odd = "";
        string even = "";
        for (int i = 0; i<formatting.Length; i++)
        {
            if (i%2==0)
            {
                odd+=formatting[i];
            }
        }
        for (int i = 0; i<formatting.Length; i++)
        {
            if (i%2!=0)
            {
                even+=formatting[i];
            }
        }
        Console.WriteLine(odd+" "+even);
        
    }
}
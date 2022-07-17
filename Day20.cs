﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        int swaps = 0;
        int firstElement;
        int lastElement;
        int swapElement;
        for (int i = 0; i<a.Count; i++)
        {
            for (int j = 0; j<a.Count-1; j++)
            {
                if (a[j]>a[j+1])
                {
                    swapElement=a[j];
                    a[j]=a[j+1];
                    a[j+1]=swapElement;

                    swaps++;
                }
            }
        }
        Console.WriteLine("Array sorted in "+swaps+"swaps.");
        Console.WriteLine("First Element: "+a[0]);
        Console.WriteLine("Last Element: "+a[a.Count-1]);
        Console.ReadKey();
    }
}

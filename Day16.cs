using System.CodeDom.Compiler;
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
        int S;
        try
        {
            S=int.Parse(Console.ReadLine());
            Console.WriteLine(S);
        }
        catch (FormatException) 
        {
            Console.WriteLine("Bad String");
        }
        Console.ReadKey();
        
    }
}

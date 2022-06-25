using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positives = 0, negatives = 0, zeroes = 0;
        for (int i = 0; i<arr.Count; i++)
        {
            if (arr[i]>0)
            {
                positives++;
            }
            else if (arr[i]==0)
            {
                zeroes++;
            }
            else if (arr[i]<0)
            {
                negatives++;
            }
        }
        double positivePart = positives/arr.Count;
        double negativePart = negatives/arr.Count;
        double zeroPart = zeroes/arr.n;
        Console.WriteLine($"{positivePart:F6}");
        Console.WriteLine($"{negativePart:F6}");
        Console.WriteLine($"{zeroPart:F6}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

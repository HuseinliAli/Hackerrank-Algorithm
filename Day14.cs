using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] arr)
    {
        this.elements=arr;
    }
    public void computeDifference()
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 0; i<elements.Length; i++)
        {
            if (elements[i]>max)
            {
                max=elements[i];
            }
        }
        for (int i = 0; i<elements.Length; i++)
        {
            if (elements[i]<min)
            {
                min=elements[i];
            }
        }
        maximumDifference=max-min;
    }
} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
        Console.ReadKey();
    }
}
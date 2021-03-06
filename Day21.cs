using System;

class Printer
{

	/**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
	// Write your code here
	static void PrintArray<T>(T[] arrays)
	{
		for(int i=0;i<arrays.Length;i++)
        {
            Console.WriteLine(arrays[i]);
        }
	}

	static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] intArray = new int[n];
		for (int i = 0; i < n; i++)
		{
			intArray[i] = Convert.ToInt32(Console.ReadLine());
		}

		n = Convert.ToInt32(Console.ReadLine());
		string[] stringArray = new string[n];
		for (int i = 0; i < n; i++)
		{
			stringArray[i] = Console.ReadLine();
		}

		PrintArray<int>(intArray);
        PrintArray<string>(stringArray);
	}
}
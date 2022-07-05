using System;
using System.Linq;

class Person
{
	protected string firstName;
	protected string lastName;
	protected int id;

	public Person() { }
	public Person(string firstName, string lastName, int identification)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = identification;
	}
	public void printPerson()
	{
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
	}
}

class Student : Person
{
	private int[] testScores;

	/*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
	// Write your constructor here
	public Student(string nm,string lstnm,int dntf,int[] score):base(nm,lstnm,dntf) { 
		this.testScores = score;
	}
	/*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
	// Write your method here
	public char Calculate()
    {
		int sum = 0;
		int avarage = 0;
		int elementS = 0;
		for(int i=0;i<testScores.Length;i++)
        {
			sum+=testScores[i];
        }
		elementS=testScores.Length;
		avarage=sum/elementS;

		if (avarage>=90&&avarage<=100)
		{
			return 'O';
		}
		else if (avarage>=80&&avarage<90)
		{ return 'E'; }
			
		else if (avarage>=70&&avarage<80)
		{ return 'A'; }
			
		else if (avarage>=55&&avarage<70)
		{ return 'P'; }

		else if (avarage>=40&&avarage<55)
		{
			return 'D';
		}
			
		else if (avarage<40)
        {
			return 'T';
		}
			

    }
}

class Solution
{
	static void Main()
	{
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
		string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
		int[] scores = new int[numScores];
		for (int i = 0; i < numScores; i++)
		{
			scores[i]= Convert.ToInt32(inputs[i]);
		}

		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
		Console.ReadKey();
	}
}
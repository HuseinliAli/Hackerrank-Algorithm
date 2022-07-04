using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterOfOne=0;
            int counterOfTwo=0;
            while(n!=0)
            {
                if(n%2==1)
                {
                    counterOfOne++;
                    if(counterOfOne>counterOfTwo)
                    {
                        counterOfTwo=counterOfOne;
                    }
                }
                else
                {
                    counterOfOne=0;
                }
                n/=2;
            }
            Console.WriteLine(counterOfTwo);
            Console.ReadKey();
        }
    }
}

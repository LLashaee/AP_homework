using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int n=int.Parse(Console.ReadLine());
            
            
             if (IsPrime(n))
                { 
                    Console.WriteLine($"{n} is prime number");
                }
            else { Console.WriteLine($"{n} is not a prime number :"); }
            
        }
        static bool IsPrime(int n)
        {
            int mid = n / 2;
            if (n<=1)
                { return false; }
            for (int i = 2;i<mid;i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

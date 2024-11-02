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
            Console.WriteLine("enter start number: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("enter end number :");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine($"palindrome numbers between {n} and {m}");
            for (int i = n; i <= m; i++)
            {
                if (Ispalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool Ispalindrome(int n)
        {
            string number=n.ToString();
            int len=number.Length;
            for (int i = 0;i < len / 2;i++)
            {
                if (number[i] != number[len-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

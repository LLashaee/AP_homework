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
            string input = @"Hello, my phone number is 0123456789, my address is rue Voltaire 145.  
the number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any question 
the number 012345678 is not valid anymore. Contact the number 0999999888 if you have any question 
Our customer care representatives are available to assist you 24 hours a day, 7 days a week on : 0000000000, 9999999999 and 0777778899 ";
            Console.WriteLine("شماره‌های معتبر:");

                for (int i = 0; i < input.Length - 10; i++)
                {
                    if (char.IsDigit(input[i]) && input[i] == '0')
                    {
                        string possibleNumber = input.Substring(i, 10);

                        if (IsTenDigitNumber(possibleNumber) && HasTwoDifferentDigits(possibleNumber))
                        {
                            Console.WriteLine(possibleNumber);
                        }
                    }
                }
            }
            static bool IsTenDigitNumber(string number)
            {
                if (number.Length != 10) return false;
                foreach (char c in number)
                {
                    if (!char.IsDigit(c)) return false;
                }
                return true;
            }
            static bool HasTwoDifferentDigits(string number)
            {
                char firstDigit = number[0];
                foreach (char digit in number)
                {
                    if (digit != firstDigit)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
            
            
            
 }
    


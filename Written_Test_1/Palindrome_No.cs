using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Written_Test_1
{

    //Find out given number is palindrome or not
    internal class PalindromeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int temp = num;

            while (num > 0)
            {

                int remainder = num % 10;

                reverse = reverse * 10 + remainder;

                num = num / 10;

            }

            if (reverse == temp)
            {
                Console.WriteLine(reverse + " is palindrome number");
            }
            else
            {
                Console.WriteLine(reverse + " is not palindrome number");
            }

        }
    }
}

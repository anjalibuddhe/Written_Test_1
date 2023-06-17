using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Written_Test_1
{
    // Find sum of all digits of a number.
    internal class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0,opt;
            while(num > 0)
            {
                opt = num% 10;
                sum=sum+opt;
                num = num/10;

            }
            Console.WriteLine("Sum of all digits of a number is "+ sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Check if given number is Armstrong or not.
namespace Written_Test_1
{
    internal class ArmstrongNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num =Convert.ToInt32(Console.ReadLine());

            int temp = num, rev=0,r;

            while(num > 0)
            {
                r = num % 10;
                rev = rev + (r * r * r);
                num = num / 10;
            }
            if(temp == rev)
            {
                Console.WriteLine("It is Armstrong No");
            }
            else
            {
                Console.WriteLine("It is Not Armstrong No");
            }
        }
    }
}

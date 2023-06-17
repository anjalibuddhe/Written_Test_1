using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Written_Test_1
{
    internal class PrimeNo
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                }

            }
            if(count == 2)
            {
                Console.WriteLine("Prime Number");

            }
            else
            {
                Console.WriteLine(num + "Not a Prime Number");
            }

        }
    }
}

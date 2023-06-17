using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k. where k < n . n is entered by user
namespace Written_Test_1
{
    internal class FiboSeries
    {
        static void Main(string[] args)
        {
            int x = 0,y = 1,z;
            Console.WriteLine("Enter the number you want to print Fibonacci series");
            int n=Convert.ToInt32(Console.ReadLine());

            for (int k = 2; k < n; k++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
        }
    }
}

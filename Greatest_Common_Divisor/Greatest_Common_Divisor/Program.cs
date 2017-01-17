using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int GCD = 1;

            for(int i=1; i<=Math.Max(num1, num2); i++)
            {
                if(num1%i==0 && num2 % i == 0)
                {
                    GCD = i;
                }
            }
            Console.WriteLine(GCD);
        }
    }
}

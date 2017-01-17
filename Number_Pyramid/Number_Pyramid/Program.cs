using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for(int row=1; row<=n; row++)
            {
                for(int col=1; col<=row; col++)
                {
                    if (num <= n)
                    {
                        Console.Write(num+" ");
                        num += 1;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

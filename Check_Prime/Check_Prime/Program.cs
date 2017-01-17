using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int cout = 0;

            for(int i=1; i<=num; i++)
            {
                if(num%i==0)
                {
                    cout += 1;
                }
            }
            if(cout>2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }

        }
    }
}

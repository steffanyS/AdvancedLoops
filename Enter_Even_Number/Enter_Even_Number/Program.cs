using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter even number: ");
            int num = int.Parse(Console.ReadLine());

            while(num%2!=0)
            {
                Console.WriteLine("Invalid Number!");
                Console.Write("Enter even number: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even number entered: "+num);
        }
    }
}

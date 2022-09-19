using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeZeroProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            { 
                Console.WriteLine("Number is Postive");
            }
            else if (n < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
            Console.ReadLine();
        }
    }
}

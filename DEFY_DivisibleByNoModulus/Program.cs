using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEFY_DivisibleByNoModulus
{
    class Program
    {
        static void Main(string[] args)
        {
            //EsDivisiblePor11
            if (DivisibleNoModulus.EsDivisiblePor11("12345678901234567900"))
            {
                Console.WriteLine("El número 12345678901234567900 es divisible por 11");
            }


        }
    }
}

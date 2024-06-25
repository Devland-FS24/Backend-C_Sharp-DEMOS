using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEFY_StringMagicTricks;

namespace DEFY_StringMagicTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //BEGIN REVERSE EXERCISE
            //string comingin= "Hola";
            //Console.WriteLine(comingin);
            ////comingin = Console.ReadLine();
            //comingin = MagicTricks.Reverse(comingin);
            //Console.WriteLine(comingin);
            //// pause
            //Console.ReadLine();
            //END REVERSE EXERCISE

            //COUNT NUMBER OCURRENCES
            const int SIZE = 16;
            int[] numbers = new int[SIZE] { 214, 214, 214, 21, 3, 5, 9, 1056, 1056, 14, 14, 14, 14, 14, 14, 256 };
            var dictionary = new Dictionary<int, int>();
            var numbersWithFour = new List<int>();

            foreach (var number in numbers)
            {
                if (dictionary.ContainsKey(number))
                    dictionary[number]++;
                else
                    dictionary.Add(number, 1);
            }

            foreach (var val in dictionary)
            {

                numbersWithFour.Add(val.Value);
                numbersWithFour.Add(val.Key);

            }
            //END COUNT NUMBER OCCURRENCES
            Console.WriteLine("Finished!");
        }
    }
}

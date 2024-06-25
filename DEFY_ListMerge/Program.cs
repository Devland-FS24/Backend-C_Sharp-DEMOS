using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEFY_ListMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            var listB = new List<int> { 3, 4, 5 };
            var listA = new List<int> { 1, 2, 3, 4, 5 };
            var listFinal = new List<int>();

            int pos = 0;

            while(pos < listB.Count && pos <listA.Count)
            {
                listFinal.Add(listB[pos]);
                listFinal.Add(listA[pos]);
                pos++;
            }

            if(pos < listB.Count)
            {
                while (pos < listB.Count)
                {
                    listFinal.Add(listB[pos]);
                    pos++;
                }
            }

            if (pos < listA.Count)
            {
                while (pos < listA.Count)
                {
                    listFinal.Add(listA[pos]);
                    pos++;
                }
            }


        }
    }
}

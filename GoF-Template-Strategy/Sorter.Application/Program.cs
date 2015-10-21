using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Template_Strategy;

namespace Sorter.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayGenerator hat = new RandomArrayGenerator(10000, 20);
            ArrayGenerator topHat = new NearlySortedArray(10, 20);

            var nearlySortet = topHat.NewArray();
            var unsorted = hat.NewArray();

            ISuperSorter bubble = new BubbleSort();

            var sorted = bubble.Sort(nearlySortet);

            foreach (var item in nearlySortet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("The sorting took: " + bubble.ElapsedTime + " MiliSeconds!");
            Console.ReadKey();
        }
    }

    class SortAll
    {
        
    }
}

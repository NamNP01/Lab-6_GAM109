using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 5, 6, 7, 8, 1 };

            Console.WriteLine("Union (giảm dần): ");
            var unionDescending = list1.Union(list2).OrderByDescending(x => x);
            foreach (var item in unionDescending)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nIntersect: ");
            var intersect = list1.Intersect(list2);
            foreach (var item in intersect)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nConcat (tăng dần): ");
            var conCat = list1.Concat(list2).OrderBy(x => x);
            foreach (var item in conCat)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nExcept: ");
            var Except = list1.Except(list2);
            foreach (var item in Except)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
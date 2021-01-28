using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorting
{
    public static class QuickSorting
    {
        public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            Console.WriteLine("Quick sorting");

            if (!list.Any())
            {
                return Enumerable.Empty<T>();
            }
            var pivot = list.First();
            var smaller = list.Skip(1).Where(item => item.CompareTo(pivot) <= 0).QuickSort();
            var larger = list.Skip(1).Where(item => item.CompareTo(pivot) > 0).QuickSort();

            return smaller.Concat(new[] { pivot }).Concat(larger);
        }
    }
}

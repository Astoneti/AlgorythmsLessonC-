using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorting
{
    public class InsertionSorting
    {
        public static int[] Sort(int[] array)
        {
            Console.WriteLine("Insertion sort");

            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }

            return array;
        }
    }
}

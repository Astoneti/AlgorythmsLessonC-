using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorting
{
    public static class ComboSorting
    {
        public static int[] Sort(int[] array)
        {
            Console.WriteLine("Combo sorting");
            double gap = array.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < array.Length)
                {
                    int igap = i + (int)gap;
                    if (array[i] > array[igap])
                    {
                        int swap = array[i];
                        array[i] = array[igap];
                        array[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
            return array;
        }
    }
}

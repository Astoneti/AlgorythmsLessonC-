using ConsoleApp1.Sorting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack/Queue

            // Stack
            //Stack<int> stackInstance = new Stack<int>();

            //stackInstance.Push(100);
            //stackInstance.Push(200);
            //stackInstance.Push(300);

            //while (stackInstance.Count > 0)
            //{
            //    int a = stackInstance.Pop();
            //    Console.WriteLine(a);
            //}

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(100);
            //queue.Enqueue(200);
            //queue.Enqueue(300);

            //while (queue.Count > 0)
            //{
            //    int a = queue.Dequeue();
            //    Console.WriteLine(a);
            //}

            //LinkedList<int> linkedList = new LinkedList<int>();      

            #endregion Stack/Queue

            #region Array Sorting

            var array = CreateArray();
            PrintArray(array);

            //// bubble
            //var sortedarray = Sorting.BubbleSorting.DescendingSort(array);
            //PrintArray(sortedarray);

            ////Shake
            //var sortedArray = Sorting.ShakerSorting.Sort(array);
            //PrintArray(sortedArray);

            ////Combo sort
            //var sortedArray = Sorting.ComboSorting.Sort(array);
            //PrintArray(sortedArray);

            ////Insertion sort
            var sortedArray = Sorting.InsertionSorting.Sort(array);
            PrintArray(sortedArray);


            //Quick sorting
            //var sortedArray = array.QuickSort<int>();
            //PrintArray(sortedArray.ToArray());

            #endregion
        }

        private static int[] CreateArray()
        {
            return new int[10] { 100, 1, 4, 121, 100, 3, 400, 45, 56, 6 };
        }

        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static LinkedList<int> CreateLinkedList()
        {
            var list
                = new LinkedList<int>();

            list.AddLast(1000);
            list.AddLast(1);
            list.AddLast(4);
            list.AddLast(121);
            list.AddLast(10);
            list.AddLast(5);
            list.AddLast(221);
            return list;
        }

        private static void ShowLinkedListItems(LinkedList<int> linkedList)
        {
            LinkedListNode<int> node = linkedList.First;

            while (node != null)
            {
                Console.WriteLine(node.Value.ToString());

                node = node.Next;
            }
        }
    }
}

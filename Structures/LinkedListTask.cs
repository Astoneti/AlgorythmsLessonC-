using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Structures
{
    public class LinkedListTask
    {
        private LinkedList<int> _linkedList;

        public LinkedListTask(LinkedList<int> linkedList)
        {
            _linkedList = linkedList;
        }

        public LinkedList<int> Convert(int number)
        {
            var node = _linkedList.First;

            while (node != null)
            {
                if (node.Value <  number)
                {

                }
                else
                {

                }
            }

            throw new NotImplementedException();
        }
    }
}

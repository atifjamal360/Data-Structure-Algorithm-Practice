using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class node
    {
        public int info;
        public node prev;
        public node link;
        public node(int x)
        {
            info = x;
            prev = null;
            link = null;
        }
    }
}

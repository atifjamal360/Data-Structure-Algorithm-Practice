using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementationOfStack
{
    class node
    {
        public int info;
        public node link;
        public node(int data)
        {
            info = data;
            link = null;
        }
    }
}

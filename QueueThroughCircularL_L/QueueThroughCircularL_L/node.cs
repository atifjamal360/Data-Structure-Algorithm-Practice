using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueThroughCircularL_L
{
    class node
    {
        public int info;
        public node link;
        public node(int x)
        {
            info = x;
            link = null;
        }
    }
}

using System;

namespace priorityQuene
{
    class node
    {
        public int priority;
        public int info;
        public node link;
        public node(int info, int priority)
        {
            this.info = info;
            this.priority = priority;
            link = null;
        }
    }
}

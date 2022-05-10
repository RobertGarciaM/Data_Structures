using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public class StackLinkedListNode
    {
        public int element;
        public StackLinkedListNode next;

        public StackLinkedListNode(int e, StackLinkedListNode n)
        {
            element = e;
            next = n;
        }
    }

    class StacksLinked
    {
        StackLinkedListNode top;
        int size;

        public StacksLinked()
        {
            top = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void push(int e) // Order O(1)
        {
            StackLinkedListNode newest = new StackLinkedListNode(e, null);
            if (isEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }
            size = size + 1;
        }

        public int pop() // Order O(1)
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int e = top.element;
            top = top.next;
            size = size - 1;
            return e;
        }

        public int peek() // Order O(1)
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return top.element;
        }

        public void display()
        {
            StackLinkedListNode p = top;
            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }     
    }
}

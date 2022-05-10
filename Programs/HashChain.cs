using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public class HashChain
    {
        int hashtablesize;
        LinkedListHash[] hashtable;

        public HashChain()
        {
            hashtablesize = 10;
            hashtable = new LinkedListHash[hashtablesize];
            for (int i = 0; i < hashtablesize; i++)
                hashtable[i] = new LinkedListHash();
        }

        public int hashcode(int key)
        {
            return key % hashtablesize;
        }

        public void insert(int element)
        {
            int i = hashcode(element);
            hashtable[i].insertsorted(element);
        }

        public bool search(int key)
        {
            int i = hashcode(key);
            return hashtable[i].search(key) != -1;
        }

        public void display()
        {
            for (int i = 0; i < hashtablesize; i++)
            {
                Console.Write("[" + i + "]");
                hashtable[i].display();
            }
            Console.WriteLine();
        }       
    }

    public class NodeHash
    {
        public int element;
        public NodeHash next;
        public NodeHash(int e, NodeHash n)
        {
            element = e;
            next = n;
        }
    }

    public class LinkedListHash
    {
        private NodeHash head;
        private NodeHash tail;
        private int size;

        public LinkedListHash()
        {
            head = null;
            tail = null;
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

        public void addlast(int e)
        {
            NodeHash newest = new NodeHash(e, null);
            if (isEmpty())
                head = newest;
            else
                tail.next = newest;
            tail = newest;
            size = size + 1;
        }

        public void addFirst(int e)
        {
            NodeHash newest = new NodeHash(e, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size = size + 1;
        }

        public void addAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            NodeHash newest = new NodeHash(e, null);
            NodeHash p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }

        public void insertsorted(int e)
        {
            NodeHash newest = new NodeHash(e, null);
            if (isEmpty())
                head = newest;
            else
            {
                NodeHash p = head;
                NodeHash q = head;
                while (p != null && p.element < e)
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size = size + 1;
        }

        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int e = head.element;
            head = head.next;
            size = size - 1;
            if (isEmpty())
                tail = null;
            return e;
        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            NodeHash p = head;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i = i + 1;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size = size - 1;
            return e;
        }

        public int removeAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            NodeHash p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size = size - 1;
            return e;
        }

        public int search(int key)
        {
            NodeHash p = head;
            int index = 0;
            while (p != null)
            {
                if (p.element == key)
                    return index;
                p = p.next;
                index = index + 1;
            }
            return -1;
        }

        public void display()
        {
            NodeHash p = head;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public int sum()
        {
            NodeHash p = head;
            int total = 0;
            while (p != null)
            {
                total = total + p.element;
                p = p.next;
            }
            return total;
        }

        public int maxelement()
        {
            NodeHash p = head;
            int max = -1;
            while (p != null)
            {
                if (p.element > max)
                    max = p.element;
                p = p.next;
            }
            return max;
        }

    }
}

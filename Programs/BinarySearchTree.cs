using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    public class NodeBinarySearchTree
    {
        public int element;
        public NodeBinarySearchTree left;
        public NodeBinarySearchTree right;

        public NodeBinarySearchTree(int e, NodeBinarySearchTree l, NodeBinarySearchTree r)
        {
            element = e;
            left = l;
            right = r;
        }
    }

    public class BinarySearchTree
    {
        public NodeBinarySearchTree root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void insert(NodeBinarySearchTree temproot, int e)
        {
            NodeBinarySearchTree temp = null;
            while (temproot != null)
            {
                temp = temproot;
                if (e == temproot.element)
                    return;
                else if (e < temproot.element)
                    temproot = temproot.left;
                else if (e > temproot.element)
                    temproot = temproot.right;
            }
            NodeBinarySearchTree n = new NodeBinarySearchTree(e, null, null);
            if (root != null)
            {
                if (e < temp.element)
                    temp.left = n;
                else
                    temp.right = n;
            }
            else
                root = n;
        }

        public NodeBinarySearchTree recursiveInsert(NodeBinarySearchTree temproot, int e)
        {
            if (temproot != null)
            {
                if (e < temproot.element)
                    temproot.left = recursiveInsert(temproot.left, e);
                else if (e > temproot.element)
                    temproot.right = recursiveInsert(temproot.right, e);
            }
            else
            {
                NodeBinarySearchTree n = new NodeBinarySearchTree(e, null, null);
                temproot = n;
            }
            return temproot;
        }

        public void inorder(NodeBinarySearchTree temproot)
        {
            if (temproot != null)
            {
                inorder(temproot.left);
                Console.Write(temproot.element + " ");
                inorder(temproot.right);
            }
        }

        public void preorder(NodeBinarySearchTree temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.element + " ");
                preorder(temproot.left);
                preorder(temproot.right);
            }
        }

        public void postorder(NodeBinarySearchTree temproot)
        {
            if (temproot != null)
            {
                postorder(temproot.left);
                postorder(temproot.right);
                Console.Write(temproot.element + " ");
            }
        }

        public void levelorder()
        {
            QueuesLinkedTree q = new QueuesLinkedTree();
            NodeBinarySearchTree t = root;
            Console.Write(t.element + " ");
            q.enqueue(t);
            while (!q.isEmpty())
            {
                t = (NodeBinarySearchTree)q.dequeue();
                if (t.left != null)
                {
                    Console.Write(t.left.element + " ");
                    q.enqueue(t.left);
                }
                if (t.right != null)
                {
                    Console.Write(t.right.element + " ");
                    q.enqueue(t.right);
                }
            }
        }

        public bool search(int key)
        {
            NodeBinarySearchTree temproot = root;
            while (temproot != null)
            {
                if (key == temproot.element)
                    return true;
                else if (key < temproot.element)
                    temproot = temproot.left;
                else if (key > temproot.element)
                    temproot = temproot.right;
            }
            return false;
        }

        public bool delete(int e)
        {
            NodeBinarySearchTree p = root;
            NodeBinarySearchTree pp = null;
            while (p != null && p.element != e)
            {
                pp = p;
                if (e < p.element)
                    p = p.left;
                else
                    p = p.right;
            }
            if (p == null)
                return false;
            if (p.left != null && p.right != null)
            {
                NodeBinarySearchTree s = p.left;
                NodeBinarySearchTree ps = p;
                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                p.element = s.element;
                p = s;
                pp = ps;
            }
            NodeBinarySearchTree c = null;
            if (p.left != null)
                c = p.left;
            else
                c = p.right;
            if (p == root)
                root = null;
            else
            {
                if (p == pp.left)
                    pp.left = c;
                else
                    pp.right = c;
            }
            return true;
        }

        public int count(NodeBinarySearchTree temproot)
        {
            if (temproot != null)
            {
                int x = count(temproot.left);
                int y = count(temproot.right);
                return x + y + 1;
            }
            return 0;
        }

        public int height(NodeBinarySearchTree temproot)
        {
            if (temproot != null)
            {
                int x = height(temproot.left);
                int y = height(temproot.right);
                if (x > y)
                    return x + 1;
                else
                    return y + 1;
            }
            return 0;
        }

        public bool recursiveSearch(NodeBinarySearchTree temproot, int key)
        {
            if (temproot != null)
            {
                if (key == temproot.element)
                    return true;
                else if (key < temproot.element)
                    return recursiveSearch(temproot.left, key);
                else if (key > temproot.element)
                    return recursiveSearch(temproot.right, key);
            }
            return false;
        }
    }

    public class QNode
    {
        public Object element;
        public QNode next;
        public QNode(Object e)
        {
            element = e;
            next = null;
        }
    }

    class QueuesLinkedTree
    {
        QNode front;
        QNode rear;
        int size;

        public QueuesLinkedTree()
        {
            front = null;
            rear = null;
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

        public void enqueue(Object e)
        {
            QNode newest = new QNode(e);
            if (isEmpty())
                front = newest;
            else
                rear.next = newest;
            rear = newest;
            size = size + 1;
        }

        public Object dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            Object e = front.element;
            front = front.next;
            size = size - 1;
            if (isEmpty())
                rear = null;
            return e;
        }       

        public void display()
        {
            QNode p = front;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }

    }
}

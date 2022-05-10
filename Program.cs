using Data_Structure.Programs;
using System;

namespace Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Recursive
            Recursion.calculateIterative(4);
            Recursion.calculateRecursive(4);
            Recursion.tailRecursion(4); // the output expected is 16, 9, 4, 1
            Recursion.headRecursion(4); // the output expected is 1, 4, 9, 16
            Recursion.treeRecursion(4);
      
            Console.WriteLine("Sum: " + SumofNumbers.sumn(5));
            Console.WriteLine("Sum: " + SumofNumbers.sumniteration(5));
            Console.WriteLine("Sum: " + SumofNumbers.sumnrecursion(5));

            Console.WriteLine("Factorial: " + Factorial.factorialiterative(5));
            Console.WriteLine("Factorial: " + Factorial.factorialrecursive(5));
            #endregion

            #region Search

            #region Linear Search O(n)
            int[] A = { 84, 21, 47, 96, 15 };
            int found = LinearSearch.linearSearch(A, 5, 96);
            Console.WriteLine("Result: Linear Search " + found);
            #endregion

            #region Binary Search  O(Log(n))
            // Array should be sorted         
            int[] array = { 15, 21, 47, 84, 96 };
            BinarySearch.binarySearch(array, 5, 96);
            Console.WriteLine("Result Binary Search: " + found);
            #endregion

            #region Binary Search Recursive O(Log(n))
            // Array should be sorted  
            int[] arrayR = { 15, 21, 47, 84, 96 };
            BinarySearch.binarySearch(arrayR, 5, 96);
            Console.WriteLine("Result Binary Search Recursive: " + found);
            #endregion

            #endregion

            #region Sorting

            #region Selection Sort ( Comparision O(n a la 2) Swapping O(n))
            int[] arrayToSS = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array Selection Sort: ");
            SelectionSort.display(arrayToSS, 6);
            SelectionSort.OrderBySelectionSort(arrayToSS, 6);
            Console.WriteLine("Sorted Array Selection Sort");
            SelectionSort.display(arrayToSS, 6);
            #endregion

            #region Insertion Sort (Comparision O(n a la 2) Swapping O(n a la 2))
            int[] arrayIS = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array Insertion Sort: ");
            InsertionSort.display(arrayIS, 6);
            InsertionSort.insertionSort(arrayIS, 6);
            Console.WriteLine("Sorted Array Insertion Sort:");
            InsertionSort.display(arrayIS, 6);
            #endregion

            #region Bubble Sort ( Comparision O(n a la 2) Swapping O(n a la 2))
            int[] arraryB = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array Bubble Sort:");
            BubbleSort.display(arraryB, 6);
            BubbleSort.bubbleSort(arraryB, 6);
            Console.WriteLine("Sorted Array Bubble Sort:");
            BubbleSort.display(arraryB, 6);          
            #endregion

            #region Shell Sort ( Comparision O(n log(n)))
            int[] arraySShort = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array Shell Sort: ");
            ShellSort.display(arraySShort, 6);
            ShellSort.shellSort(arraySShort, 6);
            Console.WriteLine("Sorted Array Shell Sort:");
            ShellSort.display(arraySShort, 6);
            #endregion

            #region Merge Sort ( Comparision O(n log(n)))
            int[] arrayMS = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array Merge Sort: ");
            MergeSort.display(arrayMS, 6);
            MergeSort.mergeSort(arrayMS, 0, 5);
            Console.WriteLine("Sorted Array Merge Sort: ");
            MergeSort.display(arrayMS, 6);
            #endregion

            #region Quick Sort O(n2)
            int[] arrayQS = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array Quick Sort:");
            QuickSort.display(arrayQS, 6);
            QuickSort.quickSort(arrayQS, 0, 5);
            Console.WriteLine("Sorted Array Quick Sort:");
            QuickSort.display(arrayQS, 6);
            #endregion

            #endregion

            #region Linked List
            LinkedList l = new LinkedList();
            //l.addLast(7);
            //l.addLast(4);
            //l.addFirst(8);
            //l.addLast(12);
            //l.addLast(24);
            //l.addLast(72);
            //l.addFirst(3);                     
            //l.addAny(20, 3);
            //l.addAny(40, 5);
            l.insertsorted(7);
            l.insertsorted(4);
            l.insertsorted(12);
            l.insertsorted(8);
            l.insertsorted(3);
            l.insertsorted(30);
            l.insertsorted(25);
            l.display();
            Console.WriteLine("Size: " + l.length());           
            int element = l.removeFirst();
            Console.WriteLine("Removed Element: " + element);
            int elementLast = l.removeLast();
            Console.WriteLine("Removed Element Last: " + elementLast);
            int elementPossition = l.removeAny(3);
            Console.WriteLine("Removed Element at position 3: " + elementPossition);
            int position = l.search(12);
            Console.WriteLine("Result searching: " + position);
            l.display();
            Console.WriteLine("Size: " + l.length());
            #endregion

            #region Circular liked list
            CircularLinkedList cl = new CircularLinkedList();
            cl.addLast(7);
            cl.addLast(4);
            cl.addLast(12);
            cl.display();
            Console.WriteLine("Circular Linked List Size: " + cl.length());
            cl.addLast(8);
            cl.addLast(3);
            cl.display();
            Console.WriteLine("Circular Linked List Size: " + cl.length());
            cl.addFirst(35);
            cl.display();
            Console.WriteLine("Circular Linked List Size: " + cl.length());
            cl.addAny(30, 5);
            cl.display();
            Console.WriteLine("Circular Linked List Size: " + cl.length());
            int elementCl = cl.removeFirst();
            Console.WriteLine("Removed Element Circular Linked List: " + elementCl);
            cl.display();
            Console.WriteLine("Circular Linked List Size: " + cl.length());
            int elementCLL = cl.removeLast();
            Console.WriteLine("Removed Element: " + elementCLL);
            cl.display();
            Console.WriteLine("Circular Linked List Size: " + cl.length());
            int elementRa = cl.removeAny(3);
            Console.WriteLine("Removed Element: " + elementRa);
            cl.display();
            Console.WriteLine("Circular Linked List Size: " + cl.length());

            #endregion

            #region Double Circular Linked List
            DoublyLinkedList dcl = new DoublyLinkedList();
            dcl.addLast(7);
            dcl.addLast(4);
            dcl.addLast(12);
            dcl.display();
            Console.WriteLine("Double Circular Linked List Size: " + dcl.length());
            dcl.addLast(8);
            dcl.addLast(3);
            dcl.display();
            Console.WriteLine("Double Circular Linked List Size: " + dcl.length());
            dcl.addFirst(15);
            dcl.display();
            dcl.addAny(20, 3);
            dcl.display();
            int elementdcl = dcl.removeFirst();
            Console.WriteLine("Removed Element First: " + elementdcl);
            dcl.display();
            int elementdcll = dcl.removeLast();
            Console.WriteLine("Removed Element Last: " + elementdcll);
            dcl.display();
            int elementdcla = dcl.removeAny(3);
            Console.WriteLine("Removed Element: " + elementdcla);
            dcl.display();
            Console.WriteLine("Double Circular Linked List Size: " + dcl.length());
            #endregion

            #region Stacks LIFO Array
            Console.WriteLine("Stacks LIFO");
            StacksArray s = new StacksArray(10);
            s.push(5);
            s.push(3);
            s.display();
            Console.WriteLine("Size: " + s.length());
            Console.WriteLine("Element Popped: " + s.pop());
            Console.WriteLine("IsEmpty: " + s.isEmpty());
            Console.WriteLine("Element Popped: " + s.pop());
            Console.WriteLine("IsEmpty: " + s.isEmpty());
            s.push(7);
            s.push(9);
            s.display();
            Console.WriteLine("Element Top: " + s.peek());
            s.display();
            #endregion

            #region Stacks LIFO Linked List
            Console.WriteLine("Stacks LIFO Linked List");
            StacksLinked sl = new StacksLinked();
            sl.push(5);
            sl.push(3);
            sl.display();
            Console.WriteLine("Size: " + sl.length());
            Console.WriteLine("Element Removed: " + sl.pop());
            Console.WriteLine("IsEmpty: " + sl.isEmpty());
            Console.WriteLine("Element Removed: " + sl.pop());
            Console.WriteLine("IsEmpty: " + sl.isEmpty());
            sl.push(7);
            sl.push(9);
            sl.display();
            Console.WriteLine("Element Top: " + sl.peek());
            sl.display();
            #endregion

            #region Queues Using Array
            QueuesArray q = new QueuesArray(10);
            q.enqueue(5);
            q.enqueue(3);
            q.display();
            Console.WriteLine("Size Queue: " + q.length());
            Console.WriteLine("Element Removed Queue: " + q.dequeue());
            Console.WriteLine("IsEmpty Queue: " + q.isEmpty());
            Console.WriteLine("Element Removed Queue: " + q.dequeue());
            Console.WriteLine("IsEmpty Queue: " + q.isEmpty());
            q.enqueue(7);
            q.enqueue(9);
            q.enqueue(4);
            q.display();
            Console.WriteLine("Size Queue: " + q.length());
            #endregion

            #region Queues Using Linked List
            QueuesLinked ql = new QueuesLinked();
            ql.enqueue(5);
            ql.enqueue(3);
            ql.display();
            Console.WriteLine("Size ql: " + ql.length());
            Console.WriteLine("Element Removed ql: " + ql.dequeue());
            Console.WriteLine("IsEmpty ql: " + ql.isEmpty());
            Console.WriteLine("Element Removed ql: " + ql.dequeue());
            Console.WriteLine("IsEmpty ql: " + ql.isEmpty());
            ql.enqueue(7);
            ql.enqueue(9);
            ql.enqueue(4);
            ql.display();
            Console.WriteLine("Size ql: " + ql.length());
            #endregion

            #region Queues DeQuesLinked
            DeQueLinked dlq = new DeQueLinked();
            dlq.addFirst(5);
            dlq.addFirst(3);
            dlq.addlast(7);
            dlq.addlast(12);
            dlq.display();
            Console.WriteLine("Size dlq: " + dlq.length());
            Console.WriteLine("Front Element Removed dlq: " + dlq.removeFirst());
            Console.WriteLine("Rear Element Removed: " + dlq.removeLast());
            dlq.display();
            Console.WriteLine("First Element dlq: " + dlq.first());
            Console.WriteLine("Last Element dlq: " + dlq.last());
            #endregion

            #region Binary Serach Tree
            BinarySearchTree B = new BinarySearchTree();
            B.insert(B.root, 50);
            B.insert(B.root, 30);
            B.insert(B.root, 80);
            B.insert(B.root, 10);
            B.insert(B.root, 40);
            B.insert(B.root, 60);
            B.insert(B.root, 90);

            // Also I can use a recursive insertion like this
            //B.recursiveInsert(B.root, 30);
            //B.recursiveInsert(B.root, 80);
            //B.recursiveInsert(B.root, 10);
            //B.recursiveInsert(B.root, 40);
            //B.recursiveInsert(B.root, 60);
            //B.recursiveInsert(B.root, 90);


            Console.WriteLine("Inorder Traversal");
            B.inorder(B.root);
            Console.WriteLine("Pre Order Traversal");
            B.preorder(B.root);
            Console.WriteLine("Post Order Traversal");
            B.postorder(B.root);
            Console.WriteLine("Level Order Traversal");
            B.levelorder();

            Console.WriteLine("Search Result: " + B.search(60));
            Console.WriteLine("Recursive Search Result: " + B.recursiveSearch(B.root, 60));

            B.delete(60);
            Console.WriteLine("Inorder Traversal");
            B.inorder(B.root);

            Console.WriteLine("Number of Node: " + B.count(B.root));
            Console.WriteLine("Height: " + (B.height(B.root) - 1));

            #endregion

            #region Hasing Region 
            HashChain h = new HashChain();
            h.insert(54);
            h.insert(78);
            h.insert(64);
            h.insert(92);
            h.insert(34);
            h.insert(86);
            h.insert(28);
            h.display();
            Console.WriteLine("Element Found Hasing: " + h.search(86));
            #endregion

            #region HashLinearProbe
            HashLinearProbe hlp = new HashLinearProbe();
            hlp.insert(54);
            hlp.insert(78);
            hlp.insert(64);
            hlp.insert(92);
            hlp.insert(34);
            hlp.insert(86);
            hlp.insert(28);
            hlp.display();
            Console.WriteLine("Element Found HashLinearProbe: " + hlp.search(86));
            #endregion

            #region Granphs Undirected
            Graphs_Undirected g = new Graphs_Undirected(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edges Count: " + g.edgeCount());
            g.insertEdge(0, 1, 1);
            g.insertEdge(0, 2, 1);
            g.insertEdge(1, 0, 1);
            g.insertEdge(1, 2, 1);
            g.insertEdge(2, 0, 1);
            g.insertEdge(2, 1, 1);
            g.insertEdge(2, 3, 1);
            g.insertEdge(3, 2, 1);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edges Count: " + g.edgeCount());
            g.edges();
            Console.WriteLine("Edge between 1--3: " + g.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
            Console.WriteLine("Degree of Vertex 2: " + g.indegree(2));
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            g.removeEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
            #endregion

            #region Graphs Weighted Undirected
            Graphs_Weighted_Undirected guw = new Graphs_Weighted_Undirected(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            guw.display();
            Console.WriteLine("Vertices: " + guw.vertexCount());
            Console.WriteLine("Edges Count: " + guw.edgeCount());
            guw.insertEdge(0, 1, 26);
            guw.insertEdge(0, 2, 16);
            guw.insertEdge(1, 0, 26);
            guw.insertEdge(1, 2, 12);
            guw.insertEdge(2, 0, 16);
            guw.insertEdge(2, 1, 12);
            guw.insertEdge(2, 3, 8);
            guw.insertEdge(3, 2, 8);
            Console.WriteLine("Graphs Adjacency Matrix:");
            guw.display();
            Console.WriteLine("Vertices: " + guw.vertexCount());
            Console.WriteLine("Edges Count: " + guw.edgeCount());
            guw.edges();
            Console.WriteLine("Edge between 1--3: " + guw.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + guw.existEdge(1, 2));
            Console.WriteLine("Degree of Vertex 2: " + guw.indegree(2));
            Console.WriteLine("Graphs Adjacency Matrix:");
            guw.display();
            guw.removeEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix:");
            guw.display();
            Console.WriteLine("Edge between 1--2: " + guw.existEdge(1, 2));
            #endregion

            #region Direct Graph Implementation
            Direct_Graph dg = new Direct_Graph(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            dg.display();
            Console.WriteLine("Vertices: " + dg.vertexCount());
            Console.WriteLine("Edges Count: " + dg.edgeCount());
            dg.insertEdge(0, 1, 1);
            dg.insertEdge(0, 2, 1);
            dg.insertEdge(1, 2, 1);
            dg.insertEdge(2, 3, 1);
            Console.WriteLine("Graphs Adjacency Matrix:");
            dg.display();
            Console.WriteLine("Vertices: " + dg.vertexCount());
            Console.WriteLine("Edges Count: " + dg.edgeCount());
            dg.edges();
            Console.WriteLine("Edge between 1--3: " + dg.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + dg.existEdge(1, 2));
            Console.WriteLine("Edge between 2--1: " + dg.existEdge(2, 1));
            Console.WriteLine("Degree of Vertex 2: " + (dg.indegree(2) + dg.outdegree(2)));
            Console.WriteLine("In-Degree of Vertex 2: " + dg.indegree(2));
            Console.WriteLine("Out-Degree of Vertex 2: " + dg.outdegree(2));

            Console.WriteLine("Graphs Adjacency Matrix:");
            dg.display();
            dg.removeEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix:");
            dg.display();
            Console.WriteLine("Edge between 1--2: " + dg.existEdge(1, 2));
            #endregion

            #region Weighted Graph
            WeightedDirectedGraph wdg = new WeightedDirectedGraph(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            wdg.display();
            Console.WriteLine("Vertices: " + wdg.vertexCount());
            Console.WriteLine("Edges Count: " + wdg.edgeCount());
            wdg.insertEdge(0, 1, 26);
            wdg.insertEdge(0, 2, 16);
            wdg.insertEdge(1, 2, 12);
            wdg.insertEdge(2, 3, 8);
            Console.WriteLine("Graphs Adjacency Matrix:");
            wdg.display();
            Console.WriteLine("Vertices: " + wdg.vertexCount());
            Console.WriteLine("Edges Count: " + wdg.edgeCount());
            g.edges();
            Console.WriteLine("Edge between 1--3: " + wdg.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + wdg.existEdge(1, 2));
            Console.WriteLine("Edge between 2--1: " + wdg.existEdge(2, 1));
            Console.WriteLine("Degree of Vertex 2: " + (wdg.indegree(2) + wdg.outdegree(2)));
            Console.WriteLine("In-Degree of Vertex 2: " + wdg.indegree(2));
            Console.WriteLine("Out-Degree of Vertex 2: " + wdg.outdegree(2));

            Console.WriteLine("Graphs Adjacency Matrix:");
            wdg.display();
            wdg.removeEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix:");
            wdg.display();
            Console.WriteLine("Edge between 1--2: " + wdg.existEdge(1, 2));
            #endregion

            #region BFSGraph
            BFSGraphs bfg = new BFSGraphs(7);
            bfg.insertEdge(0, 1, 1);
            bfg.insertEdge(0, 5, 1);
            bfg.insertEdge(0, 6, 1);
            bfg.insertEdge(1, 0, 1);
            bfg.insertEdge(1, 2, 1);
            bfg.insertEdge(1, 5, 1);
            bfg.insertEdge(1, 6, 1);
            bfg.insertEdge(2, 3, 1);
            bfg.insertEdge(2, 4, 1);
            bfg.insertEdge(2, 6, 1);
            bfg.insertEdge(3, 4, 1);
            bfg.insertEdge(4, 2, 1);
            bfg.insertEdge(4, 5, 1);
            bfg.insertEdge(5, 2, 1);
            bfg.insertEdge(5, 3, 1);
            bfg.insertEdge(6, 3, 1);
            Console.WriteLine("Breadth First Search:");
            bfg.BFS(0);
            #endregion

            #region DFSGraphs
            DFSGraphs dfsg = new DFSGraphs(7);
            dfsg.insertEdge(0, 1, 1);
            dfsg.insertEdge(0, 5, 1);
            dfsg.insertEdge(0, 6, 1);
            dfsg.insertEdge(1, 0, 1);
            dfsg.insertEdge(1, 2, 1);
            dfsg.insertEdge(1, 5, 1);
            dfsg.insertEdge(1, 6, 1);
            dfsg.insertEdge(2, 3, 1);
            dfsg.insertEdge(2, 4, 1);
            dfsg.insertEdge(2, 6, 1);
            dfsg.insertEdge(3, 4, 1);
            dfsg.insertEdge(4, 2, 1);
            dfsg.insertEdge(4, 5, 1);
            dfsg.insertEdge(5, 2, 1);
            dfsg.insertEdge(5, 3, 1);
            dfsg.insertEdge(6, 3, 1);
            Console.WriteLine("Depth First Search:");
            dfsg.DFS(0);
            #endregion

            Console.ReadKey();
        }
    }
}

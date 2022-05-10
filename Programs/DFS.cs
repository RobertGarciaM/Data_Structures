using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Programs
{
    internal class DFSGraphs
    {
        int vertices;
        int[,] adjMat;
        int[] visited;

        public DFSGraphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n];
            visited = new int[vertices];
        }

        public void insertEdge(int u, int v, int x)
        {
            adjMat[u, v] = x;
        }

        public void removeEdge(int u, int v)
        {
            adjMat[u, v] = 0;
        }

        public bool existEdge(int u, int v)
        {
            return adjMat[u, v] != 0;
        }

        public int vertexCount()
        {
            return vertices;
        }

        public int edgeCount()
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjMat[i, j] != 0)
                        count = count + 1;
            }
            return count;
        }

        public void edges()
        {
            Console.WriteLine("Edges:");
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjMat[i, j] != 0)
                        Console.WriteLine(i + "--" + j);
            }
        }

        public int outdegree(int v)
        {
            int count = 0;
            for (int j = 0; j < vertices; j++)
                if (adjMat[v, j] != 0)
                    count = count + 1;
            return count;
        }

        public int indegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
                if (adjMat[i, v] != 0)
                    count = count + 1;
            return count;
        }

        public void display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    Console.Write(adjMat[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public void DFS(int s)
        {
            if (visited[s] == 0)
            {
                Console.Write(s + " ");
                visited[s] = 1;
                for (int j = 0; j < vertices; j++)
                    if (adjMat[s, j] == 1 && visited[j] == 0)
                        DFS(j);
            }
        }
    }
}

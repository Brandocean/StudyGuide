using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graph;

class GraphM
{
    private int[,] adjacencyMatrix;
    private int numNodes;

    public GraphM(int numNodes)
    {
        this.numNodes = numNodes;
        adjacencyMatrix = new int[numNodes, numNodes];
    }

    public void AddEdge(int from, int to)
    {
        if (from >= 0 && from < numNodes && to >= 0 && to < numNodes)
        {
            adjacencyMatrix[from, to] = 1;
        }
    }

    public void RemoveEdge(int from, int to)
    {
        if (from >= 0 && from < numNodes && to >= 0 && to < numNodes)
        {
            adjacencyMatrix[from, to] = 0;
        }
    }

    public bool HasEdge(int from, int to)
    {
        if (from >= 0 && from < numNodes && to >= 0 && to < numNodes)
        {
            return adjacencyMatrix[from, to] == 1;
        }
        return false;
    }

    public void Transpose()
    {
        for (int i = 0; i < numNodes; i++)
        {
            for (int j = 0; j < i; j++)
            {
                // Swap the values to transpose the matrix
                (adjacencyMatrix[j, i], adjacencyMatrix[i, j]) = (adjacencyMatrix[i, j], adjacencyMatrix[j, i]);
            }
        }
    }

    public void PrintGraph()
    {
        for (int i = 0; i < numNodes; i++)
        {
            for (int j = 0; j < numNodes; j++)
            {
                Console.Write(adjacencyMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void BFS(int startNode)
    {
        bool[] visited = new bool[numNodes];
        Queue<int> queue = new();

        visited[startNode] = true;
        queue.Enqueue(startNode);

        while (queue.Count > 0)
        {
            int currentNode = queue.Dequeue();
            Console.Write(currentNode + " ");

            for (int i = 0; i < numNodes; i++)
            {
                if (adjacencyMatrix[currentNode, i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
    }

    public void DFS(int startNode)
    {
        bool[] visited = new bool[numNodes];
        DFSRecursive(startNode, visited);
    }

    private void DFSRecursive(int currentNode, bool[] visited)
    {
        visited[currentNode] = true;
        Console.Write(currentNode + " ");

        for (int i = 0; i < numNodes; i++)
        {
            if (adjacencyMatrix[currentNode, i] == 1 && !visited[i])
            {
                DFSRecursive(i, visited);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graph;

class Node
{
    public int Value { get; }
    public List<int> AdjacentNodes { get; }

    public Node(int value)
    {
        Value = value;
        AdjacentNodes = new List<int>();
    }
}

class GraphA
{
    private List<Node> nodes;

    public GraphA(int numNodes)
    {
        nodes = new List<Node>();
        for (int i = 0; i < numNodes; i++)
        {
            nodes.Add(new Node(i));
        }
    }

    public void AddEdge(int from, int to)
    {
        if (from >= 0 && from < nodes.Count && to >= 0 && to < nodes.Count)
        {
            nodes[from].AdjacentNodes.Add(to);
        }
    }

    public void RemoveEdge(int from, int to)
    {
        if (from >= 0 && from < nodes.Count)
        {
            nodes[from].AdjacentNodes.Remove(to);
        }
    }

    public bool HasEdge(int from, int to)
    {
        if (from >= 0 && from < nodes.Count)
        {
            return nodes[from].AdjacentNodes.Contains(to);
        }
        return false;
    }

    public void Transpose()
    {
        List<Node> newNodes = new();
        foreach (var node in nodes)
        {
            newNodes.Add(new Node(node.Value));
        }

        for (int i = 0; i < nodes.Count; i++)
        {
            foreach (var neighbor in nodes[i].AdjacentNodes)
            {
                newNodes[neighbor].AdjacentNodes.Add(i);
            }
        }

        nodes = newNodes;
    }

    public void PrintGraph()
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            Console.Write($"Node {i}: ");
            foreach (var neighbor in nodes[i].AdjacentNodes)
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }

    public void BFS(int startNode)
    {
        bool[] visited = new bool[nodes.Count];
        Queue<int> queue = new();

        visited[startNode] = true;
        queue.Enqueue(startNode);

        while (queue.Count > 0)
        {
            int currentNode = queue.Dequeue();
            Console.Write(currentNode + " ");

            foreach (var neighbor in nodes[currentNode].AdjacentNodes)
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    public void DFS(int startNode)
    {
        bool[] visited = new bool[nodes.Count];
        DFSRecursive(startNode, visited);
    }

    private void DFSRecursive(int currentNode, bool[] visited)
    {
        visited[currentNode] = true;
        Console.Write(currentNode + " ");

        foreach (var neighbor in nodes[currentNode].AdjacentNodes)
        {
            if (!visited[neighbor])
            {
                DFSRecursive(neighbor, visited);
            }
        }
    }
}

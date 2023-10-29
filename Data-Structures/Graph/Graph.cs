using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graph;

using System;
using System.Collections.Generic;

public class Graph<T>
{
    private Dictionary<T, List<T>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<T, List<T>>();
    }

    public void AddVertex(T vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<T>();
        }
    }

    public void AddEdge(T source, T destination)
    {
        if (!adjacencyList.ContainsKey(source))
        {
            throw new ArgumentException("Source vertex does not exist in the graph.");
        }

        if (!adjacencyList.ContainsKey(destination))
        {
            throw new ArgumentException("Destination vertex does not exist in the graph.");
        }

        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source); // For an undirected graph
    }

    public List<T> GetNeighbors(T vertex)
    {
        if (adjacencyList.ContainsKey(vertex))
        {
            return adjacencyList[vertex];
        }
        else
        {
            throw new ArgumentException("Vertex does not exist in the graph.");
        }
    }

    public bool HasVertex(T vertex)
    {
        return adjacencyList.ContainsKey(vertex);
    }

    public bool HasEdge(T source, T destination)
    {
        if (!adjacencyList.ContainsKey(source) || !adjacencyList.ContainsKey(destination))
        {
            return false;
        }

        return adjacencyList[source].Contains(destination);
    }

    public void RemoveVertex(T vertex)
    {
        if (adjacencyList.ContainsKey(vertex))
        {
            adjacencyList.Remove(vertex);
            foreach (var otherVertex in adjacencyList.Keys)
            {
                adjacencyList[otherVertex].Remove(vertex);
            }
        }
    }

    public void RemoveEdge(T source, T destination)
    {
        if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
        {
            adjacencyList[source].Remove(destination);
            adjacencyList[destination].Remove(source);
        }
    }
}


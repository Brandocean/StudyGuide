using Graph;

internal class Program
{
    private static void Main(string[] args)
    {

        //! Adjacency List
        GraphA graphA = new (5);

        graphA.AddEdge(0, 1);
        graphA.AddEdge(0, 2);
        graphA.AddEdge(1, 3);
        graphA.AddEdge(2, 4);

        //Console.WriteLine("Original Graph:");
        //graph.PrintGraph();

        //! BFS & DFS Adjacency List
        // Console.WriteLine("BFS starting from node 0:");
        // graphA.BFS(0);
        // Console.WriteLine("\nDFS starting from node 0:");
        // graphA.DFS(0);

        //! Adjacency Matrix

        int numNodes = 5;
        GraphM graphM = new (numNodes);

        graphM.AddEdge(0, 1);
        graphM.AddEdge(0, 2);
        graphM.AddEdge(1, 3);
        graphM.AddEdge(2, 4);

        //Console.WriteLine("Original Graph:");   
        //graphM.PrintGraph();

        //! BFS & DFS Adjacency Matrix
        // Console.WriteLine("BFS starting from node 0:");
        // graphM.BFS(0);
        // Console.WriteLine("\nDFS starting from node 0:");
        // graphM.DFS(0);
    }
}

// Insertion of Nodes/Edges in the graph – Insert a node into the graph.
// Deletion of Nodes/Edges in the graph – Delete a node from the graph.
// Searching on Graphs – Search an entity in the graph.
// Traversal of Graphs – Traversing all the nodes in the graph.
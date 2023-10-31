using Tree;

internal class Program
{
    private static void Main(string[] args)
    {
        BinaryTree binaryTree = new();

        binaryTree.root = new Node(1);
        binaryTree.root.Left = new Node(2);
        binaryTree.root.Right = new Node(3);

        binaryTree.Insert(4);

        //binaryTree.PreOrderTraversal();

        MaxHeap maxHeap = new();

        maxHeap.Insert(100);
        maxHeap.Insert(40);
        maxHeap.Insert(50);
        maxHeap.Insert(10);
        maxHeap.Insert(15);
        maxHeap.Insert(50);
        maxHeap.Insert(40);

        //maxHeap.PrintHeap();
    }
    
}


//* Trees demand more memory space requirements
//* Tree offer Efficient Searching
//* Ancenstors and descendants

//* The height of the complete binary tree is always logn
//* The time complexity would also be O(logn)

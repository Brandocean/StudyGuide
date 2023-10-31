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

        binaryTree.PreOrderTraversal();
    }
    
}


//* Trees demand more memory space requirements
//* Tree offer Efficient Searching
//* Ancenstors and descendants

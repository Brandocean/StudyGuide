using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree;

using System;
class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{

    public Node root;

    public BinaryTree(int data)
    {
        root = new Node(data);
    }

    public BinaryTree()
    {
        root = null;
    }

    public bool IsEmpty()
    {
        return root == null;
    }

    public void Insert(int data)
    {
        root = Insert(root, data);
    }

    private Node Insert(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
        }
        else if (data < root.Data)
        {
            root.Left = Insert(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = Insert(root.Right, data);
        }
        return root;
    }

    public void Delete(int data)
    {
        root = Delete(root, data);
    }

    private Node Delete(Node root, int data)
    {
        if (root == null)
        {
            return root;
        }

        if (data < root.Data)
        {
            root.Left = Delete(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = Delete(root.Right, data);
        }
        else
        {
            // Nodo con un solo hijo o sin hijos
            if (root.Left == null)
            {
                return root.Right;
            }
            else if (root.Right == null)
            {
                return root.Left;
            }

            // Nodo con dos hijos, encontrar el sucesor inorden (el nodo más pequeño en el subárbol derecho)
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = Delete(root.Right, root.Data);
        }
        return root;
    }

    private static int MinValue(Node root)
    {
        int minValue = root.Data;
        while (root.Left != null)
        {
            minValue = root.Left.Data;
            root = root.Left;
        }
        return minValue;
    }


    public bool Search(int data)
    {
        return Search(root, data);
    }

    private bool Search(Node root, int data)
    {
        if (root == null)
        {
            return false;
        }
        if (data == root.Data)
        {
            return true;
        }
        else if (data < root.Data)
        {
            return Search(root.Left, data);
        }
        else
        {
            return Search(root.Right, data);
        }
    }

    public void InOrderTraversal()
    {
        InOrderTraversal(root);
    }

    private void InOrderTraversal(Node root)
    {
        if (root != null)
        {
            InOrderTraversal(root.Left);
            Console.Write(root.Data + " ");
            InOrderTraversal(root.Right);
        }
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversal(root);
    }

    private void PreOrderTraversal(Node root)
    {
        if (root != null)
        {
            Console.Write(root.Data + " ");
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }
    }

    public void PostOrderTraversal()
    {
        PostOrderTraversal(root);
    }

    private void PostOrderTraversal(Node root)
    {
        if (root != null)
        {
            PostOrderTraversal(root.Left);
            PostOrderTraversal(root.Right);
            Console.Write(root.Data + " ");
        }
    }

    public void LevelOrderTraversal()
    {
        if (root == null)
        {
            Console.WriteLine("El árbol está vacío.");
            return;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Data + " ");

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }

        Console.WriteLine();
    }
}

//? Auxiliary Operations On Binary Tree:
//* Finding the height of the tree
//* Find the level of the tree
//* Finding the size of the entire tree.

//? Depth-First Search
//* - Preorder Traversal: root – left child – right child
//* - Inorder Traversal: left child – root – right child
//* - Postorder Traversal: left child – right child - root

//? Breadth-First Search
//* Level Order Traversal : Visit nodes level-by-level and left-to-righ



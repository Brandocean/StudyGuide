using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree;

using System;

class BinaryTree
{
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

    private Node root;

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

    private int MinValue(Node root)
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
}


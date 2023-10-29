internal class Program
{
    private static void Main(string[] args)
    {
        //! Declaracion
        LinkedList<int> myList = new LinkedList<int>();

        //! Metodos

        //* Agrega un elemento al principio de la lista.
        myList.AddFirst(17);

        //* Agrega un elemento al final de la lista.
        myList.AddLast(42);

        //* Elimina la primera instancia del valor especificado.
        //myList.Remove(42);

        //*  Elimina el primer elemento de la lista.
        //myList.RemoveFirst();

        //* Elimina el último elemento de la lista.
        //myList.RemoveLast();

        //* Obtiene el primer elemento de la lista.
        int firstItem = myList.First.Value;

        //* Obtiene el último elemento de la lista.
        int lastItem = myList.Last.Value;

        //* Borra todos los elementos de la lista.
        //myList.Clear();

        //* Determina si un elemento específico se encuentra en la lista enlazada. 
        bool contains17 = myList.Contains(17);

        //* Foreach
        foreach (var item in myList)
        {
            //Console.WriteLine(item);
        }

        //* Agrega un nuevo nodo después de un nodo existente en la lista.
        LinkedList<string> myList2 = new LinkedList<string>();
        LinkedListNode<string> node1 = myList2.AddLast("Manzana");
        LinkedListNode<string> node2 = myList2.AddLast("Banana");
        LinkedListNode<string> newNode = myList2.AddAfter(node1, "Cereza");
        // La lista ahora es: Manzana -> Cereza -> Banana

        //* Se utiliza para buscar el primer nodo que cumple con un predicado especificado.
        LinkedListNode<string> foundNode = myList2.Find("Banana"); // Si no lo encuentra es NULL
        //System.Console.WriteLine(foundNode.Value);

        //! Propiedades

        //* Obtiene el número de elementos en la lista.
        int count = myList.Count;
        
        //! Propiedades de los nodos

        //* Gets the next node in the LinkedList<T>
        //System.Console.WriteLine(node1.Next.Value); // El value es para ver el valor

        //* Gets the previous node in the LinkedList<T>.
        //System.Console.WriteLine(node1.Previous.Value); // El value es para ver el valor

        //* Gets the value contained in the node.
        //System.Console.WriteLine(node1.Value);
    }
}
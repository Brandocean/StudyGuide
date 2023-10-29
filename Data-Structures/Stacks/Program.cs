internal class Program
{
    private static void Main(string[] args)
    {
        //! Declaracion

        Stack<int> miPila = new Stack<int>();

        //! Metodos

        //* Agrega un elemento al tope de la pila.
        miPila.Push(42);

        //* Elimina y devuelve el elemento en la parte superior de la pila.
        //int elementoEliminado = miPila.Pop();

        //* Devuelve el elemento en la parte superior de la pila sin eliminarlo.
        int elementoSuperior = miPila.Peek();

        //* Verifica si un elemento está en la pila.
        bool contieneElemento = miPila.Contains(42);

        //* Elimina todos los elementos de la pila.
        //miPila.Clear();

        //* Convierte la pila en un arreglo.
        int[] arreglo = miPila.ToArray();

        //! Propiedades

        //*Devuelve el número de elementos en la pila.
        int cantidadElementos = miPila.Count;

    }
}
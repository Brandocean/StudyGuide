internal class Program
{
    private static void Main(string[] args)
    {
        //! Declaracion
        Queue<int> miCola = new Queue<int>();

        //! Metodos

        //* Agrega un elemento al final de la cola.
        miCola.Enqueue(5);
        miCola.Enqueue(10);

        //* Remueve y devuelve el elemento al principio de la cola.
        int primerElemento = miCola.Dequeue(); // Valor de primerElemento será 5

        //* Devuelve el elemento al principio de la cola sin eliminarlo.
        int primerElemento2 = miCola.Peek(); // Valor de primerElemento será 10

        //* Elimina todos los elementos de la cola.
        //miCola.Clear(); // La cola estará vacía.

        //* Verifica si un elemento está en la cola.
        bool contiene = miCola.Contains(10); // Valor de contiene será true

        //* Convierte la cola en un array.
        int[] arreglo = miCola.ToArray();

        //! Propiedades

        //* Propiedad que devuelve la cantidad de elementos en la cola.
        int cantidadElementos = miCola.Count; // Valor de cantidadElementos será 1

    }
}
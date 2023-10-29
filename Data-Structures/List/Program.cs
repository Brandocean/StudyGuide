using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //! Declaration

        List<int> numeros = new List<int>();

        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        //! Methods

        //* Insert(int index, T item): Insertar un elemento en la posición especificada.
        List<int> numeros2 = new List<int> { 1, 2, 4, 5 };
        numeros2.Insert(2, 3); //? La lista ahora contiene: 1, 2, 3, 4, 5
        //numeros2.ForEach(x => System.Console.WriteLine(numeros2));;

        //* Remove(T item): Eliminar la primera ocurrencia del elemento especificado.
        List<string> frutas = new List<string> { "Manzana", "Plátano", "Naranja", "Manzana" };
        frutas.Remove("Manzana"); //? La lista ahora contiene: Plátano, Naranja, Manzana

        //* Sort(): Ordenar la lista.
        List<int> numeros3 = new List<int> { 5, 2, 8, 1, 9 };
        numeros3.Sort(); //? La lista ahora contiene: 1, 2, 5, 8, 9

        //* Contains(T item): Verificar si un elemento está presente en la lista.
        List<string> colores = new List<string> { "Rojo", "Verde", "Azul" };
        bool contieneVerde = colores.Contains("Verde"); //? Devuelve true

        //* ForEach(Action<T> action): Ejecutar una acción en cada elemento de la lista.
        //numeros.ForEach(numero => Console.WriteLine(numero));
        
        //* RemoveAt(int index): Elimina el elemento en la posición especificada.
        List<string> colores2 = new List<string> { "Rojo", "Verde", "Azul" };
        colores2.RemoveAt(2);
        //System.Console.WriteLine("RemoveAt:");
        //colores2.ForEach(x => System.Console.WriteLine(x));

        //* Clear(): Elimina todos los elementos de la lista.
        List<string> colores3 = new List<string> { "Rojo", "Verde", "Azul" };
        colores3.Clear();
        // System.Console.WriteLine("Ejemplo con Clear");
        // colores3.ForEach(x => System.Console.WriteLine(x));

        //* IndexOf(T item): Devuelve el índice de la primera ocurrencia del elemento especificado.
        //* LastIndexOf(T item): Devuelve el índice de la última ocurrencia del elemento especificado.
        List<string> colores4 = new List<string> { "Rojo", "Verde", "Azul", "Rojo" };
        // System.Console.WriteLine($"IndexOf: {colores4.IndexOf("Rojo")}");
        // System.Console.WriteLine($"LastIndexOf {colores4.LastIndexOf("Rojo")}");

        //* Reverse(): Invierte el orden de los elementos en la lista.
        numeros.Reverse();
        numeros.ForEach(numero => Console.WriteLine(numero));

        //! Properties

        //*Obtiene el número de elementos en la lista.
        //Console.WriteLine("Count: " + numeros.Count());

        //*Obtiene o establece la capacidad de la lista
        //*Que es el número de elementos que puede contener sin necesidad de redimensionarse.
        //Console.WriteLine("Capacity: " + numeros.Capacity);
    }
}



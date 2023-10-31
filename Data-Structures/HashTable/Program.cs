using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //! Declaracion

        Hashtable hashtable = new();

        //! Metodos

        //* Add(key, value): Agrega un par clave-valor a la tabla hash.
        hashtable.Add("Nombre", "Juan");
        hashtable.Add("Edad", 30);

        //* Item[key]: Obtiene o establece el valor asociado con una clave específica.
        object nombre = hashtable["Nombre"];
        hashtable["Edad"] = 31;

        //* Remove(key): Elimina un elemento con la clave especificada.
        //hashtable.Remove("Edad");

        //* ContainsKey(key): Comprueba si la tabla hash contiene una clave específica.
        bool containsKey = hashtable.ContainsKey("Nombre");

        //* ContainsValue(value): Comprueba si la tabla hashch contiene un valor específico.
        bool containsValue = hashtable.ContainsValue("Juan");

        //* Clear(): Elimina todos los elementos de la tabla hash.
        //hashtable.Clear();

        //* Clone(): Crea una copia superficial de la tabla hash.
        Hashtable copy = (Hashtable)hashtable.Clone();

        //* GetHashCode(): Obtiene el código hash de la instancia de Hashtable. 
        //*Este método no se utiliza para manipular elementos individuales, sino para obtener el código hash de la tabla en sí.
        int hashCode = hashtable.GetHashCode();
        Console.WriteLine("HashCode {0}",hashCode);

        //* CopyTo(array, index): Copia los elementos de la Hashtable a un array unidimensional existente, comenzando en un índice específico del array.
        object[] array = new object[hashtable.Count];
        hashtable.CopyTo(array, 0);
        // foreach (var item in array)
        // {
        //     System.Console.WriteLine(item);
        // }

        //! Propiedades

        //* Count: Obtiene el número de elementos en la tabla hash.
        int count = hashtable.Count;

        //* Keys: Obtiene una colección de todas las claves en la tabla hash.
        ICollection keys = hashtable.Keys;

        //* Values: Obtiene una colección de todos los valores en la tabla hash.
        ICollection values = hashtable.Values;
    }
}

//? Elements of Hashing
//* Key
//* Hash function
//* Hash Table

//? Complexity of calculating hash value using the hash function
//* Time complexity: O(n)
//* Space complexity: O(1)

//? Collision Resolution Technique
//* Separate Chaining: Use LinkedList
//* Open Addressing
//* - Linear Probing:  key = (key+1) % size
//* - Quadratic Probing: (hash(x) + 1^2) % n, (hash(x) + 2^2) % n, (hash(x) + 3^2) % n...
//* - Double Hashing: h(k, i) = (h1(k) + i * h2(k)) % n 

//? Complexity of the Double hashing algorithm: 
//* Time complexity: O(n)

//? The load Factor helps us in determining the efficiency of the hash function 
//* Load Factor = Total elements in hash table/ Size of hash table 

//* It also can be a dictionary with linked list
//* The goal of hashing is to resolve the challenge of finding an item quickly in a collection. 
//* Example of Hash: "ab" -> a=1, b=2 and you have 7 spaces in the hash table, Key = 1+2 % 7

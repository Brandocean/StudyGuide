
internal class Program
{
    private static void Main(string[] args)
    {
        //! Declaration
        
        //* Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];

        //* Declare and set array element values.
        int[] array2 = { 1, 2, 3, 4, 5, 6 };

        //* Declare a two dimensional array.
        int[,] multiDimensionalArray1 = new int[2, 3];

        //* Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        //* Declare a jagged array.
        int[][] jaggedArray = new int[6][];

        //* Set the values of the first array in the jagged array structure.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

        //! Methods
        Array.ForEach(array2, x => Console.WriteLine(x));
    }
}
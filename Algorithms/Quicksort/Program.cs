internal class Program
{
    // A utility function to swap two elements
    static void Swap(int[] arr, int i, int j)
    {
        (arr[j], arr[i]) = (arr[i], arr[j]);
    }

    // This function takes last element as pivot,
    // places the pivot element at its correct position
    // in sorted array, and places all smaller to left
    // of pivot and all greater elements to right of pivot
    static int Partition(int[] arr, int low, int high)
    {
        // Choosing the pivot
        int pivot = arr[high];

        // Index of smaller element and indicates
        // the right position of pivot found so far
        int i = low - 1;

        for (int j = low; j <= high - 1; j++)
        {

            // If current element is smaller than the pivot
            if (arr[j] < pivot)
            {

                // Increment index of smaller element
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i + 1;
    }

    // The main function that implements QuickSort
    // arr[] --> Array to be sorted,
    // low --> Starting index,
    // high --> Ending index
    static void QuickSort(int[] arr, int low, int high) //{ 10, 7, 8, 9, 1, 5 } l=0, h=5
    {
        if (low < high)
        {

            // pi is partitioning index, arr[p]
            // is now at right place
            int pi = Partition(arr, low, high);

            // Separately sort elements before
            // and after partition index
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }
    private static void Main(string[] args)
    {
        //! Path #1: Method sort
        List<int> myList = new();
        myList.AddRange(new List<int> { 1, 6, 5, 3, 2, 8 });
        myList.Sort(); //? Usa QuickSort
        //myList.ForEach(p => System.Console.WriteLine(p));
        
        //! Path #2: QuickSort
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        int N = arr.Length;
 
        // Function call
        QuickSort(arr, 0, N - 1);
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < N; i++)
            Console.Write(arr[i] + " ");
    }
}
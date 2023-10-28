internal class Program
{
    // Time Complexity: O(log N)
    // Auxiliary Space: O(1)
    static int BinarySearch(int[] arr, int x) //{ 2, 3, 4, 10, 40 }
    {
        int l = 0, h = arr.Length - 1;
        while (l <= h)
        { //3 4
            int m = l + (h - l) / 2; //3

            // Check if x is present at mid
            if (arr[m] == x)
                return m;

            // If x greater, ignore left half
            if (arr[m] < x)
                l = m + 1;

            // If x is smaller, ignore right half
            else
                h = m - 1;
        }

        // If we reach here, then element was
        // not present
        return -1;
    }

    // Time Complexity: 
    //  - Best Case: O(1)
    //  - Average Case: O(log N)
    //  - Worst Case: O(log N)
    // Auxiliary Space: O(1), If the recursive call stack is considered then the auxiliary space will be O(logN).
    static int BinarySearchRecursive(int[] arr, int l, int h, int x) //{ 2, 3, 4, 10, 40 } l=3 h=4
    {
        if (h >= l)
        {
            int mid = l + (h - l) / 2; //3

            // If the element is present at the
            // middle itself
            if (arr[mid] == x)
                return mid;

            // If element is smaller than mid, then
            // it can only be present in left subarray
            if (arr[mid] < x)
                return BinarySearchRecursive(arr, mid + 1, h, x);

            // Else the element can only be present
            // in right subarray
            return BinarySearchRecursive(arr, l, mid - 1, x);
        }

        // We reach here when element is not present
        // in array
        return -1;
    }

    private static void Main(string[] args)
    {
        //! Path #1 : Method
        List<int> myList = new();
        myList.AddRange(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        //System.Console.WriteLine($"Binary Search: {myList.BinarySearch(5)}");

        //! Path #2 : Iterative
        int[] arr = { 2, 3, 4, 10, 40 };
        int n = arr.Length;
        int x = 10;
        int result = BinarySearch(arr, x);
        if (result == -1)
            Console.WriteLine("Element is not present in array");
        else
            Console.WriteLine("Element is present at index " + result);

        //! Path #3: Recursive
        int resultRecursive = BinarySearchRecursive(arr, 0, n - 1, x);

        if (resultRecursive == -1)
            Console.WriteLine("Element is not present in array");
        else
            Console.WriteLine("Element is present at index " + resultRecursive);

    }
}
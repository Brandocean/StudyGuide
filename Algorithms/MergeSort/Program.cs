internal class Program
{
    private static void Main(string[] args)
    {
        //! Path #1: Method sort
        List<int> myList = new();
        myList.AddRange(new List<int> { 1, 6, 5, 3, 2, 8 });
        myList.Sort(); //? Usa QuickSort
        //myList.ForEach(p => System.Console.WriteLine(p));

        
    }
}
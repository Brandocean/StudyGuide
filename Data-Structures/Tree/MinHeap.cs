using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree;

public class MinHeap
{
    private List<int> heap;

    public MinHeap()
    {
        heap = new List<int>();
    }

    public void Insert(int value)
    {
        heap.Add(value);
        int currentIndex = heap.Count - 1;

        while (currentIndex > 0)
        {
            int parentIndex = (currentIndex - 1) / 2;
            if (heap[currentIndex] >= heap[parentIndex])
                break;

            Swap(currentIndex, parentIndex);
            currentIndex = parentIndex;
        }
    }

    public int ExtractMin()
    {
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        int min = heap[0];
        int lastIndex = heap.Count - 1;
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);

        int currentIndex = 0;
        while (true)
        {
            int leftChildIndex = 2 * currentIndex + 1;
            int rightChildIndex = 2 * currentIndex + 2;
            int smallestIndex = currentIndex;

            if (leftChildIndex < heap.Count && heap[leftChildIndex] < heap[smallestIndex])
                smallestIndex = leftChildIndex;

            if (rightChildIndex < heap.Count && heap[rightChildIndex] < heap[smallestIndex])
                smallestIndex = rightChildIndex;

            if (smallestIndex == currentIndex)
                break;

            Swap(currentIndex, smallestIndex);
            currentIndex = smallestIndex;
        }

        return min;
    }

    public void RemoveMin()
    {
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        ExtractMin();
    }

    public void Delete(int value)
    {
        int index = heap.IndexOf(value);
        if (index == -1)
        {
            throw new InvalidOperationException("Value not found in the heap.");
        }

        heap[index] = int.MinValue; // Replace the value with negative infinity.
        int currentIndex = index;

        while (currentIndex > 0)
        {
            int parentIndex = (currentIndex - 1) / 2;
            if (heap[currentIndex] >= heap[parentIndex])
                break;

            Swap(currentIndex, parentIndex);
            currentIndex = parentIndex;
        }

        ExtractMin(); // Remove the negative infinity value.
    }

    private void Swap(int index1, int index2)
    {
        (heap[index2], heap[index1]) = (heap[index1], heap[index2]);
    }

     public void PrintHeap()
    {
        if (heap.Count == 0)
        {
            Console.WriteLine("El heap está vacío.");
            return;
        }

        Console.Write("Heap: ");
        for (int i = 0; i < heap.Count; i++)
        {
            Console.Write(heap[i]);
            if (i < heap.Count - 1)
            {
                Console.Write(" - ");
            }
        }
        Console.WriteLine();
    }
}

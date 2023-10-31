using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tree;

public class MaxHeap
{
    private List<int> heap;

    public MaxHeap()
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
            if (heap[currentIndex] <= heap[parentIndex])
                break;

            Swap(currentIndex, parentIndex);
            currentIndex = parentIndex;
        }
    }

    public int ExtractMax()
    {
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        int max = heap[0];
        int lastIndex = heap.Count - 1;
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);

        int currentIndex = 0;
        while (true)
        {
            int leftChildIndex = 2 * currentIndex + 1;
            int rightChildIndex = 2 * currentIndex + 2;
            int largestIndex = currentIndex;

            if (leftChildIndex < heap.Count && heap[leftChildIndex] > heap[largestIndex])
                largestIndex = leftChildIndex;

            if (rightChildIndex < heap.Count && heap[rightChildIndex] > heap[largestIndex])
                largestIndex = rightChildIndex;

            if (largestIndex == currentIndex)
                break;

            Swap(currentIndex, largestIndex);
            currentIndex = largestIndex;
        }

        return max;
    }

    public void RemoveMax()
    {
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        ExtractMax();
    }

    public void Delete(int value)
    {
        int index = heap.IndexOf(value);
        if (index == -1)
        {
            throw new InvalidOperationException("Value not found in the heap.");
        }

        heap[index] = int.MaxValue; // Replace the value with positive infinity.
        int currentIndex = index;

        while (currentIndex > 0)
        {
            int parentIndex = (currentIndex - 1) / 2;
            if (heap[currentIndex] <= heap[parentIndex])
                break;

            Swap(currentIndex, parentIndex);
            currentIndex = parentIndex;
        }

        ExtractMax(); // Remove the positive infinity value.
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

//? Max Heap: the value of the root node must be the greatest among all its child nodes and the same thing must be done for its sub-trees.
//? Min-Heap: the value of the root node must be the smallest among all its child nodes and the same thing must be done for its sub-trees.
//* It takes O(log N) to balance the tree. (Heapify)
//* The left and the right child of ith node are in indices 2*i+1 and 2*i+2.
//* Fast access to maximum/minimum element (O(1))

//? Advantages
//* Efficient Insertion and Deletion operations (O(log n))
//* Can be efficiently implemented as an array

//? Disadvantages
//* Not suitable for searching for an element other than maximum/minimum (O(n) in worst case)
//* Extra memory overhead to maintain heap structure

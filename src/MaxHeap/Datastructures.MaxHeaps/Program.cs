using System;

namespace Datastructures.MaxHeaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class MaxHeap
    {
        public static int[] MaxHeapify(int[] arr)
        {
            var lastTreeIndex = (arr.Length / 2) - 1;
            MaxHeapify(arr, lastTreeIndex);

            return arr;
        }

        private static void MaxHeapify(int[] arr, int lastTreeIndex)
        {
            Console.WriteLine($"lastTreeIndex: {lastTreeIndex}");


            for (int rootIndex = lastTreeIndex; rootIndex >= 0; rootIndex--)
            {
                var largestIndex = rootIndex;
                var leftIndex = (rootIndex * 2);
                var rightIndex = (rootIndex * 2) + 1;

                Console.WriteLine($"");
                Console.WriteLine($"Indexs: ");
                Console.WriteLine($"rootIndex: {rootIndex}");
                Console.WriteLine($"leftIndex: {leftIndex}");
                Console.WriteLine($"rightIndex: {rightIndex}");

                if (arr[leftIndex] > arr[largestIndex])
                {
                    largestIndex = leftIndex;
                }

                if (arr[rightIndex] > arr[largestIndex])
                {
                    largestIndex = rightIndex;
                }

                if (largestIndex != rootIndex)
                {
                    Console.WriteLine($"swapping: {largestIndex} with {rootIndex}");

                    var temp = arr[largestIndex];
                    arr[largestIndex] = arr[rootIndex];
                    arr[rootIndex] = temp;

                    if (largestIndex < (arr.Length) / 2) 
                    {
                        MaxHeapify(arr, largestIndex);
                    }
                }
            }
        }
    }
}

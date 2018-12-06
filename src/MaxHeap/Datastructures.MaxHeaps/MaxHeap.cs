using System;

namespace Datastructures.MaxHeaps
{
    public class MaxHeap
    {
        private int[] _data;

        public MaxHeap(int[] arr)
        {
            _data = arr;
        }

        public int[] GetSorted()
        {
            Sort();
            return _data;
        }

        private void Sort()
        {
            void MaxHeapify(int treeIndex)
            {                
                for (int rootIndex = treeIndex; rootIndex >= 0; rootIndex--)
                {
                    var largestIndex = rootIndex;
                    var leftIndex = (rootIndex * 2);
                    var rightIndex = (rootIndex * 2) + 1;

                    if (_data[leftIndex] > _data[largestIndex])
                        largestIndex = leftIndex;

                    if (_data[rightIndex] > _data[largestIndex])
                        largestIndex = rightIndex;

                    if (largestIndex != rootIndex)
                    {
                        Swap(largestIndex, rootIndex);

                        if (largestIndex < (_data.Length) / 2) 
                        {
                            MaxHeapify(largestIndex);
                        }
                    }
                }
            }

            var lastTreeIndex = (_data.Length / 2) - 1;
            MaxHeapify(lastTreeIndex);
        }

        private void Swap(int x, int y)
        {
            var temp = _data[x];
            _data[x] = _data[y];
            _data[y] = temp;
        }
    }
}

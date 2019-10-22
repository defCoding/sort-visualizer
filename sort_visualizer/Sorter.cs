using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_visualizer
{
    public class ArrayEventArgs : EventArgs
    {
        public int[] array { get; }
        public int currIndex { get; }
        public int checkedIndex { get; }

        public ArrayEventArgs(int[] array, int currIndex, int checkedIndex)
        {
            this.array = array;
            this.currIndex = currIndex;
            this.checkedIndex = checkedIndex;
        }
    }

    /// <summary>
    /// The class <c>Sorter</c> takes care of sorting an array and raises an event whenever the array is modified.
    /// </summary>
    /// <value>Property <c>array</c> is the array being sorted.</value>
    /// <value>Property <c>initialArray</c> stored the initial array before it was sorted.</value>
    class Sorter
    {
        private int[] array;
        private int[] initialArray;
        private static Random rand = new Random();

        public delegate void ArrayModifiedEventHandler(object src, ArrayEventArgs array);
        public event ArrayModifiedEventHandler ArrayModified;

        public Sorter()
        {
        }

        protected virtual void OnArrayModified(int currIndex, int checkedIndex)
        {
            ArrayModified?.Invoke(this, new ArrayEventArgs((int[]) array.Clone(), currIndex, checkedIndex));
        }

        public void generateArray(int size, int min, int max)
        {
            array = new int[size];
            initialArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max + 1);
                initialArray[i] = array[i];
            }
            OnArrayModified(0, 0);
        }

        public void resetArray()
        {
            this.array = (int[])this.initialArray.Clone();
            OnArrayModified(0, 0);
        }

        public void insertionSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int k = i;
                OnArrayModified(k, Math.Max(0, k - 1));
                while (k > 0 && array[k] < array[k - 1])
                {
                    OnArrayModified(k, k - 1);
                    swap(k, k - 1);
                    k--;
                }
            }
            OnArrayModified(0, 0);
        }

        public void quickSort()
        {
            quickSortHelper(0, array.Length - 1);
            OnArrayModified(0, 0);
        }

        private void quickSortHelper(int start, int end)
        {
            if (start < end)
            {
                int pivot = partition(start, end);

                quickSortHelper(start, pivot - 1);
                quickSortHelper(pivot + 1, end);
            }
        }

        private int chooseCentralZonePivot(int start, int end)
        {
            int pivotIndex;
            int rankOfPivot;
            int count = 0;
            do
            {
                rankOfPivot = 0;
                pivotIndex = rand.Next(start, end + 1);
                count++;
                for (int i = start; i <= end; i++)
                {
                    if (array[i] < array[pivotIndex])
                    {
                        rankOfPivot++;
                    }
                }
            } while (count <= 5 && (rankOfPivot < Math.Floor((end - start) / 4.0) || rankOfPivot > Math.Ceiling(3 * (end - start) / 4.0)));

            return pivotIndex;
        }

        private int partition(int start, int end)
        {
            int pivotIndex = chooseCentralZonePivot(start, end);

            int pivot = array[pivotIndex];
            array[pivotIndex] = array[end];
            array[end] = pivot;

            int lowBoundaryIndex = start;

            for (int i = start; i < end; i++)
            {
                OnArrayModified(end, i);
                if (array[i] <= pivot)
                {
                    swap(lowBoundaryIndex, i);
                    OnArrayModified(end, lowBoundaryIndex);
                    lowBoundaryIndex++;
                }
            }

            array[end] = array[lowBoundaryIndex];
            array[lowBoundaryIndex] = pivot;

            return lowBoundaryIndex;
        }

        public void mergeSort()
        {
            mergeSortHelper(0, array.Length - 1);
            OnArrayModified(0, 0);
        }

        private void mergeSortHelper(int start, int end)
        {
            if (start == end)
            {
                return;
            } else
            {
                int middle = (start + end) / 2;
                mergeSortHelper(start, middle);
                mergeSortHelper(middle + 1, end);
                merge(start, middle, middle + 1, end);
            }
        }

        private void merge(int startA, int endA, int startB, int endB)
        {
            while (startA <= endA && startB <= endB)
            {
                OnArrayModified(startA, startB);
                if (array[startA] > array[startB])
                {
                    int tmp = array[startB];
                    for (int i = startB; i > startA; i--)
                    {
                        array[i] = array[i - 1];
                    }
                    array[startA++] = tmp;
                    startB++;
                    endA++;
                } else
                {
                    startA++;
                }
            }
        }

        public void bubbleSort()
        {
            for (int i = array.Length; i >= 0; i--)
            {
                int k = i;
                OnArrayModified(k, Math.Min(array.Length - 1, k + 1));
                while (k < array.Length - 1 && array[k] > array[k + 1])
                {
                    OnArrayModified(k, k + 1);
                    swap(k, k + 1);
                    k++;
                }
            }
            OnArrayModified(0, 0);
        }

        public void selectionSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = findMinIndex(i);
                swap(minIndex, i);
                OnArrayModified(i, minIndex);
            }
            OnArrayModified(0, 0);
        }

        public void radixSort()
        {
            int maxValue = findMaxValue();
            int degree = 0;
            while (maxValue >= 10)
            {
                maxValue /= 10;
                degree++;
            }
            radixSortHelper(0, array.Length - 1, degree);
            OnArrayModified(0, 0);
        }

        private void radixSortHelper(int start, int end, int degree)
        {
            if (start > end || degree < 0)
            {
                return;
            }

            int[] count = new int[10];
            count[0] = start;

            int i;
            for (i = start; i <= end; i++)
            {
                int digit = getDigit(array[i], degree);
                OnArrayModified(i, i);
                count[digit]++;
            }

            for (i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }


            i = start;
            while (i <= end)
            {
                int digit = getDigit(array[i], degree);
                int boundaryStart = digit == 0 ? -1 : count[digit - 1];

                if (i < boundaryStart)
                {
                    OnArrayModified(i, count[digit] - 1);
                    swap(i, count[digit] - 1);
                    count[digit]--;
                } else
                {
                    OnArrayModified(i, i);
                    i++;
                }
            }

            i = start;
            while (i <= end)
            {
                int currentDigit = getDigit(array[i], degree);
                int j = i + 1;

                while (j <= end && currentDigit == getDigit(array[j], degree))
                {
                    j++;
                }
                radixSortHelper(i, j - 1, degree - 1);
                i = j;
            }
        }

        /// <summary>
        /// Gets the index of the smallest value in <c>array</c> starting from a given index.
        /// </summary>
        /// <param name="start">The index to begin the search from.</param>
        /// <returns>The index of the smallest value from <c>start</c> onwards in <c>array</c></returns>
        private int findMinIndex(int start)
        {
            int minIndex = start;
            for (int i = start + 1; i < array.Length; i++)
            {
                OnArrayModified(minIndex, i);
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        /// <summary>
        /// Gets the value of the largest number in <c>array</c>.
        /// </summary>
        /// <returns>The largest value in <c>array</c>.</returns>
        private int findMaxValue()
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        /// <summary>
        /// Gets a specified digit from a given value.
        /// </summary>
        /// <param name="value">The value of the target number.</param>
        /// <param name="degree">The place of the digit desired. 0 is 10^0, or ones place. 1 is 10^1, or tens place.</param>
        /// <returns></returns>
        private int getDigit(int value, int degree)
        {
            for (int i = 0; i < degree; i++)
            {
                value /= 10;
            }
            return value % 10;
        }

        public void countingSort()
        {
            int i;
            int maxVal = findMaxValue();
            int[] count = new int[maxVal + 1];
            for (i = 0; i < array.Length; i++)
            {
                OnArrayModified(i, i);
                count[array[i]]++;
            }

            for (i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            i = 0;
            while (i < array.Length)
            {
                int boundaryStart = array[i] == 0 ? -1 : count[array[i] - 1];

                if (i < boundaryStart)
                {
                    OnArrayModified(i, count[array[i]] - 1);
                    int temp = array[i];
                    swap(i, count[array[i]] - 1);
                    count[temp]--;
                } else
                {
                    OnArrayModified(i, i);
                    i++;
                }
            }

            OnArrayModified(0, 0);
        }

        public void heapSort()
        {
            heapify();
            for (int i = 0; i < array.Length; i++)
            {
                removeMax(array.Length - 1 - i);
            }
        }

        private void heapify()
        {
            for (int i = array.Length / 2; i >= 0; i--)
            {
                siftDown(i, array.Length - 1);
            }
        }

        private void removeMax(int end)
        {
            OnArrayModified(0, end);
            swap(0, end);
            siftDown(0, end - 1);
        }

        private void siftDown(int index, int end)
        {
            if (index < end)
            {
                int maxChildIndex = getMaxChildIndex(index, end);
                if (maxChildIndex != -1 && array[index] < array[maxChildIndex])
                {
                    OnArrayModified(index, maxChildIndex);
                    swap(index, maxChildIndex);
                    siftDown(maxChildIndex, end);
                }
            }

        }

        private int getMaxChildIndex(int index, int end)
        {
            int child1Index = 2 * index > end ? -1 : 2 * index;
            int child2Index = 2 * index + 1 > end ? -1 : 2 * index + 1;

            return (child1Index == -1 || child2Index == -1 || array[child1Index] > array[child2Index]) ? child1Index : child2Index;
        }

        /// <summary>
        /// Swaps the values at two indexes in <c>array</c>.
        /// </summary>
        /// <param name="i">The first index.</param>
        /// <param name="j">The second index.</param>
        private void swap(int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}

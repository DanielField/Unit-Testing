using System;

namespace algorithms {
    /// <summary>
    /// Sorting algorithms.
    /// </summary>
    public static class Sort {
        #region QuickSort
        /// <summary>
        /// Extension method for sorting an array of elements using the quick sort algorithm.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="values">The array that will be sorted.</param>
        public static void QuickSort<T>(this T[] values) where T : IComparable {
            QuickSort(ref values, 0, values.Length - 1);
        }

        /// <summary>
        /// Method for sorting an array (or sub-array) of elements using the quick sort algorithm. 
        /// Note: the array is passed by reference.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="values">The array that will be sorted.</param>
        /// <param name="left">The index of the first element to be sorted.</param>
        /// <param name="right">The index of the last element to be sorted.</param>
        public static void QuickSort<T>(ref T[] values, int left, int right) where T : IComparable {
            if (left < right) {
                int pivot = Partition(ref values, left, right);
                QuickSort(ref values, left, pivot - 1);
                QuickSort(ref values, pivot + 1, right);
            }
        }

        /// <summary>
        /// Private method for partitioning the array for the quick sort algorithm.
        /// </summary>
        /// <typeparam name="T">Type of values.</typeparam>
        /// <param name="values">Array of values.</param>
        /// <param name="left">Leftmost element's index.</param>
        /// <param name="right">Rightmost element's index.</param>
        /// <returns>Return the position where the partition is.</returns>
        private static int Partition<T>(ref T[] values, int left, int right) where T : IComparable {
            T pivot = values[left];
            int i = left, j = right + 1;
            do {
                do { if (i < values.Length - 1) i++; else break; } while (values[i].CompareTo(pivot) == -1);
                do { if (j > 0) j--; else break; } while (values[j].CompareTo(pivot) == 1);
                Swap(ref values[i], ref values[j]);
            } while (i < j);
            Swap(ref values[i], ref values[j]);
            Swap(ref values[left], ref values[j]);
            return j;
        }
        #endregion QuickSort

        #region BubbleSort
        /// <summary>
        /// Extension method for sorting an array of elements using the bubble sort algorithm.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <param name="values">The array that will be sorted.</param>
        public static void BubbleSort<T>(this T[] values) where T : IComparable {
            int j;
            for (int i = 0; i < values.Length - 1; i++)
                for (j = 0; j < values.Length - 1 - i; j++)
                    if (values[j + 1].CompareTo(values[j]) == -1)
                        Swap(ref values[j], ref values[j + 1]);
        }
        #endregion BubbleSort

        /// <summary>
        /// Swaps two values.
        /// Note: the values are passed by reference.
        /// </summary>
        /// <typeparam name="T">The type of values.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        private static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    /// <summary>
    /// Search algorithms.
    /// </summary>
    public static class Search {
        /// <summary>
        /// Perform a binary search on the specified sorted array (ascending order).
        /// </summary>
        /// <typeparam name="T">The type of values.</typeparam>
        /// <param name="values">The sorted array (ascending order) of values to search through.</param>
        /// <param name="key">The value for which to search.</param>
        /// <returns>If found, return the index of the element, else return -1.</returns>
        public static int BinarySearch<T>(T[] values, T key) where T : IComparable {
            int left = 0, right = values.Length - 1, middle;
            while (left <= right) {
                middle = (left + right) / 2;
                if (key.CompareTo(values[middle]) == 0) {
                    return middle;
                } else if (key.CompareTo(values[middle]) == -1) {
                    right = middle - 1;
                } else {
                    left = middle + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// Perform a binary search on the specified sorted array.
        /// </summary>
        /// <typeparam name="T">The type of values.</typeparam>
        /// <param name="values">The sorted array of values to search through.</param>
        /// <param name="key">The value for which to search.</param>
        /// <param name="descending">If true, the method will assume the array is in descending order, 
        ///                          else it will assume it's ascending.</param>
        /// <returns>If found, return the index of the element, else return -1.</returns>
        public static int BinarySearch<T>(T[] values, T key, bool descending) where T : IComparable {
            if (descending) {
                int left = 0, right = values.Length - 1, middle;
                while (left <= right) {
                    middle = (left + right) / 2;
                    if (key.CompareTo(values[middle]) == 0) {
                        return middle;
                    } else if (key.CompareTo(values[middle]) == 1) {
                        right = middle - 1;
                    } else {
                        left = middle + 1;
                    }
                }
            } else {
                BinarySearch<T>(values, key);
            }

            return -1;
        }

        /// <summary>
        /// Perform a sequential search on the specified array.
        /// </summary>
        /// <typeparam name="T">The type of values.</typeparam>
        /// <param name="values">The array of values to search through.</param>
        /// <param name="key">The value for which to search.</param>
        /// <returns>If found, return the index of the element, else return -1.</returns>
        public static int SequentialSearch<T>(T[] values, T key) where T : IComparable {
            for (int i = 0; i < values.Length; i++)
                if (key.CompareTo(values[i]) == 0)
                    return i;
            return -1;
        }
    }
}

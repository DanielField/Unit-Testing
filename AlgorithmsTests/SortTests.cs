using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace algorithms.Tests {
    [TestClass()]
    public class SortTests {

        #region QuickSort tests
        [TestMethod()]
        public void QuickSortStringTest() {
            string[] names = { "Daniel", "Alice", "Thomas", "Billy", "Sally", "Greg" };
            string[] namesSorted = { "Alice", "Billy", "Daniel", "Greg", "Sally", "Thomas" };
            names.QuickSort();

            for (int i = 0; i < names.Length; i++)
                Assert.AreEqual(namesSorted[i], names[i]);
        }

        [TestMethod()]
        public void QuickSortIntegerTest() {
            int[] values = { 0, 14, 2, 11, 5, 21, 1104, -1, -25 };
            int[] valuesSorted = { -25, -1, 0, 2, 5, 11, 14, 21, 1104 };
            values.QuickSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void QuickSortFloatTest() {
            float[] values = { 0.0f, 14.0f, 2.6f, 11.0f, 5.0f, 21.2f, 1104.0f, -1.0f, -25.0f };
            float[] valuesSorted = { -25.0f, -1.0f, 0.0f, 2.6f, 5.0f, 11.0f, 14.0f, 21.2f, 1104.0f };
            values.QuickSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void QuickSortAlreadySortedTest() {
            int[] values = { 2, 4, 6, 7, 104, 213, 314 };
            int[] valuesSorted = values;
            values.QuickSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void QuickSortReverseTest() {
            int[] values = { 100, 94, 56, 35, 32, 10, -52 };
            int[] valuesSorted = values;
            Array.Reverse(valuesSorted);

            values.QuickSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void QuickSortIsAscendingTest() {
            decimal[] values = { 0.3m, 141.42325m, 13.524m, 14.411m, 3.14159265m };
            values.QuickSort();

            for (int i = 0; i < values.Length-1; i++)
                Assert.IsTrue(values[i] < values[i + 1]);
        }

        [TestMethod()]
        public void QuickSortSameSizeTest() {
            int[] values = { 15, 1, 64, 14, 2, 51, 16 };
            values.QuickSort();
            Assert.AreEqual(7, values.Length);
        }

        [TestMethod()]
        public void QuickSortEmptyArrayTest() {
            int[] values = { };
            values.QuickSort();
        }
        
        [TestMethod()]
        public void QuickSortSizeOneTest() {
            float[] values = { 250.0f };
            values.QuickSort();
        }
        #endregion QuickSort tests

        #region BubbleSort tests
        [TestMethod()]
        public void BubbleSortStringTest() {
            string[] names = { "Daniel", "Alice", "Thomas", "Billy", "Sally", "Greg" };
            string[] namesSorted = { "Alice", "Billy", "Daniel", "Greg", "Sally", "Thomas" };
            names.BubbleSort();

            for (int i = 0; i < names.Length; i++)
                Assert.AreEqual(namesSorted[i], names[i]);
        }

        [TestMethod()]
        public void BubbleSortIntegerTest() {
            int[] values = { 0, 14, 2, 11, 5, 21, 1104, -1, -25 };
            int[] valuesSorted = { -25, -1, 0, 2, 5, 11, 14, 21, 1104 };
            values.BubbleSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void BubbleSortFloatTest() {
            float[] values = { 0.0f, 14.0f, 2.6f, 11.0f, 5.0f, 21.2f, 1104.0f, -1.0f, -25.0f };
            float[] valuesSorted = { -25.0f, -1.0f, 0.0f, 2.6f, 5.0f, 11.0f, 14.0f, 21.2f, 1104.0f };
            values.BubbleSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void BubbleSortAlreadySortedTest() {
            int[] values = { 2, 4, 6, 7, 104, 213, 314 };
            int[] valuesSorted = values;
            values.BubbleSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void BubbleSortReverseTest() {
            int[] values = { 100, 94, 56, 35, 32, 10, -52 };
            int[] valuesSorted = values;
            Array.Reverse(valuesSorted);

            values.BubbleSort();

            for (int i = 0; i < values.Length; i++)
                Assert.AreEqual(valuesSorted[i], values[i]);
        }

        [TestMethod()]
        public void BubbleSortIsAscendingTest() {
            decimal[] values = { 0.3m, 141.42325m, 13.524m, 14.411m, 3.14159265m };
            values.BubbleSort();

            for (int i = 0; i < values.Length - 1; i++)
                Assert.IsTrue(values[i] < values[i + 1]);
        }

        [TestMethod()]
        public void BubbleSortSameSizeTest() {
            int[] values = { 15, 1, 64, 14, 2, 51, 16 };
            values.BubbleSort();
            Assert.AreEqual(7, values.Length);
        }

        [TestMethod()]
        public void BubbleSortEmptyArrayTest() {
            int[] values = { };
            values.BubbleSort();
        }

        [TestMethod()]
        public void BubbleSortSizeOneTest() {
            float[] values = { 250.0f };
            values.BubbleSort();
        }
        #endregion BubbleSort tests
    }
}
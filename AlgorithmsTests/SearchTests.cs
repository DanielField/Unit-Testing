using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithms;

namespace AlgorithmsTests {
    [TestClass()]
    public class SearchTests {
        #region BinarySearch tests
        [TestMethod()]
        public void BinarySearchIntegersTest() {
            int[] numbers = { 1, 2, 7, 44, 54, 58, 72, 96, 102 };
            int index = Search.BinarySearch(numbers, 96);

            Assert.AreEqual(index, 7);
        }

        [TestMethod()]
        public void BinarySearchDoublesTest() {
            double[] numbers = { 4.32, 8.16, 16.8, 32.4, 64.2, 128.1 };
            int index = Search.BinarySearch(numbers, 16.8);

            Assert.AreEqual(index, 2);
        }

        [TestMethod()]
        public void BinarySearchFloatsTest() {
            float[] numbers = { 4.32f, 8.16f, 16.8f, 32.4f, 64.2f, 128.1f };
            int index = Search.BinarySearch(numbers, 128.1f);

            Assert.AreEqual(index, 5);
        }

        [TestMethod()]
        public void BinarySearchIntegerNonExistentTest() {
            int[] numbers = { 1, 2, 7, 44, 54, 58, 72, 96, 102 };
            int index = Search.BinarySearch(numbers, 9);

            Assert.AreEqual(index, -1);
        }

        [TestMethod()]
        public void BinarySearchEmptyTest() {
            int[] numbers = { };
            int index = Search.BinarySearch(numbers, 9);

            Assert.AreEqual(index, -1);
        }

        [TestMethod()]
        public void BinarySearchStringsTest() {
            string[] strings = { "Acacia cognata", "Acacia coriaceae", "Acacia covenyi", "Acacia cowleana", "Acacia craspedocarpa", "Acacia dealbata", "Acacia denticulosa", "Bluebush", "Broad Leaved Mulga", "Desert Oak", "Halls Creek Wattle", "River Wattle", "Silver Acacia" };
            int index = Search.BinarySearch(strings, "Bluebush");

            Assert.AreEqual(index, 7);
        }

        [TestMethod()]
        public void BinarySearchFirstElementTest() {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            int index = Search.BinarySearch(numbers, 2);

            Assert.AreEqual(index, 0);
        }

        [TestMethod()]
        public void BinarySearchLastElementTest() {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            int index = Search.BinarySearch(numbers, 12);

            Assert.AreEqual(index, 5);
        }
        #endregion BinarySearch tests

        #region SequentialSearch tests
        [TestMethod()]
        public void SequentialSearchIntegersTest() {
            int[] numbers = { 1, 2, 7, 44, 54, 58, 72, 96, 102 };
            int index = Search.SequentialSearch(numbers, 96);

            Assert.AreEqual(index, 7);
        }

        [TestMethod()]
        public void SequentialSearchDoublesTest() {
            double[] numbers = { 4.32, 8.16, 16.8, 32.4, 64.2, 128.1 };
            int index = Search.SequentialSearch(numbers, 16.8);

            Assert.AreEqual(index, 2);
        }

        [TestMethod()]
        public void SequentialSearchFloatsTest() {
            float[] numbers = { 4.32f, 8.16f, 16.8f, 32.4f, 64.2f, 128.1f };
            int index = Search.SequentialSearch(numbers, 128.1f);

            Assert.AreEqual(index, 5);
        }

        [TestMethod()]
        public void SequentialSearchIntegerNonExistentTest() {
            int[] numbers = { 1, 2, 7, 44, 54, 58, 72, 96, 102 };
            int index = Search.SequentialSearch(numbers, 9);

            Assert.AreEqual(index, -1);
        }

        [TestMethod()]
        public void SequentialSearchEmptyTest() {
            int[] numbers = { };
            int index = Search.SequentialSearch(numbers, 9);

            Assert.AreEqual(index, -1);
        }

        [TestMethod()]
        public void SequentialSearchStringsTest() {
            string[] strings = { "Acacia cognata", "Acacia coriaceae", "Acacia covenyi", "Acacia cowleana", "Acacia craspedocarpa", "Acacia dealbata", "Acacia denticulosa", "Bluebush", "Broad Leaved Mulga", "Desert Oak", "Halls Creek Wattle", "River Wattle", "Silver Acacia" };
            int index = Search.SequentialSearch(strings, "Bluebush");

            Assert.AreEqual(index, 7);
        }

        [TestMethod()]
        public void SequentialSearchFirstElementTest() {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            int index = Search.SequentialSearch(numbers, 2);

            Assert.AreEqual(index, 0);
        }

        [TestMethod()]
        public void SequentialSearchLastElementTest() {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            int index = Search.SequentialSearch(numbers, 12);

            Assert.AreEqual(index, 5);
        }
        #endregion SequentialSearch tests
    }
}


using MyIntArray;
using Newtonsoft.Json.Bson;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            int[] a = new int[] { 1, 4, 6, 7, 9 };
            IntArray array = new IntArray(a);
            Assert.AreEqual(4, array.BinarySearch(4));
        }

        [TestMethod]
        public void TestInterchangeSort()
        {
            int[] a = new int[] { 7, 9, 1, 2, 5 };
            int[] expResult = new int[] { 1, 2, 5, 7, 9 };
            IntArray array = new IntArray(a);
            int[] afterSorted = array.InterchangeSort();

            Assert.AreEqual(expResult.Length, afterSorted.Length);

            for (int i = 0; i < expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], afterSorted[i]);
            }
        }

        [TestMethod]
        public void TestBoubleSort()
        {
            int[] a = new int[] { 7, 9, 1, 2, 5 };
            int[] expResult = new int[] { 1, 2, 5, 7, 9 };
            IntArray array = new IntArray(a);
            int[] afterSorted = array.BoubleSort();

            Assert.AreEqual(expResult.Length, afterSorted.Length);

            for (int i = 0; i < expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], afterSorted[i]);
            }
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            int[] a = new int[] { 7, 9, 1, 2, 5 };
            int[] expResult = new int[] { 1, 2, 5, 7, 9 };
            IntArray array = new IntArray(a);
            int[] afterSorted = array.SelectionSort();

            Assert.AreEqual(expResult.Length, afterSorted.Length);

            for (int i = 0; i < expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], afterSorted[i]);
            }
        }

        [TestMethod]    
        public void TestInsertionSort()
        {
            int[] a = new int[] { 7, 9, 1, 2, 5 };
            int[] expResult = new int[] { 1, 2, 5, 7, 9 };
            IntArray array = new IntArray(a);
            int[] afterSorted = array.InsertionSort();

            Assert.AreEqual(expResult.Length, afterSorted.Length);

            for (int i = 0; i < expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], afterSorted[i]);
            }
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] a = new int[] { 7, 9, 1, 2, 5 };
            int[] expResult = new int[] { 1, 2, 5, 7, 9 };
            IntArray array = new IntArray(a);
            array.QuickSort(0, a.Length - 1);
            int[] afterSorted = array.ReturnArray();
            Assert.AreEqual(expResult.Length, afterSorted.Length);
            for (int i = 0; i < expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], afterSorted[i]);
            }
        }
    }
}
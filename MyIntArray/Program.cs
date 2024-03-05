using System;
namespace MyIntArray
{
    class Program
    {
        // Comment for github 123
        // Command 3
        // Command 2
        // command 6
        // Command 4
        // Command 7
        // Command 5
        // Command 10
        static void Main(string[] args)
        {
            SearchBinary();
            SortInterchange();
            SortBouble();
            SortSelection();
            SortInsertion();
        }

        public static void SearchBinary()
        {
            Console.WriteLine("*************** Binary Search ***************");
            int[] a = new int[] { 1, 4, 6, 7, 9 };
            IntArray array = new IntArray(a);
            Console.WriteLine(array.BinarySearch(4));
        }
        public static void SortInterchange()
        {
            Console.WriteLine("*************** Interchange Sort ***************");
            int[] a = new int[] { 1, 9, 7, 4, 6 };
            IntArray array = new IntArray(a);
            array.InterchangeSort();
            Console.WriteLine(array.ToString());
        }

        public static void SortBouble()
        {
            Console.WriteLine("*************** Bouble Sort ***************");
            int[] a = new int[] { 1, 9, 7, 4, 6 };
            IntArray array = new IntArray(a);
            array.BoubleSort();
            Console.WriteLine(array.ToString());
        }
        public static void SortSelection()
        {
            Console.WriteLine("*************** Selection Sort ***************");
            int[] a = new int[] { 1, 9, 7, 4, 6 };
            IntArray array = new IntArray(a);
            array.SelectionSort();
            Console.WriteLine(array.ToString());
        }
        public static void SortInsertion()
        {
            Console.WriteLine("*************** Insertion Sort ***************");
            int[] a = new int[] { 1, 9, 7, 4, 6 };
            IntArray array = new IntArray(a);
            array.InsertionSort();
            Console.WriteLine(array.ToString());
        }
    }
}

using System;
namespace MyIntArray
{
    protected class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 4, 6, 7, 9 };
            IntArray array = new IntArray(a);
            Console.WriteLine(array.BinarySearch(4));
        }
    }
}
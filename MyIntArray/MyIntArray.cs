using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIntArray
{
    public class IntArray
    {
        private readonly int[] array;

        public IntArray() 
        { 
            array = Array.Empty<int>();
        }
        public IntArray(int[] array) {  this.array = array; }

        public int[] GetArray() { return array;}

        public int BinarySearch(int x)
        {
            //x is searched value
            
            int left = 0;
            int right = array.Length-1;

            do
            {
                int mid = (left + right) / 2;
                if (array[mid] == x)
                {
                    return x;
                }
                else if (array[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            } while (left <= right);

            return -1;
        }

        public int[] InterchangeSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public int[] BoubleSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            return array;
        }

        public int[] SelectionSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int vtMin = MinPossition(i);
                int temp = array[vtMin];
                array[vtMin] = array[i];
                array[i] = temp;
            }
            return array;
        }

        private int MinPossition(int i)
        {
            int vtMin = i;
            for (int x = i; x < array.Length; x++)
            {
                if (array[vtMin] > array[x])
                {
                    vtMin = x;
                }
            }
            return vtMin;
        }

        public int[] InsertionSort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                int x = array[i];
                int pos = i - 1;
                while (pos >= 0 && array[pos] > x)
                {
                    array[pos + 1] = array[pos]; 
                    pos--;
                }
                array[pos+1] = x;
            }
            return array;
        }

        public void QuickSort(int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            int pivot = array[mid];
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            QuickSort(left, j);
            QuickSort(i, right);
        }


        public int[] ReturnArray()
        {
            return array;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Array: ");
            foreach (var item in array)
            {
                stringBuilder.Append(item + " ");
                
            }
            return stringBuilder.ToString();
        }
    }
}

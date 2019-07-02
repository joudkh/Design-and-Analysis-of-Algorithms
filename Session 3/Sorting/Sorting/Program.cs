using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        public static void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        public static void printArray(int [] arr)
        {
            foreach (int a in arr)
                Console.Write(a + " ");
            Console.Write("\n");
        }

        public static void bubbleSort(int [] arr)
        {

            for (int p = 0; p <= arr.Length - 2; p++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        swap(ref arr[i],ref arr[i + 1]);
                    }
                }
            }
        }

        public static void selectionSort(int[] arr)
        {
            //pos_min is short for position of min
            int pos_min;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    swap(ref arr[i], ref arr[pos_min]);
                }
            }
        }

        public static void insertionSort(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j;
                var insertionValue = arr[i];
                for (j = i; j > 0; j--)
                {
                    if (arr[j - 1] > insertionValue)
                    {
                        arr[j] = arr[j - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                arr[j] = insertionValue;
            }
        }

        static void Main(string[] args)
        {
            int[] inputArray = { 3, 0, 2, 5, -1, 4, 1 };
            printArray(inputArray);
            bubbleSort(inputArray);
            //insertionSort(inputArray);
            printArray(inputArray);
        }
    }
}
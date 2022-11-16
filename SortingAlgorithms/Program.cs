using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] bubbleSort =
                { 9, 1, 3, 5, 4, 2 };

            int[] selectionSort =
                { 6, 5, 8, 2, 3, 9 };

            int[] insertionSort =
                { 3, 5, 6, 8, 1, 2 };

            BubbleSort(bubbleSort);
            Console.WriteLine();

            SelectionSort(selectionSort);
            Console.WriteLine();

            InsertionSort(insertionSort);
        }

        #region BubbleSort

        public static void BubbleSort(int[] bubbleSort)
        {
            Console.WriteLine("This is the bubble sort:\nFrom: ");
            foreach (int start in bubbleSort)
            {
                Console.Write(start + " ");
            }
            Console.WriteLine();

            for (int sort = 0; sort < bubbleSort.Length - 1; sort++)
            {
                for (int sort2 = 0; sort2 < bubbleSort.Length - 1; sort2++)//Compare first for
                {
                    if (bubbleSort[sort2] > bubbleSort[sort2 + 1])//First is greater than second
                    {
                        int temp = bubbleSort[sort2];
                        bubbleSort[sort2] = bubbleSort[sort2 + 1];
                        bubbleSort[sort2 + 1] = temp;
                    }
                }
            }

            Console.WriteLine("To: ");

            foreach (int start in bubbleSort)
            {
                Console.Write(start + " ");
            }
        }

        #endregion BubbleSort

        #region SelectionSort

        public static void SelectionSort(int[] selectionSort)
        {
            Console.WriteLine("This is the selection sort:\nFrom:");
            foreach (int start in selectionSort)
            {
                Console.Write(start + " ");
            }
            Console.WriteLine();

            int smallest, temp;
            for (int sort = 0; sort < selectionSort.Length - 1; sort++)
            {
                smallest = sort;
                for (int sort2 = sort + 1; sort2 < selectionSort.Length - 1; sort2++)//Compare with next value
                {
                    if (selectionSort[sort2] < selectionSort[smallest])//Second number is smaller
                    {
                        temp = selectionSort[smallest];
                        selectionSort[smallest] = selectionSort[sort2];
                        selectionSort[sort2] = temp;
                    }
                }
            }

            Console.WriteLine("To: ");

            foreach (int start in selectionSort)
            {
                Console.Write(start + " ");
            }
        }

        #endregion SelectionSort

        #region InsertionSort

        public static void InsertionSort(int[] insertionSort)
        {
            Console.WriteLine("This is the insertion sort:\nFrom: ");
            foreach (int start in insertionSort)
            {
                Console.Write(start + " ");
            }
            Console.WriteLine();

            for (int sort = 0; sort < insertionSort.Length - 1; sort++)
            {
                for (int sort2 = sort + 1; sort2 > 0; sort2--)
                {
                    if (insertionSort[sort2 - 1] > insertionSort[sort2])
                    {
                        int temp = insertionSort[sort2 - 1];
                        insertionSort[sort2 - 1] = insertionSort[sort2];
                        insertionSort[sort2] = temp;
                    }
                }
            }

            Console.WriteLine("To: ");

            foreach (int start in insertionSort)
            {
                Console.Write(start + " ");
            }
        }

        #endregion InsertionSort
    }
}
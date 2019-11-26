using System;
namespace TestProject.sorting
{
    //https://www.geeksforgeeks.org/quick-sort/

    public class QuickSort
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Original Array {0}", string.Join(",", array));
            Sorting(array, 0, array.Length - 1);

        }

        private void Sorting(int[] input, int low, int high)
        {
            if(low < high)
            {
                int p = Partition(input, low, high);
                Sorting(input, low, p - 1);
                Sorting(input, p + 1, high);
            }
        }

        private int Partition(int[] input, int low, int high)
        {
            //int[] example = { 5, 30, 80, 45, 8 };
            int pivot = input[high];
            int counter = low - 1;

            for(int i = low; i< high; i++)
            {
                if(input[i] <= pivot)
                {
                    counter++;
                    int temp = input[i];
                    input[i] = input[counter];
                    input[counter] = temp;
                }
            }

            //Place pivot to right place
            int tempValue = input[counter + 1];
            input[counter + 1] = pivot;
            input[high] = tempValue;

            Console.WriteLine("Sorted Array {0}", string.Join(",", input));

            return counter++;

        }
    }
}

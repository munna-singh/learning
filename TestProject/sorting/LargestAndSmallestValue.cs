using System;
namespace TestProject.sorting
{
    public class LargestAndSmallestValue
    {
        public void LargestValue(int[] array, int n)
        {
            //Sort the array
            Sort(array);
            //Reverse the array for descending order and Get first n record
            ReverseArray(array);
            Console.WriteLine("Reversed array {0}", string.Join("-", array));
            //Get first n record
            int maxRecord = n > array.Length ? array.Length : n;
            for(int i =0; i< maxRecord; i++)
            {
                Console.WriteLine("Element {0} : {1}", i, array[i]);
            }
        }

        public void SmallestValue(int[] array, int n)
        {
            Sort(array);
            //Get first n record
            int maxRecord = n > array.Length ? array.Length : n;
            for (int i = 0; i < maxRecord; i++)
            {
                Console.WriteLine("Element {0} : {1}", i, array[i]);
            }

        }

        private void Sort(int[] array)
        {
            if(array != null && array.Length > 0)
            {
                DoSorting(array, 0, array.Length -1);
            }
        }

        private void DoSorting(int[] array,int low,int high)
        {
            if(low < high)
            {
                int parVal = Partition(array, low, high);
                DoSorting(array, low, parVal - 1);
                DoSorting(array, parVal + 1, high);
            }

            Console.WriteLine("Sorted array {0}", string.Join("-", array));
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int lowVal = low - 1;
            int[] testVal = { 1, 3, 6, 12, 43, 6, 20, 8 };
            for(int i = low; i< high; i++)
            {
                if(array[i] <= pivot)
                {
                    lowVal++;
                    //int temp = array[i];
                    //array[i] = array[lowVal];
                    //array[lowVal] = temp;
                    Swipe(array, i, lowVal);
                }
            }

            //Now place the pivot at end of the lowest value
            lowVal++;
            //int tempo = array[lowVal];
            //array[lowVal] = array[high];
            //array[high] = tempo;
            Swipe(array, lowVal, high);

            return lowVal;
        }

        private void Swipe(int[] array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        private void ReverseArray(int[] array)
        {
            int arrayIndex = array.Length - 1;
            for(int i =0; i< array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[arrayIndex - i];
                array[arrayIndex - i] = temp;
            }
        }
        
    }
}

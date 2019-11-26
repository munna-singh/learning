using System;
namespace TestProject
{
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            int[] tempArray = array;
            if (array != null && array.Length > 0)
            {
                Console.WriteLine("Original Array: {0}", string.Join("-", array));
                int len = array.Length - 1;
                for (int j = 0; j < len; j++)
                {
                    bool anyChange = false;
                    Console.WriteLine("current iteration {0}", j);
                    for (int i = 0; i < len; i++)
                    {
                        if (tempArray[i] > tempArray[i + 1])
                        {
                            int fElem = tempArray[i];
                            int lElem = tempArray[i + 1];
                            tempArray[i] = lElem;
                            tempArray[i + 1] = fElem;
                            anyChange = true;
                        }
                    }
                    Console.WriteLine("Sorted Array: {0}", string.Join("-", tempArray));
                    if (anyChange == false)
                    {
                        break;
                    }
                }

                //Reversed array
                tempArray = ReverseArray2(tempArray);
                Console.WriteLine("Reversed Sorted Array: {0}", string.Join("-", tempArray));

                //Get first 3 largetst item
                Console.WriteLine("Three largest elements: {0}, {1}, {2}", tempArray[0], tempArray[1], tempArray[2]);
            }
            
            
            
        }

        private int[] ReverseArray(int[] array)
        {
            int[] reversed = new int[array.Length];
            int counter = 0;
            for(int i = array.Length -1; i > 0; i--)
            {
                int a = array[i];
                reversed[counter] = array[i];
                counter++;
            }
            return reversed;
        }

        private int[] ReverseArray2(int[] array)
        {
            //int[] abc = { 1 - 1 - 1 - 1 - 2 - 2 - 2 - 2 - 2 - 2 - 2 - 4 - 4 - 4 - 4 - 4 - 4 - 4 - 4 };
            int[] tempArray = array;

            int length = tempArray.Length - 1;
            for(int i = 0; i<= length/2; i++)
            {
                int temp = tempArray[i];

                Console.WriteLine("Swaping {0} with {1} ", temp, tempArray[length - i]);
                tempArray[i] = tempArray[length - i];
                tempArray[length - i] = temp;
            }
            return tempArray;
        }
    }
}

using System;
namespace TestProject.sorting
{
    class Pair
    {
        public int Min = 0;
        public int Max = 0;
    }

    public class MinAndMax
    {
        public void MinMax(int[] array)
        {
            Pair pr = new Pair();
            if(array != null && array.Length > 0)
            {

                if(array[0] > array[1])
                {
                    pr.Min = array[1];
                    pr.Max = array[0];
                } else
                {
                    pr.Min = array[0];
                    pr.Max = array[1];
                }

                //Loop through all elements now
                for(int i = 2; i< array.Length; i++)
                {
                    if (array[i] < pr.Min)
                        pr.Min = array[i];
                    if (array[i] > pr.Max)
                        pr.Max = array[i];
                }
            }
            Console.WriteLine("Minimum value: {0} and Max value: {1}", pr.Min, pr.Max);
        }
    }
}

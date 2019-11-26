using System;
using TestProject.sorting;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Exercise!");

            //BubbleSorting();
            //MinAndMax();
            //QuickSort();
            //LargetElement();
            //SmallestElement();
            LinkedListQuickSort();





        }

        private static void LinkedListQuickSort()
        {
            QuickSortLinkedList llqs = new QuickSortLinkedList();
            llqs.AddNode(10);
            llqs.AddNode(30);
            llqs.AddNode(19);
            llqs.AddNode(3);
            llqs.AddNode(4);
            llqs.AddNode(80);
            llqs.AddNode(70);
            llqs.AddNode(20);
            llqs.AddNode(90);
            llqs.AddNode(40);

            llqs.Sort();
        }

        private static void SmallestElement()
        {
            //K Smallest value
            Console.Write("Please indicate number of lower element ");
            var count = Console.ReadLine();
            LargestAndSmallestValue lsV2 = new LargestAndSmallestValue();
            int p;
            int.TryParse(count, out p);
            lsV2.SmallestValue(new int[] { 10, 2, 40, 13, 14, 30, 50, 12 }, p);
        }

        private static void LargetElement()
        {
            //K Largest value
            Console.Write("Please indicate number of max element ");
            var name = Console.ReadLine();
            LargestAndSmallestValue lsV = new LargestAndSmallestValue();
            int n;
            int.TryParse(name, out n);
            lsV.LargestValue(new int[] { 10, 2, 40, 13, 14, 30, 50, 12 }, n);
        }

        private static void QuickSort()
        {
            ////Quick sort
            QuickSort qs = new QuickSort();
            qs.Sort(new int[] { 100, 2, 390, 0, 10, 30, 50, 12 });
            //qs.Sort(new int[] { 1, 4, 2, 4, 2, 4, 1, 2, 4, 1, 2, 2, 2, 2, 4, 1, 4, 4, 4 });
        }

        private static void MinAndMax()
        {
            //Min & Max
            MinAndMax mimx = new MinAndMax();
            mimx.MinMax(new int[] { 100, 2, 390, 0, 10, 30, 50, 12 });
        }
        private static void BubbleSorting()
        {
            //Bubble sort
            BubbleSort bs = new BubbleSort();
            bs.Sort(new int[] { 1, 4, 2, 4, 2, 4, 1, 2, 4, 1, 2, 2, 2, 2, 4, 1, 4, 4 });
        }
    }
}


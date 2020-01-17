﻿using System;

namespace sorting
{
    class BubbleSortArray
    {
        public static void BubbleSort(int[] list)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("BubbleSort startad");
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = 0; j < list.Length - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Utility.Swap(ref list[j], ref list[j + 1]);
                    }
                }
            }
            TimeSpan time = DateTime.Now - startTime;
            Console.WriteLine($"BubbleSort klar - Tid: {time.TotalSeconds}s");
            /*for (int n = 0; n < list.Length; n++)
            {
                Console.WriteLine(list[n]);
            }*/
        }
    }
}
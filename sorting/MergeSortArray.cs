﻿using System;

namespace sorting
{
    class MergeSortArray
    {
        public static int[] MergeSortStart(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
            return array;
        }
        private static void MergeSort(int[] input, int low, int high)
        {
            if (low < high) {
                int middle = (low / 2) + (high / 2);

                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }
        private static void Merge(int[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] temp = new int[(high - low) + 1];
            int tempIndex = 0;

            while (left <= middle && right <= high) {
                if (input[left] < input[right]) {
                    temp[tempIndex] = input[left];
                    left = left + 1;
                }
                else {
                    temp[tempIndex] = input[right];
                    right = right + 1;
                }
                tempIndex = tempIndex + 1;
            }

            if (left <= middle) {
                while (left <= middle) {
                    temp[tempIndex] = input[left];
                    left = left + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            if (right <= high) {
                while (right <= high) {
                    temp[tempIndex] = input[right];
                    right = right + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            for (int i = 0; i < temp.Length; i++)
                input[low + i] = temp[i];
        }
    }
}

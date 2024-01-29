using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    //Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    //The overall run time complexity should be O(log (m+n)).
    //Example 1:
    //Input: nums1 = [1,3], nums2 = [2]
    //Output: 2.00000
    //Explanation: merged array = [1, 2, 3] and median is 2.
    //Example 2:

    //Input: nums1 = [1,2], nums2 = [3,4]
    //    Output: 2.50000
    //Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.
    internal class LeetCodeProblem_4_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] fullArray = Merge(nums1, nums2);
            int length = fullArray.Length;
            if (length % 2 == 0)
                return (double)(fullArray[(length - 1) / 2] + fullArray[(length / 2)]) / 2;
            return (double)fullArray[length / 2];
        }
        internal int[] Merge(int[] nums1, int[] nums2)
        {
            int[] fullArray = new int[nums1.Length + nums2.Length];
            int i = 0; // for nums1
            int j = 0; // for nums2
            int k = 0; // for full array
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    fullArray[k] = nums1[i];
                    i++;
                }
                else
                {
                    fullArray[k] = nums2[j];
                    j++;
                }
                k++;
            }
            for (; i < nums1.Length; i++)
            {
                fullArray[k] = nums1[i];
                k++;
            }
            for (; j < nums2.Length; j++)
            {
                fullArray[k] = nums2[j];
                k++;
            }
            return fullArray;
        }
    }
}

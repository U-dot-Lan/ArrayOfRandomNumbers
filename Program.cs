using System;

namespace ArrayOfRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            ArrayValues.FillArray(nums1);
            ArrayValues.FillArray(nums2);
            ArrayValues.PrintIntersectValues(nums1, nums2);
            ArrayValues.PrintSumIntersectValues(nums1, nums2);
        }

        
    }
}

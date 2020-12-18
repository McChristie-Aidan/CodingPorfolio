using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    class Binary
    {
        Sort sort;
        public int doBinarySearch(int[] nums, int target)
        {
            Console.WriteLine("Performing Binary Search for " + target + ": \n");
            sort = new Sort();
            int[] sortedNums = sort.doBubbleSort(nums);

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                //to find the middle we add the rounded value of the left bound and right bound divided by 2
                int middle = Convert.ToInt32(Math.Floor((left + right) / 2d));
                Console.WriteLine("middle number: " + nums[middle]);

                //if the number in the middle is lower than the target...
                if (nums[middle] < target)
                {
                    right = middle - 1;
                }
                //if the number in the middle is higher than the target...
                else if (nums[middle] > target)
                {
                     left = middle + 1;
                }
                else
                {
                    return nums[middle];
                }
            }
            return 0;
        }
    }
}

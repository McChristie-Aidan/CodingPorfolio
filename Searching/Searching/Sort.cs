using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    class Sort
    {
        //Best Case and Worst Case: O(n^2) and O(n^2) 
        public int[] doBubbleSort(int[] nums)
        {
            //Console.WriteLine("Bubble sorted:\n");
            bool notSorted = true;

            while (notSorted)
            {
                notSorted = false;

                //for every item in our array
                for (int i = 1; i < nums.Length; i++)
                {
                    //if the current number is greater than the previous number...
                    if (nums[i] > nums[i - 1])
                    {
                        //swap the two numbers
                        int storage = nums[i];
                        nums[i] = nums[i - 1];
                        nums[i - 1] = storage;

                        notSorted = true;
                    }
                }
            }

            return nums;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class SelectionSort
    {
        //best case O(n^2)
        //worst case O(n^2)
        public void doSelectionSort(int[] nums)
        {
            Console.WriteLine("Selection sorted:\n");

            for (int i = 0; i < nums.Length; i++)
            {
                int minimum = i;
                //finds the smallest number in the array
                for(int x = i+1; x < nums.Length; x++)
                {
                    if (nums[x] < nums[minimum])
                    {
                        minimum = x;
                    }
                }

                //swaps the two items
                int temp = nums[minimum];
                nums[minimum] = nums[i];
                nums[i] = temp;
            }

            //prints the sorted list
            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }

            Console.ReadKey();
        }
    }
}

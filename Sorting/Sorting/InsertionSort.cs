using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class InsertionSort
    {
        public void doInsertionSort(int[] nums)
        {
            Console.WriteLine("insertion sorted:\n");

            for (int i = 1; i < nums.Length; i++)
            {
                //holds the current number
                int heldNum = nums[i];
                int j = i - 1;

                //moves numbers if they are greater than the current held number
                while (j >= 0 && nums[j] > heldNum)
                {
                    nums[j + 1] = nums[j];
                    j = j - 1; 
                }
                nums[j + 1] = heldNum;
            }

            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }

            Console.ReadKey();
        }
    }
}

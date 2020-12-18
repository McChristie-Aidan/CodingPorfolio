using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    class Linear
    {
        //This code goes through each item and checks if its what we're looking for
        //its more effcient for smaller data sets
        public void doLinearSearch(int[] nums, int target)
        {
            Console.WriteLine("Performing Linear Search for " + target + ": \n");
            //for each item in the array
            for (int i = 0; i < nums.Length; i++)
            {
                //if the current item = our target number...
                if(nums[i] == target)
                {
                    //print it to the console
                    Console.Write(nums[i] + " ");
                }
            }

            //this will tell us how many time a number appears in an array

            Console.ReadKey();
            Console.Clear();
        }
    }
}

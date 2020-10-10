using System;
using System.Collections.Generic;
using System.Text;

namespace FisherYatesShuffle
{
    public static class Shuffler
    {
        private static Random randomNumber = new Random();

        //call this from an array to shuffle it
        public static void FisherYatesShuffle(this int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //chooses the number that will be swaped with the current number
                int j = randomNumber.Next((nums.Length - i));
                //swaps the two numbers
                int temp = nums[i];
                nums[i] = nums[i+j];
                nums[i+j] = temp;
            }
        }
    }
}

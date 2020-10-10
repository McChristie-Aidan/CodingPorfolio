using System;

namespace FisherYatesShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates the array that will be shuffled
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            //Shuffles the array of numbers
            nums.FisherYatesShuffle();

            //this prints out our numbers
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

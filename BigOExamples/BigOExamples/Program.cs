using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOExamples
{
    class Program
    {
        List<string> line = new List<string>();
        List<int> nums = new List<int>();
        static void Main()
        {
        }

        // O(1)
        //this method is constant because no matter what you input it only has 1 action
        private void PrintFirstInLine(List<string> line)
        {
            Console.WriteLine(line[0]);
        }

        // O(n) or linear
        //this method is linear because the runtime gets longer of shorter depending on what you input for n
        private void PopulateList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums.Add(i+1);
                Console.WriteLine(i+1);
            }
        }

        // O(2^n)
        //this method is quadratic because it will walk through the entire list a number of times equal to the number of items in the list
        //therefore more its mean exponentially more time spent 
        private void NumCompare(List<int> nums)
        {
            foreach (int firstNum in nums)
            {
                foreach (int secondNum in nums)
                {
                    int result = firstNum;
                    if (firstNum < secondNum)
                    {
                        result = secondNum;
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}

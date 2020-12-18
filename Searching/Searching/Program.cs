using System;
using System.IO;

namespace Searching
{
    class Program
    {
        static void Main()
        {
            //this reads the content of our file
            string[] txtFile = File.ReadAllLines(@"scores.txt");
            //this converts it into int for us to use in our search
            int[] parseFile = new int[txtFile.Length];

            for (int i = 0; i < txtFile.Length; i++)
            {
                parseFile[i] = Int32.Parse(txtFile[i]);
            }

            //runs the linear search function
            Linear linear = new Linear();
            linear.doLinearSearch(parseFile, 65);

            //runs the binary search function
            Binary binary = new Binary();
            Console.WriteLine(binary.doBinarySearch(parseFile, 65));

            Console.ReadKey();
        }
    }
}

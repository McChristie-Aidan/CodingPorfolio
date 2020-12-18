using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] txtFile = File.ReadAllLines(@"scores.txt");
            int[] parseFile = new int[txtFile.Length];

            for (int i = 0; i < txtFile.Length; i++)
            {
                parseFile[i] = Int32.Parse(txtFile[i]);
            }

            BubbleSort bubble = new BubbleSort();
            bubble.doBubbleSort(parseFile);
            Console.Clear();

            InsertionSort insertion = new InsertionSort();
            insertion.doInsertionSort(parseFile);
            Console.Clear();
        }
    }
}

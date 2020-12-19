using System;
using System.Collections.Generic;
namespace StackVsQueue
{
    class Program
    {
        public void Main()
        {
            //the stacke is last in first out. which means what ever you retreive from the stack will be the last thing to be put in.
            string[] sentence = new string[] {"Hello", "world!", "How", "are", "you?" };
            Stack<string> helloStack = new Stack<string>();

            foreach(string word in sentence)
            {
                helloStack.Push(word);
                Console.WriteLine(word);
            }

            Console.WriteLine();

            foreach(string word in helloStack)
            {
                Console.WriteLine(word);

            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}

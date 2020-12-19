using System;
using System.Collections.Generic;

namespace StackVsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackExample();
            QueueExample();
        }

        static void StackExample()
        {
            //the stack is last in first out. which means what ever you retreive from the stack will be the last thing to be put in.
            //thats why when we read the output the sentence is backward
            string[] sentence = new string[] { "Hello", "world!", "How", "are", "you?" };
            Stack<string> helloStack = new Stack<string>();
            Console.WriteLine("Stack Example:");
            Console.WriteLine("Here is the input:");

            foreach (string word in sentence)
            {
                helloStack.Push(word);
                Console.WriteLine(word);
            }

            Console.WriteLine("\nHere is the output:");

            foreach (string word in helloStack)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        static void QueueExample()
        {
            //the queue is first in first out. This means whatever you put in first is the first to come out.
            //thats why our sentance still makes sense
            string[] sentence = new string[] { "Hello", "world!", "How", "are", "you?" };
            Queue<string> helloQueue = new Queue<string>();

            Console.WriteLine("Queue Example:");
            Console.WriteLine("Here is the input:");

            foreach (string word in sentence)
            {
                helloQueue.Enqueue(word);
                Console.WriteLine(word);
            }

            Console.WriteLine("\nHere is the output:");

            foreach (string word in helloQueue)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
    }
}

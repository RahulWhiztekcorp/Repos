using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueProgramsCollectionEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------- Queue ---------------------------");
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            foreach (var item in myQueue)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            //FIFO( First In First Out )
            //-----------------
            //| 1 | 2 | 3 | 4 |
            //-----------------
            //Enqueue(T)  Adds an item into the queue.
            //Peek()      Returns an first item from the queue without removing it.
            //Dequeue     Returns an item from the beginning of the queue and removes it from the queue.
            //Contains(T) Checks whether an item is in the queue or not
            //Clear()     Removes all the items from the queue.
            Console.WriteLine("myQueue.Peek() : " + myQueue.Peek());
            Console.WriteLine("myQueue.Count : " + myQueue.Count);
            Boolean sTrue = myQueue.Contains(2);
            Console.WriteLine("myQueue.Contains(2) : " + sTrue);
            Boolean sFalse = myQueue.Contains(10);
            Console.WriteLine("myQueue.Contains(10) : " + sFalse);
            Console.WriteLine("myQueue.Dequeue() : " + myQueue.Dequeue());
            foreach (var item in myQueue)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.Write("myQueue.Clear() : ");
            myQueue.Clear();

            if (myQueue.Count == 0)
            {
                Console.WriteLine("All myQueue Data Cleared");
            }
            else
            {
                foreach (var item in myQueue)
                {
                    Console.Write(item + ",");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            //OutPut : 
            //----------------------------Queue-------------------------- -
            //1,2,3,4,
            //myQueue.Peek() : 1
            //myQueue.Count : 4
            //myQueue.Contains(2) : True
            //myQueue.Contains(10) : False
            //myQueue.Dequeue() : 1
            //2,3,4,
            //myQueue.Clear() : All myQueue Data Cleared
            //--------------------------------------------------------------
        }
    }
}

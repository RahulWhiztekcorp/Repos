using System;
using System.Collections;
using System.Collections.Generic;

namespace StackProgramsCollectionEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------- Stack ---------------------------");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            //LIFO( Last In First Out ) 
            //-----------------
            //| 4 | 3 | 2 | 1 |
            //-----------------
            //Push(T)     Inserts an item at the top of the stack.
            //Peek()      Returns the top item from the stack.
            //Pop()       Removes and returns items from the top of the stack.
            //Contains(T) Checks whether an item exists in the stack or not.
            //Clear()     Removes all items from the stack.
            Console.WriteLine("myStack.Peek() : "+myStack.Peek());
            Console.WriteLine("myStack.Count : "+myStack.Count);
            Boolean sTrue = myStack.Contains(2);
            Console.WriteLine("myStack.Contains(2) : "+sTrue);
            Boolean sFalse = myStack.Contains(10);
            Console.WriteLine("myStack.Contains(10) : "+sFalse);
            Console.WriteLine("myStack.Pop() : " + myStack.Pop());
            foreach (var item in myStack)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.Write("myStack.Clear() : ");
            myStack.Clear();

            if (myStack.Count == 0)
            {
                Console.WriteLine("All myStack Data Cleared");
            }
            else
            {
                foreach (var item in myStack)
                {
                    Console.Write(item + ",");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");
            //OutPut : 
            //---------------------------- Stack ---------------------------
            //4,3,2,1,
            //myStack.Peek() : 4
            //myStack.Count : 4
            //myStack.Contains(2) : True
            //myStack.Contains(10) : False
            //myStack.Pop() : 4
            //3,2,1,
            //myStack.Clear() : All myStack Data Cleared
            //--------------------------------------------------------------
        }
    }
}

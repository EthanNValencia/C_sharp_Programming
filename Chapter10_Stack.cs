using System;
using System.Collections.Generic;
using System.Text;
/*
 * Example of a generic Stack/FIFO 
 */
namespace C_sharp_Programming
{
    class Chapter10_Stack // Example 10-24, pg 618
    {
        private object[] items;
        private int stackPointer = 0;
        
        public Chapter10_Stack(int size)
        {
            items = new object[size];
        }
        public object Pop()
        {
            return items[--stackPointer];
        }
        public void Push(object anItem)
        {
            items[stackPointer] = anItem;
            stackPointer++;
        }

        public int Size()
        {
            return items.Length;
        }


        public static void TestStackClass() // Example 10-25, pg 619
        {
            Chapter10_Stack stack = new Chapter10_Stack(5);
            stack.Push("Test");
            stack.Push(100);
            stack.Push(200);
            stack.Push(3.6);
            Console.Write("Values in the stack are: ");
            
            for (int i = 0; i < stack.Size()-1; i++)
            {
                object obj = stack.Pop();
                Console.Write("[Position {0}: {1}] ", i, obj.ToString());
            }
            
        }
    }
}

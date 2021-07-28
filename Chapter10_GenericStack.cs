using System;
using System.Collections.Generic;
using System.Text;
/*
 * This does what the Chapter10_Stack does, but it is generically written. 
 * Rather than using object it uses T.
 * 
 */
namespace C_sharp_Programming
{
    public class Chapter10_GenericStack<T>
    {
        private T[] items;
        private int stackPointer = 0;
        
        public Chapter10_GenericStack(int size)
        {
            items = new T[size];
        }
        public T Pop()
        {
            return items[--stackPointer];
        }
        public void Push(T anItem)
        {
            items[stackPointer] = anItem;
            stackPointer++;
        }
        public int Size()
        {
            return items.Length;
        }
        public static void TestGenericStackClass() // Example 10-25, pg 619
        {
            Chapter10_GenericStack<object> stack = new Chapter10_GenericStack<object>(5);
            stack.Push("Test");
            stack.Push(100);
            stack.Push(200);
            stack.Push(3.6);
            Console.Write("Values in the stack are: ");

            for (int i = 0; i < stack.Size() - 1; i++)
            {
                object obj = stack.Pop();
                Console.Write("[Position {0}: {1}] ", i, obj.ToString());
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace SavannahInformaticsStackAssigment
{
    class Program
    {

        // Pushing an element on the top of the stack
        static void stack_push(Stack<int> stack)
        {
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
        }
        // Popping an element from the top of the stack
        static void stack_pop(Stack<int> stack)
        {
            Console.WriteLine("Pop :");

            for (int i = 0; i < 10; i++)
            {
                int y = (int)stack.Pop();
                Console.WriteLine(y);
            }
        }
        // Displaying an element on the top of the stack
        static void stack_peek(Stack<int> stack)
        {
            int element = (int)stack.Peek();
            Console.WriteLine("Element on stack top : " + element);
        }

        // Searching an element in the stack
        static void stack_search(Stack<int> stack, int element)
        {
            bool pos = stack.Contains(element);

            if (pos == false)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element is found at position " + pos);
        }

        //Engine Code.
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack_push(stack);
            stack_pop(stack);
            stack_push(stack);
            stack_peek(stack);
            stack_search(stack, 2);
            stack_search(stack, 11);
        }
    }
}

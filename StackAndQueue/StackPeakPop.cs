using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public  class StackPeakPop
    {
        public void Display()
        {

            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Display peek value");

            stack.Peek();
            Console.WriteLine("The Peek element is " + stack.Peek());

            stack.Pop();
            Console.WriteLine("After popped");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine("After popped");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine("After popped");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Stack Empty");
        }
    }
}

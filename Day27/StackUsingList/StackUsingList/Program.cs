using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingList
{
    public class StackExample
    {
        private List<int> stackList = new List<int>();

        public void Push(int value)
        {
            stackList.Add(value);
            Console.WriteLine($"{value} pushed to stack.");
        }

        public int Pop()
        {
            if (stackList.Count == 0)
                throw new InvalidOperationException("Cannot pop from an empty stack.");

            int value = stackList[stackList.Count - 1];
            stackList.RemoveAt(stackList.Count - 1);
            Console.WriteLine($"{value} popped from stack.");
            return value;
        }

        public int Peek()
        {
            if (stackList.Count == 0)
                throw new InvalidOperationException("Cannot peek an empty stack.");

            int value = stackList[stackList.Count - 1];
            Console.WriteLine($"{value} is on top of the stack.");
            return value;
        }

        public bool IsEmpty() => stackList.Count == 0;

        public void Display()
        {
            if (stackList.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = stackList.Count - 1; i >= 0; i--)
                Console.WriteLine(stackList[i]);
        }
    }

    public class Program
    {
        public static void Main()
        {
            StackExample stack = new StackExample();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Peek();

            stack.Display();

            stack.Pop();
            stack.Display();
        }
    }
}

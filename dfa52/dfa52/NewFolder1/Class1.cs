using System;

namespace ConsoleApp7.Stacks
{
    public class StackArray
    {
        private int[] stack;
        private int top;

        public StackArray(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public bool IsEmpty() => top == -1;
        public bool IsFull() => top == stack.Length - 1;

        public void Push(int item)
        {
            if (IsFull())
                Console.WriteLine("Stack is full.");
            else
                stack[++top] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            return stack[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            return stack[top];
        }
    }
}
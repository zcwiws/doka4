namespace ConsoleApp7.Stacks
{
    public class StackMin
    {
        private StackArray stack;
        private StackArray minStack;

        public StackMin(int size)
        {
            stack = new StackArray(size);
            minStack = new StackArray(size);
        }

        public void Push(int item)
        {
            stack.Push(item);
            if (minStack.IsEmpty() || item <= minStack.Peek())
                minStack.Push(item);
        }

        public int Pop()
        {
            int item = stack.Pop();
            if (item == minStack.Peek())
                minStack.Pop();
            return item;
        }

        public int GetMin() => minStack.Peek();
    }
}
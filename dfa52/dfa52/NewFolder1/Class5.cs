namespace ConsoleApp7.Stacks
{
    public class StackReverseArray
    {
        public static int[] Reverse(int[] arr)
        {
            StackArray stack = new StackArray(arr.Length);
            foreach (int num in arr)
                stack.Push(num);

            for (int i = 0; i < arr.Length; i++)
                arr[i] = stack.Pop();

            return arr;
        }
    }
}
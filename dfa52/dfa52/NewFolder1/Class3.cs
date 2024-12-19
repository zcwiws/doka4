namespace ConsoleApp7.Stacks
{
    public class StackPalindrome
    {
        public static bool IsPalindrome(string str)
        {
            StackArray stack = new StackArray(str.Length);
            foreach (char c in str)
                stack.Push(c);

            foreach (char c in str)
                if (stack.Pop() != c)
                    return false;

            return true;
        }
    }
}
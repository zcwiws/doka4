namespace ConsoleApp7.Stacks
{
    public class StackParentheses
    {
        public static bool AreParenthesesBalanced(string expression)
        {
            StackArray stack = new StackArray(expression.Length);
            foreach (char c in expression)
            {
                if (c == '(')
                    stack.Push(c);
                else if (c == ')')
                {
                    if (stack.IsEmpty())
                        return false;
                    stack.Pop();
                }
            }
            return stack.IsEmpty();
        }
    }
}
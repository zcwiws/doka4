namespace ConsoleApp7.Stacks
{
    public class StackPostfixNotation
    {
        public static int Evaluate(string postfix)
        {
            StackArray stack = new StackArray(postfix.Length);

            foreach (char c in postfix)
            {
                if (char.IsDigit(c))
                    stack.Push(c - '0');
                else
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    switch (c)
                    {
                        case '+': stack.Push(a + b); break;
                        case '-': stack.Push(a - b); break;
                        case '*': stack.Push(a * b); break;
                        case '/': stack.Push(a / b); break;
                    }
                }
            }

            return stack.Pop();
        }
    }
}

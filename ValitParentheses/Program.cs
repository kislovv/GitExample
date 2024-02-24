Stack<char> stack = new Stack<char>();

string input = "{{{()}}}((()))";

if (IsCorrectParentheses(input))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


bool IsCorrectParentheses(string input)
{
    if (!IsFirstValide(input[0]))
    {
        return false;
    }
    char[] opens = new[] { '(', '[', '<', '{' };
    List<char> closes = new List<char>(){ ')', ']', '>', '}' };

    for (int i = 0; i < input.Length; i++)
    {
        if (opens.Contains(input[i]))
        {
            stack.Push(input[i]);
        }
        else if (stack.Count != 0)
        {
            int index = closes.IndexOf(input[i]);

            if (opens[index] != stack.Pop())
                return false;
        }
        else
        {
            return false;
        }
    }

    return stack.Count == 0;
}


bool IsFirstValide(char firstChar)
{
    return !(new char[] { '}', ']', ')', '>' }.Contains(firstChar));
}
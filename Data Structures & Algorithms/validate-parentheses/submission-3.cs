public class Solution {
    public bool IsValid(string s) {
        char[] openingChars = new char[] { '(', '{', '[' };
        char[] closingChars = new char[] { ')', '}', ']' };

        Stack<char> charStack = new Stack<char>();
        foreach (char c in s) {
            if (openingChars.Contains(c)) {
                charStack.Push(c);
            } else {
                if (charStack.Count>0 && openingChars[Array.IndexOf(closingChars, c)] == charStack.Peek() ) {
                    charStack.Pop();
                } else {
                    return false;
                }
            }
        }
        if (charStack.Count == 0) {
            return true;
        } else {
            return false;
        }
    }
}

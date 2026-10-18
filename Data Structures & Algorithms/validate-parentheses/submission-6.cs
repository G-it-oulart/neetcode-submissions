public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 > 0) {
            return false;
        }
        Dictionary<char, char> charDict = new Dictionary<char, char>();
        charDict[')'] = '(';
        charDict[']'] = '[';
        charDict['}'] = '{';
        Stack<char> charStack = new Stack<char>();
        foreach (char c in s) {
            if (!charDict.ContainsKey(c)) {
                charStack.Push(c);
            } else {
                if (charStack.Count > 0 && charDict[c] == charStack.Peek()) {
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

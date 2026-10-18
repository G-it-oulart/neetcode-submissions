public class Solution {
    List<string> res = new List<string>();
    public List<string> GenerateParenthesis(int n) {
        MakeCombinations(n, new List<char>(), 0, 0);
        return res;
    }
    public void MakeCombinations(int n, List<char> chars, int openLimit, int closeLimit) {
        if (closeLimit > openLimit) {
            return;
        }
        if (chars.Count == n * 2) {
            res.Add(new string(chars.ToArray()));
            return;
        }
        if(openLimit<n){
            chars.Add('(');
            MakeCombinations(n, chars, openLimit + 1, closeLimit);
            chars.RemoveAt(chars.Count - 1);
        }
        chars.Add(')');
        MakeCombinations(n, chars, openLimit, closeLimit + 1);
        chars.RemoveAt(chars.Count - 1);
    }
}

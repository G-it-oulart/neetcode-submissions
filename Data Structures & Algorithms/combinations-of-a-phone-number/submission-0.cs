public class Solution {
    List<string> res = new List<string>();
    Dictionary<char, char[]> digitMap =
        new Dictionary<char, char[]>() { { '2', ['a', 'b', 'c'] }, { '3', ['d', 'e', 'f'] },
                                         { '4', ['g', 'h', 'i'] }, { '5', ['j', 'k', 'l'] },
                                         { '6', ['m', 'n', 'o'] }, { '7', ['p', 'q', 'r', 's'] },
                                         { '8', ['t', 'u', 'v'] }, { '9', ['w', 'x', 'y', 'z'] } };

    public List<string> LetterCombinations(string digits) {
        makeCombinations(digits, 0, new List<char>());
        return res;
    }

    public void makeCombinations(string digits, int index, List<char> combination) {
        if(digits.Length==0){
            return;
        }
        if (index == digits.Length) {
            string combinationStr = new string(combination.ToArray());
            res.Add(combinationStr);
            return;
        }
        for (int i = 0; i < digitMap[digits[index]].Length; i++) {
            combination.Add(digitMap[digits[index]][i]);
            makeCombinations(digits, index + 1, combination);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}

public class Solution {
    List<List<string>> res = new List<List<string>>();
    public List<List<string>> Partition(string s) {
        makePalindromes(s, 0, new List<string>());
        return res;
    }

    public void makePalindromes(string s, int index, List<string> palindromes) {
        if (index == s.Length) {
            List<string> palindromesCopy = new List<string>(palindromes);
            res.Add(palindromesCopy);
            return;
        }
        List<char> possiblePalindrome = new List<char>();
        for (int i = index; i < s.Length; i++) {
            possiblePalindrome.Add(s[i]);
            string possiblePalindromeStr = new string(possiblePalindrome.ToArray());
            if (IsPalindrome(possiblePalindromeStr)){
                palindromes.Add(possiblePalindromeStr);
                makePalindromes(s, i+1, palindromes);
                palindromes.RemoveAt(palindromes.Count-1);
            }
        }
    }
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

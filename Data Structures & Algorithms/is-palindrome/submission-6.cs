public class Solution {
    public bool IsPalindrome(string s) {
        int lastHalf = s.Length-1;
        int firstHalf = 0;
        while(firstHalf<lastHalf){
            while(firstHalf < lastHalf && !char.IsLetterOrDigit(s[firstHalf])){
                firstHalf++;
            }
            while(firstHalf< lastHalf && !char.IsLetterOrDigit(s[lastHalf])){
                lastHalf--;
            }
            if(char.ToLower(s[firstHalf++]) != char.ToLower(s[lastHalf--])){
                return false;
            }
        }
        return true;
    }
}
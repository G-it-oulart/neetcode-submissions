public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longest = 0;
        int left = 0;
        HashSet<char> charSet = new HashSet<char>();
        for(int i =0;i<s.Length;i++){
            if (!charSet.Contains(s[i])){
                charSet.Add(s[i]);
            } else{
                longest = Math.Max(longest,i-left);
                while(s[left]!=s[i]){
                    charSet.Remove(s[left]);
                    left++;
                }
                left++;
            }
        }
        longest = Math.Max(longest,s.Length-left);
        if(charSet.Count==s.Length){
            return s.Length;
        }
        return longest;
    }
}

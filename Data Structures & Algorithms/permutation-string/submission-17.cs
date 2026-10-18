public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] charCounts = new int[26];
        int[] charCountsCheck = new int[26];
        int left = 0;
        int right = 0;
        int currentCharCount = 0;
        int originalDifferentChars = 0;
        int filledChars = 0;
        for(int i =0;i<s1.Length;i++){
            if(charCounts[s1[i]-'a']==0){
                originalDifferentChars++;
            }
            charCounts[s1[i]-'a']++;
        }
        while(right<s2.Length){
            if(right-left+1>s1.Length){
                charCountsCheck[s2[left]-'a']--;
                currentCharCount = charCountsCheck[s2[left]-'a'];
                if(currentCharCount+1 == charCounts[s2[left]-'a'] && currentCharCount != charCounts[s2[left]-'a']){
                    filledChars--;
                }
                left++;
            }
            charCountsCheck[s2[right]-'a']++;
            currentCharCount = charCountsCheck[s2[right]-'a'];
            if(currentCharCount-1 != charCounts[s2[right]-'a'] && currentCharCount == charCounts[s2[right]-'a']){
                filledChars++;
            }
            if(filledChars==originalDifferentChars){
                return true;
            }
            right++;
        }
        return false;
    }
}
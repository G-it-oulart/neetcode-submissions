public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] chars = new int[26];
        int left = 0;
        int right = 0;
        int max = 0;
        int currentCount = 0;
        int currentLength = 0;
        int maxLength = 0;
        while(right<s.Length){
            chars[s[right]-'A']++;
            currentCount = chars[s[right]-'A'];
            if(currentCount > max){
                max = currentCount;
            }
            currentLength = right-left+1;
            while(currentLength-max > k){
                chars[s[left]-'A']--;
                left++;
                currentLength = right-left+1;
            } 
            if(currentLength > maxLength){
                maxLength = currentLength;
            }
            right++;
            }
            return maxLength;
        }
    }

public class Solution {
    Dictionary<char, int> tCharCounts = new Dictionary<char, int>();
    Dictionary<char, int> sCharCounts = new Dictionary<char, int>();
    string smallestString = "";
    int left = 0;
    int right = 0;
    public string MinWindow(string s, string t) {
        int originalCharCount = 0;
        int filledChars = 0;
        int tCount = 0;
        foreach (char c in t) {
            if (!tCharCounts.ContainsKey(c)) {
                originalCharCount++;
                tCharCounts[c] = 1;
            } else {
                tCharCounts[c]++;
            }
        }
        while (right < s.Length) {
            if (tCharCounts.ContainsKey(s[right])) {
                tCount = tCharCounts[s[right]];
            } else {
                tCount = 0;
            }
            if (tCount == 0) {
                right++;
                continue;
            }
            if (tCount > 0) {
                if (!sCharCounts.ContainsKey(s[right])) {
                    sCharCounts[s[right]] = 1;
                } else {
                    sCharCounts[s[right]]++;
                }
                if (sCharCounts[s[right]] == tCount) {
                    filledChars++;
                }
                if (filledChars == originalCharCount) {
                    while ((tCharCounts.ContainsKey(s[left]) &&
                            sCharCounts[s[left]] > tCharCounts[s[left]]) ||
                           !sCharCounts.ContainsKey(s[left])) {
                        if (tCharCounts.ContainsKey(s[left]) && tCharCounts[s[left]] > 0) {
                            sCharCounts[s[left]]--;
                        }
                        left++;
                    }
                    string currentValid = s.Substring(left, right - left + 1);
                    if (smallestString == "") {
                        smallestString = currentValid;
                    } else if (currentValid.Length < smallestString.Length) {
                        smallestString = currentValid;
                    }
                }
                right++;
            }
        }
        return smallestString;
    }
}

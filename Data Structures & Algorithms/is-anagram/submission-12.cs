public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToArray();
        char[] tArray = t.ToArray();
        Dictionary<char,int> stringDict = new Dictionary<char,int>();
        if(s.Length != t.Length){
            return false;
        }
        foreach(char c in sArray){
            if(!stringDict.ContainsKey(c)){
                stringDict.Add(c,0);
            }
            if (stringDict.ContainsKey(c)){
                stringDict[c] = stringDict[c]+1;
            }
        }
        foreach(char c in tArray){
            if(stringDict.ContainsKey(c)){
                stringDict[c] = stringDict[c] -1;
            } else{
                return false;
            }
            if (stringDict[c]<0){
                return false;
            }
            }
        return true;
        }
    }
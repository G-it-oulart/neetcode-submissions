public class Solution {
    public bool IsAnagram(string s, string t) {
        HashSet<char> sHash = new HashSet<char>(s);
        HashSet<char> tHash = new HashSet<char>(t);
        char[] sArray = s.ToArray();
        char[] tArray = t.ToArray();
        Dictionary<char,int> stringDict = new Dictionary<char,int>();
        if(s.Length != t.Length){
            return false;
        }
        foreach(char c in sHash){
            if(!stringDict.ContainsKey(c)){
                stringDict.Add(c,0);
            }
        }
        foreach(char c in sArray){
            if (stringDict.ContainsKey(c)){
                stringDict[c] = stringDict[c]+1;
            }
        }
        foreach(char c in tArray){
            if(stringDict.ContainsKey(c)){
                stringDict[c] = stringDict[c] -1;
            } else{
                stringDict.Add(c,-1);
            }
            if (stringDict[c]<0){
                return false;
            }
            }
        foreach(int val in stringDict.Values){
            if(val==-1){
                return false;
            }
        }
        return true;
        }
    }
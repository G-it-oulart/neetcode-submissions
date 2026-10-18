public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> strDict = new Dictionary<string,List<string>>();
        for(int i = 0;i<strs.Length;i++){
            int[] strKey = new int[26];
            int count =0;
            foreach(char c in strs[i]){
                strKey[c-'a']++;
            }
            string convStrKey = string.Join(",",strKey);
            if(strDict.ContainsKey(convStrKey)){
                strDict[convStrKey].Add(strs[i]);
            }else{
                strDict[convStrKey] = new List<string> {strs[i]};
            }
        }
        return new List<List<string>>(strDict.Values);
    }
}
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dictAnagrams = new Dictionary<string,List<string>>();
        List<List<string>> answer = new List<List<string>>();
        foreach(string str in strs){
            char[] charStr = str.ToCharArray();
            Array.Sort(charStr);
            string sortedStr = new string(charStr);
            if(!dictAnagrams.ContainsKey(sortedStr)){
                dictAnagrams[sortedStr] = new List<string>();
            }
            dictAnagrams[sortedStr].Add(str);
        }
        foreach(var kvp in dictAnagrams){
            answer.Add(kvp.Value);
        }
        return answer;
    }
}

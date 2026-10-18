public class Solution {
    public string Encode(IList<string> strs) {
        string aggregatedStrings = "";
        foreach (string str in strs){
            aggregatedStrings+=str.Length + "#" + str;
        }
        return aggregatedStrings;
    }
    public List<string> Decode(string s) {
        string str = "";
        string length ="";
        List<string> answer = new List<string>();
        for(int i = 0; i<s.Length;i++){
            if(char.IsDigit(s[i])){
                length+=s[i];
            } else if(s[i] == '#'){
                for(int charIndex = i+1; charIndex < int.Parse(length)+i+1;charIndex++){
                    str+=s[charIndex];
                }
                answer.Add(str);
                i+=int.Parse(length);
                length = "";
                str="";
            }
        }
        return answer;
   }
}
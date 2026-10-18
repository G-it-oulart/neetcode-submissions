public class Solution {
    public bool IsAnagram(string s, string t) {
        string sSorted = new string(s.OrderBy(c=>c).ToArray());
        string tSorted = new string(t.OrderBy(c=>c).ToArray());
        if(sSorted==tSorted){
            return true;
        }
        return false;
    }
}
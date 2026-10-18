public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashNums = new HashSet<int>(nums);
        if (hashNums.Count != nums.Length){
            return true;
        } else{
            return false;
        }
    }
}
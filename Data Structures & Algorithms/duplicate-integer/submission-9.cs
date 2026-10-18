public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashNums = new HashSet<int>();
        for(int i =0;i<nums.Length;i++){
                if(hashNums.Contains(nums[i])){
                        return true;
                } else{
                hashNums.Add(nums[i]);
                }
        }
        return false;
    }
}
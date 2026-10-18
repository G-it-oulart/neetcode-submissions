public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> validNumbers = new List<int>();
        if (nums.Length==0){
            return false;
        } else{
        validNumbers.Add(nums[0]);
        }
        for(int i = 1;i<nums.Length;i++){
            if(validNumbers.Contains(nums[i])){
                return true;
            } else{
                validNumbers.Add(nums[i]);
            }
        }
        return false;
    }
}
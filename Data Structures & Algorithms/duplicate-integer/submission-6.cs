public class Solution {
    public bool hasDuplicate(int[] nums) {
        int dupCounter=0;
        List<int> validNumbers = new List<int>();
        if (nums.Length==0){
            return false;
        } else{
        validNumbers.Add(nums[0]);
        }
        for(int i = 1;i<nums.Length;i++){
            if(nums[i]==nums[i-1] || validNumbers.Contains(nums[i])){
                dupCounter+=1;
            } else{
                validNumbers.Add(nums[i]);
            }
        }
        return dupCounter>0;
    }
}
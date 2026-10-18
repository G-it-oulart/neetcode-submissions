public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dictSomas = new Dictionary<int,int>();
        for(int i = 0;i<nums.Length;i++){
            int complement= target-nums[i];
            if(dictSomas.ContainsKey(complement)){
                return new int[] {dictSomas[complement],i};
            }
            dictSomas[nums[i]]=i;
        }
        return new int[]{0};
    }
}
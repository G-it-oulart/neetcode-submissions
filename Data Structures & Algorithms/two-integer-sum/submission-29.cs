public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            numsDict[target - nums[i]] = i;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (numsDict.ContainsKey(nums[i]) && numsDict[nums[i]]!=i) {
                return new int[] { i, numsDict[nums[i]] };
            }
        }
        return new int[] {};
    }
}
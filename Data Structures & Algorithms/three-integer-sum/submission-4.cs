public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int start = 0;
        int end = nums.Length - 1;
        List<List<int>> listOfLists = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int target = 0 - nums[i];
            start = i + 1;
            end = nums.Length - 1;
            while (start < end) {
                if (nums[start] + nums[end] < target) {
                    start++;
                } else if (nums[start] + nums[end] > target) {
                    end--;
                } else if (nums[start] + nums[end] == target) {
                    listOfLists.Add(new List<int> { nums[i], nums[start], nums[end] });
                    start++;
                    while(start < end && nums[start] == nums[start - 1]) {
                        start++;
                    }
                }
            }
        }
        return listOfLists;
    }
}
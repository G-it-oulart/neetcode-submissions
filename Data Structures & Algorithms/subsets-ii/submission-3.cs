public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>();
        List<int> subset = new List<int>();
        formSubsets(nums, 0, res, subset);
        return res;
    }

    public void formSubsets(int[] nums, int index, List<List<int>> res, List<int> subset) {
        if (index == nums.Length) {
            List<int> newSubset = new List<int>(subset);
            res.Add(newSubset);
            return;
        }
        subset.Add(nums[index]);
        formSubsets(nums, index + 1, res, subset);
        subset.RemoveAt(subset.Count-1);
        int nextIndex = index+1;
        while(nextIndex < nums.Length && nums[nextIndex]==nums[index]){
            nextIndex++;
        }
        formSubsets(nums,nextIndex,res,subset);
    }
}

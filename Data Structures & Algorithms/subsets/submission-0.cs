public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        List<int> subset = new List<int>();
        formSubSets(nums,0,res,subset);
        return res;
    }
    public void formSubSets(int[] nums,int index, List<List<int>> res, List<int> subset){
        if(index==nums.Length){
            res.Add(subset);
            return;
        }
        List<int> includeSubset = new List<int>(subset);
        includeSubset.Add(nums[index]);
        formSubSets(nums,index+1,res,includeSubset);
        List<int> excludeSubset = new List<int>(includeSubset);
        excludeSubset.RemoveAt(excludeSubset.Count-1);
        formSubSets(nums,index+1,res,excludeSubset);
    }
}

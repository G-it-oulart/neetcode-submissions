public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<int> combination = new List<int>();
        for(int i = 0; i<nums.Length;i++){
            makeCombinations(nums,res,combination,i,target,0);
        }
        return res;
    }

    public void makeCombinations(int[] nums, List<List<int>> res, List<int> combination, int index, int target,int currentSum){
        List<int> newCombination = new List<int>(combination);
        int newCurrentSum = currentSum;
        if(currentSum+nums[index]==target){
            newCombination.Add(nums[index]);
            res.Add(newCombination);
            return;
        } else if(currentSum+nums[index]<target){
            newCombination.Add(nums[index]);
            newCurrentSum+=nums[index];
            for(int i = index; i<nums.Length;i++){
                makeCombinations(nums,res,newCombination,i,target,newCurrentSum);
            }
        } else{
            return;
        }
    }
}

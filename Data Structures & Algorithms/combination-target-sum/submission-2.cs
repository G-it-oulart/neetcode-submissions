public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<int> combination = new List<int>();
        for(int i = 0; i<nums.Length;i++){
            makeCombinations(nums,res,combination,i,target,0);
            combination.Clear();
        }
        return res;
    }

    public void makeCombinations(int[] nums, List<List<int>> res, List<int> combination, int index, int target,int currentSum){
        int newCurrentSum = currentSum;
        combination.Add(nums[index]);
        if(currentSum+nums[index]==target){
            List<int> newCombination = new List<int>(combination);
            res.Add(newCombination);
            return;
        } else if(currentSum+nums[index]<target){
            newCurrentSum+=nums[index];
            for(int i = index; i<nums.Length;i++){
                makeCombinations(nums,res,combination,i,target,newCurrentSum);
                combination.RemoveAt(combination.Count-1);
            }
        } else{
            return;
        }
    }
}

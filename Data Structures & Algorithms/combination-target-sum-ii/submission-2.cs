public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        for(int i = 0; i< candidates.Length;i++){
            if(i-1>-1 && candidates[i]==candidates[i-1]){
                continue;
            }
            makeCombinations(candidates,res,new List<int>(),i,target,0);
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
            
            for(int i = index+1; i<nums.Length;i++){
                if(i-1>index && nums[i]==nums[i-1]){
                    continue;
                }
                makeCombinations(nums,res,combination,i,target,newCurrentSum);
                combination.RemoveAt(combination.Count-1);
            }
        } else{
            return;
        }
    }
}
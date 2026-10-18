public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0){
            return 0;
        }
        HashSet<int> numsSet = new HashSet<int>(nums);
        List<int> beginningNums = new List<int>();
        List<int> sequences = new List<int>();
        foreach(int num in nums){
            if (!numsSet.Contains(num-1)){
                beginningNums.Add(num);
            }
        }
        for(int i = 0;i<beginningNums.Count;i++){
            int count = 0;
            int current = beginningNums[i];
            while(numsSet.Contains(current)){
                current++;
                count++;
            }
            sequences.Add(count);
        }
        return sequences.Max();
    }
}

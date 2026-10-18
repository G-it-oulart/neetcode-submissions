public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> numsDictionary = new Dictionary<int,int>();
        foreach(int num in nums){
            if (!numsDictionary.ContainsKey(num)){
                numsDictionary[num] = 1;
            } else{
                numsDictionary[num] ++;
            }
        }
        return numsDictionary.OrderByDescending(x=> x.Value).Take(k).Select(x=> x.Key).ToArray();
    }
}
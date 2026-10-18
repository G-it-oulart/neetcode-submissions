public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> numsDictionary = new Dictionary<int,int>();
        List<KeyValuePair<int,int>> kvpList = new List<KeyValuePair<int,int>>();
        List<int> answer = new List<int>();
        foreach(int num in nums){
            if (!numsDictionary.ContainsKey(num)){
                numsDictionary[num] = 1;
            } else{
                numsDictionary[num] +=1;
            }
        }
        foreach (var kvp in numsDictionary){
            kvpList.Add(new KeyValuePair<int,int>(kvp.Key,kvp.Value));
        }
        kvpList.Sort((x,y)=> y.Value.CompareTo(x.Value));

        for(int i = 0;i<k;i++){
            answer.Add(kvpList[i].Key);
        }
        return (answer.ToArray());
    }
}
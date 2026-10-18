public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> numsDictionary = new Dictionary<int,int>();
        List<int> answer = new List<int>();
        int greatestOccurrence = 0;
        foreach(int num in nums){
            if (!numsDictionary.ContainsKey(num)){
                numsDictionary[num] = 1;
            } else{
                numsDictionary[num] +=1;
            }
            if (numsDictionary[num] > greatestOccurrence){
                greatestOccurrence = numsDictionary[num];
            }
        }
        List<int>[] bucketArray = new List<int>[greatestOccurrence+1];
        for(int i = 0; i<=greatestOccurrence;i++){
            bucketArray[i] = new List<int>();
        }
        foreach(var kvp in numsDictionary){
            bucketArray[kvp.Value].Add(kvp.Key);
        }
        for(int i = greatestOccurrence;i>=0;i--){
            foreach(int value in bucketArray[i]){
                answer.Add(value);
                if (answer.Count==k){
                    return answer.ToArray();
                }
            }
        }
        return answer.ToArray();
    }
}
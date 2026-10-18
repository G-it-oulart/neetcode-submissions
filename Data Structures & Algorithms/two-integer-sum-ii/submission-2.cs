public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int end = numbers.Length-1;
        for(int i =0;i<numbers.Length;){
            if(numbers[i]+numbers[end]==target){
                return new int[]{i+1,end+1};
            } else if(numbers[i]+numbers[end]<target){
                i++;
            } else{
                end--;
            }
        }
        return new int[]{};
    }
}
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Array.Sort(numbers);
        for(int i =0;i<numbers.Length;i++){
            int searchComplement = Array.BinarySearch(numbers,target-numbers[i]);
            if(searchComplement >0){
                return new int[]{i+1,searchComplement+1};
            };
        }
        return new int[]{};
    }
}


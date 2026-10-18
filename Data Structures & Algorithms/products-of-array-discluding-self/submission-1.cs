public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] reversedNums = (int[])nums.Clone();
        Array.Reverse(reversedNums);
        int arraySize = nums.Length;
        List<int> leftToRightMultiplications = new List<int>();
        List<int> rightToLeftMultiplications = new List<int>();
        List<int> totalMultiplicationsExcludingCurrent = new List<int>();

        int storedMultiplication = 1;

        for(int i = 0; i<nums.Length;i++){
            storedMultiplication *= nums[i];
            leftToRightMultiplications.Add(storedMultiplication);
        }

        storedMultiplication = 1;

        for(int i = 0; i<reversedNums.Length;i++){
            storedMultiplication *= reversedNums[i];
            rightToLeftMultiplications.Add(storedMultiplication);
        }

        totalMultiplicationsExcludingCurrent.Add(rightToLeftMultiplications[nums.Length-2]);

        for(int i =1; i<nums.Length-1;i++){
            totalMultiplicationsExcludingCurrent.Add(leftToRightMultiplications[i-1]*rightToLeftMultiplications[nums.Length-i-2]);
        }

        totalMultiplicationsExcludingCurrent.Add(leftToRightMultiplications[nums.Length-2]);

        return totalMultiplicationsExcludingCurrent.ToArray();
    }
}
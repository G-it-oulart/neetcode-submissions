public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int highestArea = 0;
        int currentArea = 0;
        int current=0;
        while (left < right) {
            currentArea = Math.Min(heights[left], heights[right]) * (right - left);
            if (currentArea > highestArea) {
                highestArea = currentArea;
            }
            if(heights[left] < heights[right]){
                left++;
            } else if(heights[right] < heights[left]){
                right--;
            } else if(heights[left]==heights[right]){
                left++;
            }
            current++;
        }
        return highestArea;
    }   
}
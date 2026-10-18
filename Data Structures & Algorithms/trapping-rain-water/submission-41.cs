public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length-1;
        int leftMax = 0;
        int rightMax = 0;
        int trappedWater = 0;
        while(left<right){
            leftMax = Math.Max(leftMax,height[left]);
            rightMax = Math.Max(rightMax,height[right]);
            if(height[left]<height[right]){
                trappedWater += leftMax - height[left];
                left++;
            } else if(height[left]>=height[right]){
                trappedWater += rightMax - height[right];
                right--;
            }
        }
        return trappedWater;
    }
}

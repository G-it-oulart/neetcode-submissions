public class Solution {
    public int Trap(int[] height) {
        int[] leftPrefixes = new int[height.Length];
        int[] rightPrefixes = new int[height.Length];
        int leftMax = 0;
        int rightMax = 0;
        int trappedWater = 0;
        for (int i = 0; i < height.Length; i++) {
            leftMax = height[i];
            for (int l = i; l > 0; l--) {
                if (height[l - 1] > leftMax) {
                    leftMax = height[l - 1];
                }
            }
            leftPrefixes[i] = leftMax;
        }
        for (int i = 0; i < height.Length; i++) {
            rightMax = height[i];
            for (int r = i; r < height.Length - 1; r++) {
                if (height[r + 1] > rightMax) {
                    rightMax = height[r + 1];
                }
            }
            rightPrefixes[i] = rightMax;
        }
        for (int i = 0; i < height.Length; i++) {
            trappedWater += (Math.Min(leftPrefixes[i],rightPrefixes[i])-height[i]);
        }
        return trappedWater;
    }
}

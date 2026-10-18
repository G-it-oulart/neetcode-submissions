public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int leftMax = height[left];
        int rightMax = height[right];
        int sum = 0;
        while (left < right) {
            if (height[left] < height[right]) {
                if (height[left] > leftMax) {
                    leftMax = height[left];
                }
                sum += leftMax - height[left];
                left++;
            } else {
                if (height[right] > rightMax) {
                    rightMax = height[right];
                }
                sum += rightMax - height[right];
                right--;
            }
        }
        return sum;
    }
}

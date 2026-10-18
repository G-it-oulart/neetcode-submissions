public class Solution {
    public int Search(int[] nums, int target) {
        return binarySearchRotated(nums, target, 0, nums.Length - 1);
    }
}

public static int binarySearchRotated(int[] nums, int target, int leftLimit, int rightLimit) {
    int mid = leftLimit + (rightLimit - leftLimit) / 2;
    if (leftLimit > rightLimit) {
        return -1;
    }
    if (nums[mid] == target) {
        return mid;
    }
    if (nums[leftLimit] <= nums[mid]) {
        if(nums[leftLimit] <= target && target < nums[mid]){
            return binarySearchRotated(nums, target, leftLimit, mid-1);
        } else{
            return binarySearchRotated(nums, target, mid + 1, rightLimit);
        }
        
    } else {
        if(nums[mid] < target && target <= nums[rightLimit]){
            return binarySearchRotated(nums, target, mid + 1, rightLimit);
        } else{
            return binarySearchRotated(nums, target, leftLimit, mid-1);
        }
    }
}
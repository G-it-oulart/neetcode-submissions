public class Solution {
    public int Search(int[] nums, int target) {
        int index = (nums.Length - 1) / 2;
        return recursiveBinarySearch(nums,target,0,nums.Length-1,index);
    }
}

public static int recursiveBinarySearch(int[] nums, int target, int leftLimit, int rightLimit,int currentIndex){
    if(leftLimit==rightLimit && nums[currentIndex]!=target){
        return -1;
    }
    if(nums[currentIndex]==target){
        return currentIndex;
    }
    if(nums[currentIndex] < target){
        leftLimit += ((rightLimit-leftLimit)/2)+1;
        currentIndex = leftLimit +(rightLimit-leftLimit)/2;
        return recursiveBinarySearch(nums,target,leftLimit,rightLimit,currentIndex);
    } else{
        rightLimit -= ((rightLimit-leftLimit)/2)+1;
        currentIndex = rightLimit-(rightLimit-leftLimit)/2;
        return recursiveBinarySearch(nums,target,leftLimit,rightLimit,currentIndex);
    }
}
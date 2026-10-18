public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int currentIndex = 0;
        for(int i =0; i<matrix.GetLength(0);i++){
            currentIndex = (matrix[i].Length-1)/2;
            if(recursiveBinarySearch(matrix[i],target,0,matrix[i].Length-1,currentIndex)==true){
                return true;
            }
        }
        return false;
    }
}

public static bool recursiveBinarySearch(int[] nums, int target, int leftLimit, int rightLimit,int currentIndex){
    if(leftLimit==rightLimit && nums[currentIndex]!=target){
        return false;
    }
    if(nums[currentIndex]==target){
        return true;
    }
    if(nums[currentIndex] < target){
        leftLimit = currentIndex+1;
        currentIndex = leftLimit +(rightLimit-leftLimit)/2;
        return recursiveBinarySearch(nums,target,leftLimit,rightLimit,currentIndex);
    } else{
        rightLimit -= ((rightLimit-leftLimit)/2)+1;
        currentIndex = rightLimit-(rightLimit-leftLimit)/2;
        return recursiveBinarySearch(nums,target,leftLimit,rightLimit,currentIndex);
    }
}
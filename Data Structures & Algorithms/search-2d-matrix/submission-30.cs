public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        List<int> listOfFirstElements = new List<int>();
        for(int i =0;i<matrix.GetLength(0);i++){
            listOfFirstElements.Add(matrix[i][0]);
        }
        int[] nums = listOfFirstElements.ToArray();
        int currentIndex = (nums.Length-1)/2;
        if(recursiveBinarySearchMatrix(nums,target,0,nums.Length-1,currentIndex,matrix)==true){
            return true;
        }
        return false;
    }
}

public static bool recursiveBinarySearchMatrix(int[] nums,int target, int leftLimit, int rightLimit, int currentIndex,int[][] matrix){
    if(leftLimit>rightLimit){
        return false;
    }
    if(nums.Length==1){
        return recursiveBinarySearchRows(matrix[currentIndex],target,0,matrix[currentIndex].Length-1,(matrix[currentIndex].Length-1)/2);
    }
    if(currentIndex==nums.Length-1){
        return recursiveBinarySearchRows(matrix[currentIndex],target,0,matrix[currentIndex].Length-1,(matrix[currentIndex].Length-1)/2);
    }   
    if(nums[currentIndex]==target){
        return recursiveBinarySearchRows(matrix[currentIndex],target,0,matrix[currentIndex].Length-1,(matrix[currentIndex].Length-1)/2);
    }
    if(currentIndex <nums.Length-1 && nums[currentIndex] <= target && nums[currentIndex+1]>target){
        return recursiveBinarySearchRows(matrix[currentIndex],target,0,matrix[currentIndex].Length-1,(matrix[currentIndex].Length-1)/2);
    }
    if(currentIndex <nums.Length-1 && nums[currentIndex] <= target && nums[currentIndex+1]<=target){
        leftLimit = currentIndex+1;
        currentIndex = leftLimit +(rightLimit-leftLimit)/2;
        return recursiveBinarySearchMatrix(nums,target,leftLimit,rightLimit,currentIndex,matrix);
    } else{
        rightLimit -= ((rightLimit-leftLimit)/2)+1;
        currentIndex = leftLimit +(rightLimit-leftLimit)/2;
        return recursiveBinarySearchMatrix(nums,target,leftLimit,rightLimit,currentIndex,matrix);
    }
}

public static bool recursiveBinarySearchRows(int[] nums, int target, int leftLimit, int rightLimit,int currentIndex){
    if(leftLimit>rightLimit){
        return false;
    }
    if(nums[currentIndex]==target){
        return true;
    }
    if(nums[currentIndex] < target){
        leftLimit = currentIndex+1;
        currentIndex = leftLimit +(rightLimit-leftLimit)/2;
        return recursiveBinarySearchRows(nums,target,leftLimit,rightLimit,currentIndex);
    } else{
        rightLimit -= ((rightLimit-leftLimit)/2)+1;
        currentIndex = leftLimit +(rightLimit-leftLimit)/2;
        return recursiveBinarySearchRows(nums,target,leftLimit,rightLimit,currentIndex);
    }
}
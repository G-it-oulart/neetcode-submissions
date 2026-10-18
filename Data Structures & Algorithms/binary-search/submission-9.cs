public class Solution {
    public int Search(int[] nums, int target) {
        if(nums[0]==target){
            return 0;
        }
        return RecursiveBinarySearch(nums,target,0);
    }
}

static int RecursiveBinarySearch(int[] nums,int target,int originalBeginning){
    if(nums.Length==0){
        return -1;
    }
    int currentIndex = ((nums.Length-1)/2);
    if(nums[currentIndex]==target){
        return currentIndex + originalBeginning;
    } else if (nums[currentIndex] < target){
        int[] newArray = new int[nums.Length-currentIndex-1];
        int r = 0;
        for(int i = currentIndex+1; i<nums.Length;i++){
            newArray[r] = nums[i];
            r++;
        }
        originalBeginning = originalBeginning + currentIndex+1;
        return RecursiveBinarySearch(newArray,target,originalBeginning);
    } else{
        int[] newArray = new int[currentIndex];
        int r =0;
         for(int i = 0;i<currentIndex;i++){
            newArray[r] = nums[i];
            r++;
        }
        return RecursiveBinarySearch(newArray,target,originalBeginning);
    }
}
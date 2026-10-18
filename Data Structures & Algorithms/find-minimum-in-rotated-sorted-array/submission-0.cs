public class Solution {
    public int FindMin(int[] nums) {
        return binaryFindMin(nums,0,nums.Length-1);
    }
}

public static int binaryFindMin(int[] nums,int leftLimit, int rightLimit){
    int mid = leftLimit + (rightLimit - leftLimit)/2;
    if(nums[leftLimit]<nums[rightLimit]){
        return nums[leftLimit];
    }
    if(leftLimit == rightLimit){
        return nums[leftLimit];
    }
    if(nums[mid]>nums[rightLimit]){
        leftLimit = mid+1;
        return binaryFindMin(nums,leftLimit,rightLimit);
    } else{
        rightLimit=mid;
        return binaryFindMin(nums,leftLimit,rightLimit);
    }
}

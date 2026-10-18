public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length<nums2.Length){
            return FindMedian(nums1,nums2);
        } else{
            return FindMedian(nums2,nums1);
        }
    }
}

public static double FindMedian(int[] smaller, int[] larger) {
    int total = smaller.Length + larger.Length;
    int half = total / 2;
    int right = smaller.Length - 1;
    int left = -1;
    while (true) {
        int mid = (left + right) / 2;
        int midOfLarger = (half - mid - 2);
        int smallerLeft = 0;
        int smallerRight = 0;
        int largerLeft = 0;
        int largerRight =0;
        if (mid < 0) {
            smallerLeft = int.MinValue;
        } else{
            smallerLeft = smaller[mid];
        } 
        if (mid+1 >= smaller.Length) {
            smallerRight = int.MaxValue;
        } else{
            smallerRight = smaller[mid+1];
        }
        if (midOfLarger < 0) {
            largerLeft = int.MinValue;
        } else{
            largerLeft = larger[midOfLarger];
        }
        if (midOfLarger+1 >= larger.Length) {
            largerRight = int.MaxValue;
        } else{
            largerRight = larger[midOfLarger+1];
        }
        if (smallerLeft <= largerRight && largerLeft <= smallerRight) {
            if (total % 2 > 0) {
                return Math.Min(smallerRight, largerRight);
            }
            return ((double)Math.Max(smallerLeft,largerLeft) 
                + (double)Math.Min(smallerRight,largerRight))/2;
        } else if (smallerLeft>largerRight){
            right = mid-1;
        } else{
            left = mid+1;
        }
    }
}
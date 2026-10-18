public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        Array.Sort(piles);
        return recursiveBinarySearch(piles,1,piles[piles.Length-1],h);
    }
}

public static bool canFinish(int[] piles,int rate,int h){
    int timeToEat = 0;
    for(int i = 0;i < piles.Length;i++){
        timeToEat+= (piles[i]+rate-1)/rate;
    }
    if(timeToEat<=h){
        return true;
    }
    return false;
}

public static int recursiveBinarySearch(int[] piles, int leftLimit, int rightLimit,int h){
    int mid = leftLimit + (rightLimit - leftLimit)/2;
    if(leftLimit==rightLimit){
        return leftLimit;
    }
    if(leftLimit<rightLimit && !canFinish(piles,mid,h)){
        leftLimit = mid+1;
        return recursiveBinarySearch(piles,leftLimit,rightLimit,h);
    } else{
        rightLimit=mid;
        return recursiveBinarySearch(piles,leftLimit,rightLimit,h);
    }
}
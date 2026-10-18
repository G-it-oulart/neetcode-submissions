public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int currentSmallestPrice = prices[0];
        for(int i = 1; i<prices.Length;i++){
            if(prices[i]<currentSmallestPrice){
                currentSmallestPrice = prices[i];
            } else{
                if(prices[i] - currentSmallestPrice >maxProfit){
                    maxProfit = prices[i] - currentSmallestPrice;
                }
            }
        }
        return maxProfit;
    }
}
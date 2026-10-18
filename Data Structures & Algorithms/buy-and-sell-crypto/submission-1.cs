public class Solution {
    public int MaxProfit(int[] prices) {
        int potencialProfit =0;
        int currentSmallestPrice = prices[0];
        List<int> potencialHighestProfits = new List<int>();
        potencialHighestProfits.Add(0);
        for(int i = 1; i<prices.Length;i++){
            if(prices[i]<currentSmallestPrice){
                currentSmallestPrice = prices[i];
            } else{
                potencialHighestProfits.Add(prices[i]-currentSmallestPrice);
            }
        }
        return potencialHighestProfits.Max();
    }
}
public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int bestProfit = 0;
        for (int i = 1; i < prices.Length; i++) {
            while (prices[i - 1] < prices[left]) {
                left++;
            }
            bestProfit = Math.Max(bestProfit,prices[i]-prices[left]);
        }
        return bestProfit;
    }
}

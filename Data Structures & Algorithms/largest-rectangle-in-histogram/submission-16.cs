public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> heightStack = new Stack<int>();
        int poppedElement = 0;
        int area = 0;
        int end = 0;
        int maxArea = 0;
        if(heights.Length==1){
            return heights[0];
        }
        for(int i = 0; i<heights.Length+1; i++){
            if(i==heights.Length){
                end = 0;
            } else{
                end = heights[i];
            }
            while(heightStack.Count>0 && heights[heightStack.Peek()]>end){
                poppedElement = heightStack.Pop();
                if(heightStack.Count > 0){
                    area = (i-heightStack.Peek()-1)*heights[poppedElement];
                    if (area > maxArea){
                        maxArea = area;
                    }
                } else{
                    area = (i-0)*heights[poppedElement];
                    if (area > maxArea){
                        maxArea = area;
                    }
                }
            }
            if(i != heights.Length){
                heightStack.Push(i);
            }
        }
        return maxArea;
    }
}
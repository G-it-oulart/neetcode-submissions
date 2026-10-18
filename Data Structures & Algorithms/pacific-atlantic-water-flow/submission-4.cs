public class Solution {
    HashSet<(int,int)> pacific = new HashSet<(int,int)>();
    HashSet<(int,int)> atlantic = new HashSet<(int,int)>();
    List<List<int>> answer = new List<List<int>>();
    public List<List<int>> PacificAtlantic(int[][] heights) {
        for(int j = 0;j<heights[0].Length;j++){
            setPacific(heights,0,j);
        }
        for(int i = 0;i<heights.Length;i++){
            setPacific(heights,i,0);
        }
        for(int j = 0; j< heights[heights.Length-1].Length;j++){
            setAtlantic(heights,heights.Length-1,j);
        }
        for(int i = heights.Length-1;i>=0;i--){
            setAtlantic(heights,i,heights[heights.Length-1].Length-1);
        }
        for(int i = 0; i <heights.Length;i++){
            for(int j = 0;j<heights[i].Length;j++){
                if(pacific.Contains((i,j)) && atlantic.Contains((i,j))){
                    answer.Add(new List<int>{i,j});
                }
            }
        }
        return answer;
    }
    public void setPacific (int[][] heights,int i, int j){
        if(pacific.Contains((i,j))){
           return; 
        }
        pacific.Add((i,j));
        if(i+1<heights.Length && heights[i+1][j]>=heights[i][j]){
            setPacific(heights,i+1,j);
        }
        if(i>0 && heights[i-1][j]>heights[i][j]){
            setPacific(heights,i-1,j);
        }
        if(j+1<heights[i].Length && heights[i][j+1]>=heights[i][j]){
            setPacific(heights,i,j+1);
        }
        if(j>0 && heights[i][j-1]>heights[i][j]){
            setPacific(heights,i,j-1);
        }
    }
    public void setAtlantic (int[][] heights,int i, int j){
        if(atlantic.Contains((i,j))){
           return; 
        }
        atlantic.Add((i,j));
        if(i+1<heights.Length && heights[i+1][j]>=heights[i][j]){
            setAtlantic(heights,i+1,j);
        }
        if(i>0 && heights[i-1][j]>=heights[i][j]){
            setAtlantic(heights,i-1,j);
        }
        if(j+1<heights[i].Length && heights[i][j+1]>=heights[i][j]){
            setAtlantic(heights,i,j+1);
        }
        if(j>0 && heights[i][j-1]>=heights[i][j]){
            setAtlantic(heights,i,j-1);
        }
    }
}
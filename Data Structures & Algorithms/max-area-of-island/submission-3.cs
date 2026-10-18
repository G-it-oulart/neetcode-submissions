public class Solution {
    int maxArea = 0;
    int currentArea = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        for(int i =0; i<grid.Length;i++){
            for(int j = 0; j<grid[i].Length;j++){
                if(grid[i][j]==1){
                    CountIslands(grid,i,j);
                    maxArea = Math.Max(maxArea,currentArea);
                    currentArea=0;
                }
            }
        }
        return maxArea;
    }
    public void CountIslands(int[][] grid, int i, int j) {
        if (grid[i][j]==0){
            return;
        }
        currentArea++;
        grid[i][j]=0;
        if(i+1<grid.Length){
            CountIslands(grid,i+1,j);
        }
        if(i>0){
            CountIslands(grid,i-1,j);
        }
        if(j+1<grid[i].Length){
            CountIslands(grid,i,j+1);
        }
        if(j>0){
            CountIslands(grid,i,j-1);
        }
    }
}
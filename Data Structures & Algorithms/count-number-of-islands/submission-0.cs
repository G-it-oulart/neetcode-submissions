public class Solution {
    int islandCount = 0;
    public int NumIslands(char[][] grid) {
        for(int i = 0;i<grid.Length;i++){
            for(int j = 0;j<grid[i].Length;j++){
                if(grid[i][j]=='1'){
                    CountIslands(grid,i,j);
                    islandCount++;
                }
            }
        }
        return islandCount;
    }
    public void CountIslands(char[][] grid, int i, int j) {
        if (grid[i][j]=='0'){
            return;
        }
        grid[i][j]='0';
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

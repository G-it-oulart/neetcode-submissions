public class Solution {
    Queue<(int, int)> fruitQueue = new Queue<(int, int)>();
    int minutes = 0;
    public int OrangesRotting(int[][] grid) {
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 2) {
                    fruitQueue.Enqueue((i, j));
                }
            }
        }
        RotFruits(grid);
        for(int i =0; i<grid.Length;i++){
            for(int j = 0;j<grid[i].Length;j++){
                if(grid[i][j]==1){
                    return -1;
                }
            }
        }
        return minutes;
    }

    public void RotFruits(int[][] grid) {
        while (fruitQueue.Count != 0) {
            int levels = fruitQueue.Count;
            int freshFruitsFound = 0;
            for (int i = 0; i < levels; i++) {
                (int, int)indexes = fruitQueue.Dequeue();
                if (indexes.Item1 + 1 < grid.Length) {
                    if(grid[indexes.Item1 + 1][indexes.Item2]==1){
                        freshFruitsFound++;
                        fruitQueue.Enqueue((indexes.Item1+1,indexes.Item2));
                        grid[indexes.Item1 + 1][indexes.Item2] = 2;
                    }
                }
                if (indexes.Item2 + 1 < grid[indexes.Item1].Length) {
                    if(grid[indexes.Item1][indexes.Item2 + 1]==1){
                        freshFruitsFound++;
                        fruitQueue.Enqueue((indexes.Item1,indexes.Item2+1));
                        grid[indexes.Item1][indexes.Item2 + 1] = 2;
                    }
                }
                if (indexes.Item1 > 0) {
                    if(grid[indexes.Item1 - 1][indexes.Item2]==1){
                        freshFruitsFound++;
                        fruitQueue.Enqueue((indexes.Item1-1,indexes.Item2));
                        grid[indexes.Item1 - 1][indexes.Item2] = 2;
                    }
                }
                if (indexes.Item2 > 0) {
                    if(grid[indexes.Item1][indexes.Item2 - 1]==1){
                        freshFruitsFound++;
                        fruitQueue.Enqueue((indexes.Item1,indexes.Item2-1));
                        grid[indexes.Item1][indexes.Item2 - 1] = 2;
                    }
                }
            }
            if(freshFruitsFound>0){
                minutes++;
            }
        }
    }
}

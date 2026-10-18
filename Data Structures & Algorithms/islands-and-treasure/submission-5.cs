public class Solution {
    Queue<(int, int)> indexQueue = new Queue<(int, int)>();
    public void islandsAndTreasure(int[][] grid) {
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 0) {
                    indexQueue.Enqueue((i, j));
                    findDistances(grid);
                }
            }
        }
    }
    public void findDistances(int[][] grid) {
        int distance = 1;
        while (indexQueue.Count > 0) {
            int level = indexQueue.Count;
            for(int i =0;i<level;i++){
                (int, int)indexes = indexQueue.Dequeue();
                if (indexes.Item1 + 1 < grid.Length) {
                    int valRight = grid[indexes.Item1 + 1][indexes.Item2];
                    if (valRight > 0 && valRight > distance) {
                        indexQueue.Enqueue((indexes.Item1 + 1, indexes.Item2));
                        grid[indexes.Item1 +1][indexes.Item2] = distance;
                    }
                }
                if (indexes.Item2 + 1 < grid[indexes.Item1].Length) {
                    int valDown = grid[indexes.Item1][indexes.Item2 + 1];
                    if (valDown > 0 && valDown > distance) {
                        indexQueue.Enqueue((indexes.Item1, indexes.Item2 + 1));
                        grid[indexes.Item1][indexes.Item2 + 1] = distance;
                    }
                }
                if (indexes.Item1 > 0) {
                    int valUp = grid[indexes.Item1 - 1][indexes.Item2];
                    if (valUp > 0 && valUp > distance) {
                        indexQueue.Enqueue((indexes.Item1 - 1, indexes.Item2));
                        grid[indexes.Item1 -1][indexes.Item2] = distance;
                    }
                }
                if (indexes.Item2 > 0) {
                    int valLeft = grid[indexes.Item1][indexes.Item2 - 1];
                    if (valLeft > 0 && valLeft > distance) {
                        indexQueue.Enqueue((indexes.Item1, indexes.Item2-1));
                        grid[indexes.Item1][indexes.Item2 - 1] = distance;
                    }
                }
            }
            distance++;
        }
    }
}

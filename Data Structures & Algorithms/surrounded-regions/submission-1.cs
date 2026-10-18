public class Solution {
    public void Solve(char[][] board) {
        int i = 0;
        int j = 0;
        while(j<board[0].Length){
            if(board[0][j]=='O'){
                replaceRegions(board,0,j);
            }
            j++;
        }
        j--;
        while(i<board.Length){
            if(board[i][j]=='O'){
                replaceRegions(board,i,j);
            }
            i++;
        }
        i--;
        while(j>=0){
            if(board[i][j]=='O'){
                replaceRegions(board,i,j);
            }
            j--;
        }
        j++;
        while(i>0){
            if(board[i][j]=='O'){
                replaceRegions(board,i,j);
            }
            i--;
        }
        for(int r = 0; r<board.Length;r++){
            for (int c = 0; c<board[r].Length;c++){
                if(board[r][c]=='#'){
                    board[r][c]='O';
                } else if(board[r][c]=='O'){
                    board[r][c]='X';
                }
            }
        }
    }
    public void replaceRegions(char [][] board, int i, int j){
        if(board[i][j]!='#' && board[i][j] !='X'){
            board[i][j]='#';
            if(i+1<board.Length){
                replaceRegions(board,i+1,j);
            }
            if(j+1<board[i].Length){
                replaceRegions(board,i,j+1);
            }
            if(i>0){
                replaceRegions(board,i-1,j);
            }
            if(j>0){
                replaceRegions(board,i,j-1);
            }
        }
    }
}
public class Solution {
    public bool IsValidSudoku(char[][] board) {   
        List<char> storeSquare = new List<char>();
        for(int rows =0;rows<9;rows++){
            for(int cols = 0;cols<9;cols++){
                if(board[rows][cols]!='.'){
                    storeSquare.Add(board[rows][cols]);
                }
            }
            HashSet<char> hashSquare = new HashSet<char>(storeSquare);
            if (storeSquare.Count != hashSquare.Count){
                return false;
            }
            storeSquare.Clear();
        }

        for(int cols =0;cols<9;cols++){
            for(int rows = 0;rows<9;rows++){
                if(board[rows][cols]!='.'){
                    storeSquare.Add(board[rows][cols]);
                }
            }
            HashSet<char> hashSquare = new HashSet<char>(storeSquare);
            if (storeSquare.Count != hashSquare.Count){
                return false;
            }
            storeSquare.Clear();
        }

        for(int rows =0; rows<7;rows+=3){
             for(int cols =0;cols<7;cols+=3){
                for(int r = rows;r<rows+3;r++){
                    for(int c = cols;c<cols+3;c++){
                        if(board[r][c]!='.'){
                            storeSquare.Add(board[r][c]);
                        }
                    }
                }
                HashSet<char> hashSquare = new HashSet<char>(storeSquare);
                if (storeSquare.Count != hashSquare.Count){
                    return false;
                }
                storeSquare.Clear();
            }
        }
        return true; 
    }
}

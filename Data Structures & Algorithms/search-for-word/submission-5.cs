public class Solution {
    Dictionary<(int,int),bool> visitedIndexes = new Dictionary<(int,int),bool>();
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i<board.Length;i++){
            for(int j =0; j<board[i].Length;j++){
                if(FindWord(0,board,i,j,word)){
                    return true;
                }
            }
        }
        return false;
    }
    public bool FindWord(int index,char[][] board, int i, int j, string word){
        if(board[i][j]==word[index]){
            if(index == word.Length-1){
                return true;
            }
            visitedIndexes[(i,j)] = true;
            if(i+1<board.Length && !visitedIndexes.ContainsKey((i+1,j))){
                if(FindWord(index+1,board,i+1,j,word)){
                    return true;
                }
            }
            if(j+1<board[i].Length && !visitedIndexes.ContainsKey((i,j+1))){
                if(FindWord(index+1,board,i,j+1,word)){
                    return true;
                }
            }
            if(i>0 && !visitedIndexes.ContainsKey((i-1,j))){
                if(FindWord(index+1,board,i-1,j,word)){
                    return true;
                }
            }
            if(j>0 && !visitedIndexes.ContainsKey((i,j-1))){
                if(FindWord(index+1,board,i,j-1,word)){
                    return true;
                }
            }
            visitedIndexes.Remove((i,j));
            return false;
        } else{
            return false;
        }
    }
}

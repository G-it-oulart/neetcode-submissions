public class Solution {
    Dictionary<(int,int),bool> visitedIndexes = new Dictionary<(int,int),bool>();
    bool foundWord = false;
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i<board.Length;i++){
            for(int j =0; j<board[i].Length;j++){
                FindWord(0,board,i,j,word);
            }
        }
        return foundWord;
    }
    public void FindWord(int index,char[][] board, int i, int j, string word){
        if(board[i][j]==word[index]){
            if(index == word.Length-1){
                foundWord=true;
                return;
            }
            visitedIndexes[(i,j)] = true;
            if(i+1<board.Length && !visitedIndexes.ContainsKey((i+1,j))){
                FindWord(index+1,board,i+1,j,word);
            }
            if(j+1<board[i].Length && !visitedIndexes.ContainsKey((i,j+1))){
                FindWord(index+1,board,i,j+1,word);
            }
            if(i>0 && !visitedIndexes.ContainsKey((i-1,j))){
                FindWord(index+1,board,i-1,j,word);
            }
            if(j>0 && !visitedIndexes.ContainsKey((i,j-1))){
                FindWord(index+1,board,i,j-1,word);
            }
            visitedIndexes.Remove((i,j));
        }
    }
}

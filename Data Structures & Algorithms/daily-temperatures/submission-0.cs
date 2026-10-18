public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> tempStack = new Stack<int>();
        int[] answers = new int[temperatures.Length];
        tempStack.Push(0);
        for(int i=1; i < temperatures.Length;i++){
            if(tempStack.Count > 0 && temperatures[i] > temperatures[tempStack.Peek()]){
                while(tempStack.Count > 0 && temperatures[i] >temperatures[tempStack.Peek()]){
                    answers[tempStack.Peek()] = i-tempStack.Peek();
                    tempStack.Pop();
                }
            }
            tempStack.Push(i); 
        }
        return answers;
    }
}

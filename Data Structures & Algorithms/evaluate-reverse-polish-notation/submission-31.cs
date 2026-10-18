public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens.Length == 1) {
            return int.Parse(tokens[0]);
        }
        Stack<int> tokenStack = new Stack<int>();
        string currentToken = tokens[0];
        int evaluation = int.Parse(tokens[0]);
        for (int i = 0; i < tokens.Length; i++) {
            currentToken = tokens[i];
            if (isOperator(currentToken) && tokenStack.Count < 2) {
                switch (currentToken) {
                    case "+":
                        evaluation += tokenStack.Pop();
                        tokenStack.Push(evaluation);
                        continue;
                    case "-":
                        evaluation = tokenStack.Pop() - evaluation;
                        tokenStack.Push(evaluation);
                        continue;
                    case "*":
                        evaluation *= tokenStack.Pop();
                        tokenStack.Push(evaluation);
                        continue;
                    case "/":
                        evaluation = tokenStack.Pop() / evaluation;
                        tokenStack.Push(evaluation);
                        continue;
                }
            } else if (isOperator(currentToken) && tokenStack.Count > 1) {
                evaluation = tokenStack.Pop();
                switch (currentToken) {
                    case "+":
                        evaluation += tokenStack.Pop();
                        tokenStack.Push(evaluation);
                        continue;
                    case "-":
                        evaluation = tokenStack.Pop() - evaluation;
                        tokenStack.Push(evaluation);
                        continue;
                    case "*":
                        evaluation *= tokenStack.Pop();
                        tokenStack.Push(evaluation);
                        continue;
                    case "/":
                        evaluation = tokenStack.Pop() / evaluation;
                        tokenStack.Push(evaluation);
                        continue;
                }
            } else {
                tokenStack.Push(int.Parse(tokens[i]));
            }
        }
        return evaluation;
    }

    public bool isOperator(string currentOperator) {
        switch (currentOperator) {
            case "+":
                return true;
            case "-":
                return true;
            case "/":
                return true;
            case "*":
                return true;
        }
        return false;
    }
}
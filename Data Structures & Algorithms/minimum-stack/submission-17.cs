public class MinStack {
    LinkedList<int> elementsList = new LinkedList<int>();
    LinkedList<int> minElements = new LinkedList<int>();

    public MinStack() {
    }
    
    public void Push(int val) {
        if(elementsList.Count == 0){
            minElements.AddFirst(val);
        } else if( val <= minElements.First.Value){
            minElements.AddFirst(val);
        }
        elementsList.AddFirst(val);
    }
    
    public void Pop() {
        if(elementsList.First.Value == minElements.First.Value){
            minElements.RemoveFirst();
        }
        elementsList.RemoveFirst();
    }
    
    public int Top() {
        return elementsList.First.Value;
    }
    
    public int GetMin() {
        return minElements.First.Value;
    }
}

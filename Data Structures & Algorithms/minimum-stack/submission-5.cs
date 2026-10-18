public class MinStack {
    int min = 0;
    LinkedList<int> elementsList = new LinkedList<int>();
    LinkedList<int> minElements = new LinkedList<int>();

    public MinStack() {
        elementsList = new LinkedList<int>();
    }
    
    public void Push(int val) {
        if(elementsList.Count == 0){
            min = val;
            minElements.AddFirst(val);
        } else if( val <= min){
            min = val;
            minElements.AddFirst(val);
        }
        elementsList.AddFirst(val);
    }
    
    public void Pop() {
        if(minElements.Count==1){
            minElements.RemoveFirst();
        }
        if(minElements.Count > 1 && elementsList.First.Value == min){
            minElements.RemoveFirst();
            min = minElements.First.Value;
        }
        elementsList.RemoveFirst();
    }
    
    public int Top() {
        return elementsList.First.Value;
    }
    
    public int GetMin() {
        return min;
    }
}

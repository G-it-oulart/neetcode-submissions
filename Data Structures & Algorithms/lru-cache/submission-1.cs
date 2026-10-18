public class LRUCache {

    ListNode sentinelHead = new ListNode(0,0);
    ListNode sentinelTail = new ListNode(0,0);

    Dictionary<int,ListNode> nodesDict = new Dictionary<int,ListNode>();

    int capacity = 0;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        sentinelHead.Next = sentinelTail;
        sentinelTail.Previous = sentinelHead;
    }   
    
    public int Get(int key) {
        if(nodesDict.ContainsKey(key)){
            SetTail(nodesDict[key]);
            return nodesDict[key].Val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(nodesDict.ContainsKey(key)){
            nodesDict[key].Val = value;
            SetTail(nodesDict[key]);
        }else if(!nodesDict.ContainsKey(key) && nodesDict.Count<capacity){
            ListNode addedNode = new ListNode(key,value);
            nodesDict[key] = addedNode;
            AddToTail(addedNode);
        } else{
            ListNode addedNode = new ListNode(key,value);
            nodesDict.Remove(sentinelHead.Next.Key);
            RemoveNode(sentinelHead.Next);
            nodesDict[key] = addedNode;
            AddToTail(addedNode);
        }
    }

    public void SetTail(ListNode node){
        RemoveNode(node);
        AddToTail(node);
    }

    public void RemoveNode(ListNode node){
        node.Previous.Next = node.Next;
        node.Next.Previous = node.Previous;
    }

    public void AddToTail(ListNode node){
        sentinelTail.Previous.Next = node;
        node.Next = sentinelTail;
        node.Previous = sentinelTail.Previous;
        sentinelTail.Previous = node;
    }
}

public class ListNode {
    public int Key {get;set;}
    public int Val {get;set;}
    public ListNode Next {get;set;}
    public ListNode Previous {get;set;}

    public ListNode(int key, int val){
        Key = key;
        Val = val;
        Next = null;
        Previous = null;
    }
}
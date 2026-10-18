/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }
        Dictionary<Node, Node> copyDict = new Dictionary<Node, Node>();
        Node scanner = head;
        while (scanner != null) {
            Node copyNode = new Node(scanner.val);
            if (!copyDict.ContainsKey(scanner)) {
                copyDict[scanner] = copyNode;
            }
            scanner = scanner.next;
        }
        Node secondScanner = copyDict[head];
        Node newHead = secondScanner;
        scanner = head;
        while (secondScanner != null) {
            if (scanner.next == null) {
                secondScanner.next = null;
            } else {
                secondScanner.next = copyDict[scanner.next];
            }
            if (scanner.random == null) {
                secondScanner.random = null;
            } else {
                secondScanner.random = copyDict[scanner.random];
            }
            secondScanner = secondScanner.next;
            scanner = scanner.next;
        }
        return newHead;
    }
}

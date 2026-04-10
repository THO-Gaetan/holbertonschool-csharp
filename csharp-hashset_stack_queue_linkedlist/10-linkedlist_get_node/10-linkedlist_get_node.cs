using system;

class LList:
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n >= myLList.Count)
        {
            throw new ArgumentOutOfRangeException("n", "Index is out of range.");
        }
        LinkedListNode<int> currentNode = myLList.First;
        for (int i = 0; i < n; i++)
        {
            currentNode = currentNode.Next;
        }
        return currentNode.Value;
    }
using system;

class LList:
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        if (myLList.Count == 0)
        {
            myLList.AddFirst(newNode);
        }
        else
        {
            myLList.AddLast(newNode);
        }
        return newNode;
    }
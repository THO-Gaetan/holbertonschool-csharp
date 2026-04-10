using system;

class LList:
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            throw new InvalidOperationException("The linked list is empty.");
        }
        int value = myLList.First.Value;
        myLList.RemoveFirst();
        return value;
    }
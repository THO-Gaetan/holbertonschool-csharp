using system;

class LList:
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        foreach (int num in myLList)
        {
            if (num == value)
            {
                return index;
            }
            index++;
        }
        return -1; // Not found
    }
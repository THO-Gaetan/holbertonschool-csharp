using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int LastDigit = number % 10;
        if (LastDigit < 0)
            LastDigit = LastDigit * -1;
        Console.Write(LastDigit);
        return LastDigit;
    }
}
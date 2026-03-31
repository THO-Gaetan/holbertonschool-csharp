using System;

class Program
{
    static void Main(string[] args)
    {
        int two, one;
        for (two = 0; two <= 8; two++)
        {
            for (one = two + 1; one <= 9; one++)
            {
                Console.Write($"{two}{one}");
                if (!(two == 8 && one == 9))
                    Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
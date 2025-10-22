using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
        int target = 6;

        foreach (int num in numbers)
        {
            if (num == target)
            {
                Console.WriteLine("Found target: " + target);
                break; // no need for control flag
            }
        }
    }
}

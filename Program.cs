using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> Numbers = new List<int>
        { 1, 2, 3, 4, 5, 6, 7 };
        int target = 10;
        Numbers.Sort();   
             
        for (int i = 0; i < Numbers.Count - 2; i++)
        {
            int left = i + 1;
            int right = Numbers.Count - 1;

            while (left < right)
            {
                int currentSum = Numbers[i] + Numbers[left] + Numbers[right];

                if (currentSum == target)
                {
                    Console.WriteLine($"Найдены три числа: {Numbers[i]}, {Numbers[left]}, {Numbers[right]}");
                    return;
                }
                else if (currentSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

    }
}

//Write a program that compares two given days of the week and determines which day comes later in a standard calendar week, starting from Monday.

//Hierarchy: Monday < Tuesday < Wednesday < Thursday < Friday < Saturday < Sunday.

//Input:
//The input will consist of two lines. Each line will contain a day of the week (e.g., "Monday", "Wednesday"). The program should handle case-insensitive input.

//Output:
//The output should be a single line containing the later day, or "Same Day" if both inputs represent the same day.

//Example:

//Input:
//Wednesday
//Monday

//Output:
//Wednesday

using System;
using System.Collections.Generic;

public class DayComparator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first day of the week:");
        string day1 = Console.ReadLine();
        Console.WriteLine("Enter the second day of the week:");
        string day2 = Console.ReadLine();

        Console.WriteLine(CompareDays(day1, day2));
    }

    public static string CompareDays(string day1, string day2)
    {
        Dictionary<string, int> dayOrder = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            {"Monday", 1},
            {"Tuesday", 2},
            {"Wednesday", 3},
            {"Thursday", 4},
            {"Friday", 5},
            {"Saturday", 6},
            {"Sunday", 7}
        };

        int order1, order2;
        bool day1Found = dayOrder.TryGetValue(day1, out order1);
        bool day2Found = dayOrder.TryGetValue(day2, out order2);

        if (!day1Found || !day2Found)
        {
            return "Invalid Day Input. Please enter a valid day of the week.";
        }

        if (order1 > order2)
        {
            return day1;
        }
        else if (order2 > order1)
        {
            return day2;
        }
        else
        {
            return "Same Day";
        }
    }
}
  

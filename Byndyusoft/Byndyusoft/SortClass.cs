using System;
using System.Collections;
using Xunit.Sdk;

namespace Byndyusoft;

public static class SortClass
{
    public static int FindSumOfTwoMinNumbersInArray(int[] arr)
    {
        if (arr.Length < 2) throw new ArgumentOutOfRangeException();
        
        var firstMin = int.MaxValue;
        var secondMin = int.MaxValue;

        foreach (var num in arr)
        {
            if (num < firstMin)
            {
                secondMin = firstMin;
                firstMin = num;
            }
            else if (num < secondMin) secondMin = num;
        }
        return firstMin + secondMin;
    }
}
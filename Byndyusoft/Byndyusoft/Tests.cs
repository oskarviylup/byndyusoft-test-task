using Xunit;

namespace Byndyusoft;

public class Tests
{
    [Fact]
    public void SimpleArraySortTest()
    {
        var array = new[] { 5, 6, 15, 1, 6, -4, 345 };
        const int minSum = -3;
        var ans = SortClass.FindSumOfTwoMinNumbersInArray(array);
        Assert.Equal(minSum, ans);
    }
    
    [Fact]
    public void EmptyArraySortTest()
    {
        var array = Array.Empty<int>();
        
        Assert.Throws<ArgumentOutOfRangeException>(() => SortClass.FindSumOfTwoMinNumbersInArray(array));

    }
    
    [Fact]
    public void SimpleArrayWithSameMinNumsSortTest()
    {
        var array = new[] { 5, 6, 15, 1, 6, 1, 345 };
        const int minSum = 2;
        var ans = SortClass.FindSumOfTwoMinNumbersInArray(array);
        Assert.Equal(minSum, ans);
    }
    
    [Fact]
    public void MillionNumsArraySortTest()
    {
        const string arrayPath = "/Users/oskarviylyp/RiderProjects/Byndyusoft/Byndyusoft/million_array.csv";
        var array = File.ReadAllLines(arrayPath).Skip(1).Select(int.Parse).ToArray();
        const int minSum = -1999998;
        var ans = SortClass.FindSumOfTwoMinNumbersInArray(array);
        Assert.Equal(minSum, ans);
    }
}
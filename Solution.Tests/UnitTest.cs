namespace Solution.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] {}, new int[] {}, new int[] {})]
    [InlineData(new int[] {}, new int[] { 0 }, new int[] { 0 })]
    public void Test(int[] array1, int[] array2, int[] expected)
    {
        var result = Solution.MergeTwoLists(array1.Any() ? new(array1) : null, array2.Any() ? new(array2) : null);

        Assert.Equal(expected, result?.ToArray() ?? []);
    }
}
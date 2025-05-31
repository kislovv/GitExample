namespace ReflectionExample.zUnit;

[ZTest]
public class ZUnitExample
{
    [ZFact]
    public void SumOfTwoNumbersShouldReturnCorrectResult()
    {
        var a = 1;
        var b = 2;
        
        Assert.Equals(a+b, 3);
    }
    
    [ZFact]
    public void SumOfTwoNumbersShouldReturnCorrectResult2()
    {
        var a = 2;
        var b = 2;
        
        Assert.Equals(a+b, 3);
    }
    
    [ZTheory]
    [InlineData(1, 2, 3)]
    [InlineData(1, -1, 0)]
    public void SumOfSeveralNumbersReturnTrue(int a, int b, int sum)
    {
        Assert.Equals(a+b, sum);
    }
}
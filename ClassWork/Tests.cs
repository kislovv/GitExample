namespace ClassWork;

public class Tests
{
    [Fact]
    public void Same_Element_Array_Returns_That_Element()
    {
        int[] sameNumbers = [1, 1, 1, 1, 1];
        int expected = 1;

        int result = Program.GetMajorityElement(sameNumbers);

        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Three_Ones_And_Four_Twos_Returns_Two()
    {
        int[] sameNumbers = [2, 1, 2, 1, 2, 1, 2];
        int expected = 2;

        int result = Program.GetMajorityElement(sameNumbers);

        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Broken_Test()
    {
        int[] sameNumbers = [2, 1, 2, 1, 2, 1, 2];
        int expected = 1;

        int result = Program.GetMajorityElement(sameNumbers);

        Assert.Equal(expected, result);
    }
    
    
}
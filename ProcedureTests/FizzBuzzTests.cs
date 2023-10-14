using UnitTests;
namespace ProcedureTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Input_Zero_Should_Be_Return_Empty_Array()
        {
            //Act
            var result =Program.GetFizzBuzzArray(0);

            //Assert
            Assert.Equal(Array.Empty<string>(), result );
        }

        [Fact]
        public void Input_Negative_Num_Should_Be_Throw_Exception()
        {
            //Arrange
            var inputN = -1;

            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => Program.GetFizzBuzzArray(inputN));
        }

        [Theory]
        [InlineData(1, new string[] {"1"})]
        [InlineData(3, new string[] {"1", "2", "Fizz"})]
        [InlineData(4, new string[] { "1", "2", "Fizz", "4" })]
        [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(8, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8" })]
        [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        [InlineData(17, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17"})]
        public void Input_Positive_Num_Should_Be_ReturnFizzBuzzArray(int n, string[] expected)
        {
            //Act
            var result = Program.GetFizzBuzzArray(n);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
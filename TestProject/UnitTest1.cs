using Example_UnitTest;
using Xunit;

namespace TestProject
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
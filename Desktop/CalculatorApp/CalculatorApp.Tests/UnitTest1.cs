using Xunit;
using CalculatorApp; // “еперь это работает, так как мы добавили ссылку

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAdd()
        {
            var calc = new Calculator();
            Assert.Equal(10, calc.Add(7, 3)); // ѕровер€ем, что 7+3 действительно 10
        }
    }
}
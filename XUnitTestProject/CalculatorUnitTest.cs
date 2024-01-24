using CalculatorLibrary;

namespace XUnitTestProject
{
    public class CalculatorUnitTest
    {
        int n1, n2;
        // [Fact(Skip ="Not needed for now")]
        [Fact]
        public void AddTestMethod()
        {
            Calculator cal = new Calculator();
            int expectedResult = 20;
            int actualResult = cal.Add(n1, n2);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void AddTestMethodFailed()
        {
            Calculator cal = new Calculator();
            int n1 = int.MaxValue, n2 = int.MaxValue;
            int actualResult = cal.Add(n1, n2);
            Assert.Equal(n1 + n2, actualResult);
        }
    }
}
using CalculatorLibrary;

namespace NUnitTestProject
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        Calculator calc;
        int n1, n2;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
            n1 = 10;
            n2 = 10;
        }
        [Test]
        public void AddTestMethod()
        {
            Calculator cal = new Calculator();
            int expectedResult = 20;
            int actualResult = cal.Add(n1, n2);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void AddTestMethodFailed()
        {
            Calculator cal = new Calculator();
            int n1 = int.MaxValue, n2 = int.MaxValue;
            int actualResult = cal.Add(n1, n2);
            Assert.AreEqual(n1 + n2, actualResult);
        }
    }
}
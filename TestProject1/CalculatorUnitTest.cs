using CalculatorLibrary;

namespace TestProject1
{
      [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void AddTestMethod()
        {
            Calculator cal=new Calculator();
            int n1=10, n2=10;
            int expectedResult = 20;
           int actualResult= cal.Add(n1,n2);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddTestMethodFailed()
        {
            Calculator cal = new Calculator();
            int n1 = int.MaxValue, n2 = int.MaxValue;
            int actualResult = cal.Add(n1, n2);
            Assert.AreEqual(n1+n2, actualResult);
        }
    }
}
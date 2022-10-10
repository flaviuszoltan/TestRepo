using TestApplication.Library;

namespace TestApplication.LibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 2;
            Calculator calculator = new Calculator();

            int sum = calculator.Sum(a, b);

            Assert.AreEqual(3, sum);
        }
    } 
}
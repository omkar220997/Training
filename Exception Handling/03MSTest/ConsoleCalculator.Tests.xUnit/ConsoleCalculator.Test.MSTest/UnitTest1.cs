namespace ConsoleCalculator.Test.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
        }
    }
}
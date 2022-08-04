using Sparky;

namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorMSTest
    {
        [TestMethod]
        public void AddNumber_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            var result = calc.AddNumbers(10, 20);

            //Assert
            Assert.AreEqual(30, result);
        }
    }
}

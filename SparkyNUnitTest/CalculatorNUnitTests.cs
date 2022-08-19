using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            var result = calc.AddNumbers(10, 20);

            //Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputEvenNumber_ReturnFalse(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act
            var isOdd = calc.IsOddNumber(a);

            //Assert
            Assert.That(isOdd, Is.EqualTo(true));
            //Assert.IsFalse(isOdd);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calc = new();
            return calc.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4, 10.5)]
        [TestCase(5.43, 10.53)]
        [TestCase(5.49, 10.59)]
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arrange
            Calculator calc = new();

            //Act
            var result = calc.AddNumbersDoubles(a, b);

            //Assert
            Assert.AreEqual(15.9, result, 1);
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            Calculator calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 }; //5-10

            //act
            var result = calc.GetOddRange(5, 10);

            //Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            //Assert.AreEqual( expectedOddRange, result);
            //Assert.Contains(7, result);
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(6));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}

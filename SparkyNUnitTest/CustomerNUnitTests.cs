using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;

        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            //Arrange

            //Act
            customer.GreetAndCombineNames("Ben", "Spark");

            //Assert
            Assert.AreEqual(customer.GreetMessage, "Hello, Ben Spark");
            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
            Assert.That(customer.GreetMessage, Does.Contain("ben Spark").IgnoreCase);
            Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
            Assert.That(customer.GreetMessage, Does.EndWith("Spark"));
            Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsNull(customer.GreetMessage);
        }
    }
}

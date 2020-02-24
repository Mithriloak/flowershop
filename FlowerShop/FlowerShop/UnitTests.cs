using NUnit.Framework;
using NSubstitute;
using FlowerShop;
using NUnit.Framwork;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeliverTests()
        {
            //Arrange
            IClient x = Substitute.For<IClient>();
            IOrderDAO order = Substitute.For<IOrderDAO>();
            IOrder number = Substitute.For<IOrder>();
            IOrder nord = new Order(dao, x);

            //Act
            nord.Deliever(order, number);

            //Assert
            order.SetDelivered(number);
        }

        [Test] 
    }
}
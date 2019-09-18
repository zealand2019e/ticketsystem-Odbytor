using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Test class to test if Price methods returns correct price.
        /// </summary>
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            double price = 0;
            Car tcar = new Car();
            //Act
            price = tcar.Price();
            //Assert
            Assert.AreEqual(price, 240);
        }

        /// <summary>
        /// Test method to test if Price method returns "Car" string.
        /// </summary>
        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            string type;
            Car tcar = new Car();
            //Act
            type = tcar.VehicleType();
            //Assert
            Assert.AreEqual(type, "Car");
        }

    }
}

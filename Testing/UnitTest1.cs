using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            price = tcar.Price(false);
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

        /// <summary>
        /// Test class to test if Price methods returns correct price.
        /// </summary>
        [TestMethod]
        public void TestPrice2()
        {
            //Arrange
            double price = 0;
            MC tmc = new MC();
            //Act
            price = tmc.Price(false);
            //Assert
            Assert.AreEqual(price, 125);
        }

        /// <summary>
        /// Test method to test if Price method returns "Car" string.
        /// </summary>
        [TestMethod]
        public void TestVehicleType2()
        {
            //Arrange
            string type;
            MC tcar = new MC();
            //Act
            type = tcar.VehicleType();
            //Assert
            Assert.AreEqual(type, "MC");
        }

        /// <summary>
        /// Test if licensplate character limit works
        /// </summary>
        [TestMethod]
        //[ExpectedException(typeof(ArgumentException), 
        //    "You need to enter Licensplate with maximum 7 numbers.")]
        public void TestLicensePlateCarLength()
        {
            void Test()
            {
                Car tcar = new Car();
                tcar.Licenseplate = "JFGSDFSDG";
            }
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(Test);
        }

        /// <summary>
        /// Test if licensplate character limit works
        /// </summary>
        [TestMethod]
        public void TestLicensePlateMCLength()
        {
            void Test()
            {
                MC tmc = new MC();
                tmc.Licenseplate = "JFG45GDFGF";
            }
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(Test);
        }

        /// <summary>
        /// Test if price is cut by 5%;
        /// </summary>
        [TestMethod]
        public void TestPriceDiscountCar()
        {
            //Arrange
            double price = 0;
            Car tcar = new Car();
            //Act
            price = tcar.Price(true);
            //Assert
            Assert.AreEqual(price, 228);
        }

        /// <summary>
        /// Test if price is cut by 5%;
        /// </summary>
        [TestMethod]
        public void TestPriceDiscountMC()
        {
            //Arrange
            double price = 0;
            MC tmc = new MC();
            //Act
            price = tmc.Price(true);
            //Assert
            Assert.AreEqual(price, 118.75);
        }
    }
}

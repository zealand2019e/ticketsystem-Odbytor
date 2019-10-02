using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLibrary;
using CompanyLibrary;

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

        /// <summary>
        /// Checks if discounts are applied correctly.
        /// </summary>
        [TestMethod]
        public void TestStorebaltsbroenDiscount()
        {
            //Arrange
            Car tcar = new Car();
            //Act
            //Dunno how to change DateTime.Now so i recommend changing the time on PC.
            //Assert
            Assert.AreEqual(228, tcar.Price(true), 0.01);
        }

        [TestMethod]
        public void CheckTimeSunday()
        {
            Car tcar = new Car();
            tcar.Date = new DateTime(2019, 09, 29);
            double Price = tcar.Price(true);
            Assert.AreEqual(182.4, Price, 0.1);
        }

        /// <summary>
        /// Test if the price is ok.
        /// </summary>
        [TestMethod]
        public void TestNewLibraryMC()
        {
            double price = 0;
            eMC teMC = new eMC();

            Assert.AreEqual(210, teMC.Price(false));
        }

        /// <summary>
        /// Test if the price is ok.
        /// </summary>
        [TestMethod]
        public void TestNewLibraryCar()
        {
            double price = 0;
            eCar teCar = new eCar();

            Assert.AreEqual(410, teCar.Price(false));
        }

        /// <summary>
        /// Test if the price is ok after discount.
        /// </summary>
        [TestMethod]
        public void TestNewLibraryMCD()
        {
            double price = 0;
            eMC teMC = new eMC();

            Assert.AreEqual(73, teMC.Price(true));
        }

        /// <summary>
        /// Test if the price is ok after discount.
        /// </summary>
        [TestMethod]
        public void TestNewLibraryCarD()
        {
            double price = 0;
            eCar teCar = new eCar();

            Assert.AreEqual(161, teCar.Price(true));
        }

        /// <summary>
        /// Test the type.
        /// </summary>
        [TestMethod]
        public void TestNewLibraryTypeMC()
        {
            //Arrange
            eMC teMC = new eMC();
            //Assert
            Assert.AreEqual( "Oresund MC", teMC.VehicleType());
        }

        /// <summary>
        /// Test the type.
        /// </summary>
        [TestMethod]
        public void TestNewLibraryTypeCar()
        {
            //Arrange
            eCar teCar = new eCar();
            //Assert
            Assert.AreEqual("Oresund Car", teCar.VehicleType());

        }
    }
}

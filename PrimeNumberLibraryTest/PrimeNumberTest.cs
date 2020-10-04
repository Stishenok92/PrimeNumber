using System.ComponentModel.DataAnnotations;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static PrimeNumberLibrary.PrimeNumber;

namespace PrimeNumberLibraryTest
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void ValidationNaturalNumber_33_ReturnedTrue()
        {
            //arrange
            int number = 33;
            bool expected = true;

            //act
            bool actual = ValidationNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidationNaturalNumber_Minus42_ReturnedFalse()
        {
            //arrange
            int number = -42;
            bool expected = false;

            //act
            bool actual = ValidationNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidationPrimeNumber_7_ReturnedTrue()
        {
            //arrange
            int number = 7;
            bool expected = true;

            //act
            bool actual = ValidationPrimeNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidationPrimeNumber_44_ReturnedFalse()
        {
            //arrange
            int number = 44;
            bool expected = false;

            //act
            bool actual = ValidationPrimeNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void ValidationPrimeNumber_Minus5_ValidationException()
        {
            //arrange
            int number = -45;

            //act + assert
            ValidationPrimeNumber(number);
        }
    }
}
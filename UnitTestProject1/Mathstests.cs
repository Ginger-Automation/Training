using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace UnitTestProject1
{
    [TestClass]
    public class MathsTests
    {

        [TestMethod]
        public void SubstractTwoNumbersTest()
        {
            //Arrange
            int a = 10;
            int b = 5;
            
            //Act
            int expected = MathsFunctions.SubrTractTwoNumbers(a,b);

            //Assert
            Assert.AreEqual(5, expected);
        }

        [TestMethod]
        public void DivideByTwo()
        {
            int expected = MathsFunctions.Divide_TwoNumbers(10, 2);


            Assert.AreEqual(5, expected); 
        }


        [TestMethod]
        public void AddTwoNumbersTest()
        {
            //Arrange
            int a = 10;
            int b = 5;

            //Act
            int total = MathsFunctions.AddTwoNumbers(a, b);

            //Assert
            Assert.AreEqual(15, total);
        }

        [TestMethod]
        public void AverageofTwoNumbers()
        {
            //Arrange
            int a = 10;
            int b = 2;

            //Act
            int expected = MathsFunctions.AverageTwoNumbers(a, b);

            //Assert
            Assert.AreEqual(6, expected);
        }

        [TestMethod]
        public void GetSquareTest()
        {
            //Arrange
            int a = 15;

            //Act
            double total = MathsFunctions.GetSquare(a);

            //Assert
            Assert.AreEqual(225, total);
        }

    }
}

﻿using System;
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
        public void SquareRootOfNumber()
        {
            //Arrange
            int a = 36;

            //Act
            double squareRoot = MathsFunctions.GetSquareRoot(a);

            //Assert
            Assert.AreEqual(6, squareRoot);
        }
    }
}

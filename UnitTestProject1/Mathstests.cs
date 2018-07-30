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
        public void CubeRoot()
        {
            //Arrange
            int input = 27;

            //Act
            double expected = MathsFunctions.GetCubeRoot(input);

            //Assert
            Assert.AreEqual(3, expected);
        }
    }
}

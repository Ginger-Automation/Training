using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace UnitTestProject1
{
    [TestClass]
    public class MathsTests
    {
       
        [TestMethod]
        public void DivideByTwo()
        {
            int expected = MathsFunctions.Divide_TwoNumbers(10, 2);


            Assert.AreEqual(5, expected); 
        }

        [TestMethod]
        public void AverageTwoNumbers()
        {
            int expected = MathsFunctions.AverageTwoNumbers(5, 9);
            Assert.AreEqual(7, expected);
        }
    }
}

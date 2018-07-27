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
        public void CubeRoot()
        {
            double expected = MathsFunctions.GetCubeRoot(27);
            Assert.AreEqual(3, expected);
        }
    }
}

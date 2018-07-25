
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace UnitTestProject1
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void ConcatTest()
        {
            //note
            Assert.AreEqual("ab", Strings.Concat("a","b"));
        }
    }
}

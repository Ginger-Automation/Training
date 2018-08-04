using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void StringConcat()
        {
            //Arrange
            string txt1 = "abc";
            string txt2 = "def";

            //Act
            string result = Strings.Concat(txt1, txt2);

            //Assert            
            Assert.AreEqual("abcdef", result, "abc+def=abcdef");
        }
    }
}

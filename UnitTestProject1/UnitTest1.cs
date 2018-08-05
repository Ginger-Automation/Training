using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //note
            Assert.AreEqual(true, true);
        }


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

        [TestMethod]
        public void ThreeStringsConcatTest()
        {
            //Arrange
            string txt1 = "abc";
            string txt2 = "def";
            string txt3 = "ghi";

            //Act
            string result = Strings.ConcatThreeStrings(txt1, txt2, txt3);

            //Assert            
            Assert.AreEqual("abcdefghi", result, "abc+def+ghi=abcdefghi");
        }
    }
}

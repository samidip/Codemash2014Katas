using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Word_Wrap_Kata;

namespace Word_Wrap_Test
{
    [TestClass]
    public class WordWrapTest
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            string actualWrappedLine = new WordWrapper().Wrap("Hello World is the first output to aim for in any new programming language", 20);
            string expectedWrappedLine = "Hello World is the" + "\n\r" + "first output to aim" + "\n\r" + "for in any new" + "\n\r" + "programming language";

            Assert.AreEqual(expectedWrappedLine, actualWrappedLine, true, "Hello World wrapping failed");
        }
    }
}

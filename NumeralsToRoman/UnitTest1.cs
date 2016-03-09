using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumeralsToRoman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("X",TransformNumber(10));
        }

        public string TransformNumber(int number)
        {
            return "";
        }

    }
}

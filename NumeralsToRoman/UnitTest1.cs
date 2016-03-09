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
            int a=1, b=2, max = 0;
             max = (a > b) ? a : b; // Base Idea

             int unit = number % 10; int zecimal = number / 10;
           
            string romanNumber = "";

            romanNumber += (zecimal ==10)? "X": "Not";
           
            return "";
        }

    }
}

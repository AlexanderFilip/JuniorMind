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
            Assert.AreEqual("X", TransformNumber(10));
        }

        public string TransformNumber(int number)
        {
            int a = 1, b = 2, max = 0;
            int unit = 0;
            int zecimal = 0;
            max = (a > b) ? a : b; // Base Idea

            unit = (number > 10) ? number % 10 : number;
            zecimal = (number > 10) ? number / 10 : number;

            string romanNumber = "";

            romanNumber += (zecimal == 10) ? "X" : "Not"; 
            return romanNumber;
        }

    }
}

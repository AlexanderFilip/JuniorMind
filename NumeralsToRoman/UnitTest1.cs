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
            Assert.AreEqual("II", TransformNumber(2));
        }

        public string TransformNumber(int number)
        {
            int unit = 0;
            int zecimal = 0;
            string romanNumber = "";

            unit = (number > 10) ? number % 10 : number;
            zecimal = (number > 10) ? number / 10 : number;

            romanNumber += (zecimal==10)? "X" : "";
            romanNumber += (unit == 1) ? "I" : (unit == 2) ? "II" : (unit == 3) ? "III" : (unit == 4) ? "IV" :
                (unit == 5) ? "V" : (unit == 6) ? "VI" : (unit == 7) ? "VII" : (unit == 8) ? "VIII" : (unit == 9) ? "IX" :"alt numar peste 19";

            return romanNumber;
        }

    }
    /*
     *  int a = 1, b = 2, max = 0;
            max = (a > b) ? a : b; // Base Idea*/
}

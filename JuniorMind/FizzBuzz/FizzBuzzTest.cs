using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string result = DivisionResult(5, "ana");
            Assert.AreEqual("Buzz", result);
        }
        
        public string DivisionResult(int number, string result)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                switch (number)
                {
                    case '1':
                        if (number % 3 == 0)
                        {
                            result = result + "Fizz";
                        }
                        break;
                    case '2':
                        if (number % 5 == 0)
                        {
                            result = result + "Buzz";
                        }
                        break;
                    case '3':
                        if (number % 3 == 0 && number % 5 == 0)
                        {
                            result = result + "FizzBuzz";
                        }
                        break;
                }
            }
            return result; 
        }
    }
}

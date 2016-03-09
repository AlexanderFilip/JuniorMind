using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersLand
{
    [TestClass]
    public class FarmersLandTests
    {
        [TestMethod]
        public void TestMethod1()
        {
           float perimeter = CalculateLandPerimeter( 230, 770);
           Assert.AreEqual(51.6m, perimeter);

        }
        public float CalculateLandPerimeter(  float new_width, float total_perimeter)
        {
         
         float initial_perimeter_side = (total_perimeter - 2*new_width )/6 ;
            return initial_perimeter_side*initial_perimeter_side;
                    }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureArea.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Area_0_0Returned()
        {
            //arrange
            Circle circle = new Circle(0);
            double correctArea = 0;

            //act
            double area = circle.Area;

            //assert
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void Area_4_50Point24Returned()
        {
            //arrange
            Circle circle = new Circle(4);
            double correctArea = 50.27;

            //act
            double area = Math.Round(circle.Area, 2);

            //assert
            Assert.AreEqual(correctArea, area);
        }
    }
}
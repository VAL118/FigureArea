using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureArea.Tests
{
    [TestClass]
    public class SomeFigureTests
    {
        [TestMethod]
        public void Area_4_50Point24Returned()
        {
            //arrange
            SomeFigure circle = new SomeFigure(4);
            double correctArea = 50.27;

            //act
            double area = Math.Round(circle.Area, 2);

            //assert
            Assert.AreEqual(correctArea, area);
        }
        
        [TestMethod]
        public void Area_3and4and5_6Return()
        {
            //arrange
            SomeFigure triangle = new SomeFigure(3,4,5);
            double correctArea = 6;
           
            //act
            double area = triangle.Area;

            //assert
            Assert.AreEqual(correctArea, area);
        }
    }
}
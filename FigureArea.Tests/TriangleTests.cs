using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureArea.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Area_0and0and0_0Return()
        {
            //arrange
            Triangle triangle = new Triangle(0,0,0);
            double correctArea = 0;
            
            //act
            double area = triangle.Area;

            //assert
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void Area_3and4and5_6Return()
        {
            //arrange
            Triangle triangle = new Triangle(3,4,5);
            double correctArea = 6;
           
            //act
            double area = triangle.Area;

            //assert
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void IsRightTriangle_0and0and0_TrueReturn()
        {
            //arrange
            Triangle triangle = new Triangle(0, 0, 0);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsTrue(isRight);
        }
        
        [TestMethod]
        public void IsRightTriangle_3and4and5_TrueReturn()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsTrue(isRight);
        }
        
        [TestMethod]
        public void IsRightTriangle_5and4and5_FalseReturn()
        {
            //arrange
            Triangle triangle = new Triangle(5, 4, 5);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsFalse(isRight);
        }
    }
}
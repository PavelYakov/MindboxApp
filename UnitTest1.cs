using MindboxApp;

namespace MIndboxAppTests
{
    [TestClass]
    public class FigireAreaTest
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            double radius = 10;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            Assert.AreEqual(expectedArea,circle.CalculateArea());
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            double storA=6;
            double storB=7;
            double storC=8;
            Triangle triangle = new Triangle (storA,storB,storC);
            double p = (storA + storB + storC) / 2;
            double expectedArea = Math.Sqrt(p*(p-storA)*(p-storB)*(p-storC));
            Assert.AreEqual(expectedArea, triangle.CalculateArea());
        }

        [TestMethod]
        public void IsRightAngledriangleTest()
        {
            double storA = 3;
            double storB = 4;
            double storC = 5;
            Triangle triangle = new Triangle(storA, storB, storC);
            Assert.IsTrue(triangle.IsRightAngled());
        }
    }
}
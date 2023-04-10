using TestTask;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaOfCircle()
        {
            var input = "круг";
            Figure? figure = null;
            switch (input)
            {
                case "круг":
                    figure = new Circle(10);
                    break;
                case "треугольник":
                    figure = new Triangle(5, 4, 3);
                    Assert.IsTrue(figure.IsRectangular());
                    break;
            }
            if (figure != null)
                Assert.IsNotNull(figure.CalcArea());
        }

        [TestMethod]
        public void TestAreaOfTriangle()
        {
            var input = "треугольник";
            Figure? figure = null;
            switch (input)
            {
                case "круг":
                    figure = new Circle(10);
                    break;
                case "треугольник":
                    figure = new Triangle(5, 4, 3);
                    Assert.IsTrue(figure.IsRectangular());
                    break;
            }
            if (figure != null)
                Assert.IsNotNull(figure.CalcArea());
        }
    }
}
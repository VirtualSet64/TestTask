namespace TestTask
{
    public class Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Figure(double radius)
        {
            A = radius;
        }
        public Figure(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double? CalcArea()
        {
            if (B != 0)
            {
                if (C != 0)
                {
                    var triangle = new Triangle(A, B, C);
                    return triangle.CalcAreaOfTriangle();
                }
            }
            else
            {
                var circle = new Circle(A);
                return circle.CalcAreaOfCircle();
            }
            return null;
        }

        public bool IsRectangular()
        {
            var triangle = new Triangle(A, B, C);
            return triangle.IsRectangularTriangle();
        }
    }
}

namespace TestTask
{
    public class Circle : Figure
    {
        public Circle(double radius) : base(radius)
        {
        }

        public double CalcAreaOfCircle()
        {
            var S = Math.PI * Math.Pow(A, 2);
            return S;
        }
    }
}
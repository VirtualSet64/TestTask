namespace TestTask
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalcArea()
        {
            var S = Math.PI * Math.Pow(Radius, 2);
            return S;
        }
    }
}
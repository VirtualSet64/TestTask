namespace TestTask
{
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c) : base(a, b, c)
        {
        }
        public double CalcAreaOfTriangle()
        {
            var p = (A + B + C) / 2;
            var S = Math.Sqrt(p * (p - C) * (p - B) * (p - C));
            return S;
        }

        public bool IsRectangularTriangle()
        {
            var max = Math.Max(Math.Max(A, B), C);
            if (max == A)
                if (Math.Pow(max, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                    return true;
            
            if (max == B)
                if (Math.Pow(max, 2) == Math.Pow(A, 2) + Math.Pow(C, 2))
                    return true;
            
            if (Math.Pow(max, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
                return true;

            return false;
        }
    }
}

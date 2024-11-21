namespace ClassLibrary1
{
    public class Point
    {
        public double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Rotate(double angle)
        {
            double Y = y * Math.Cos(angle) + x * Math.Sin(angle);
            x = x * Math.Cos(angle) - y * Math.Sin(angle);
            y = Y;
        }
        public void Resize(double coeff)
        {
            x *= coeff;
            y *= coeff;
        }
        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double Angle()
        {
            return Math.Atan(y / x);
        }
        static public Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
    }
}

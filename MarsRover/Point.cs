namespace MarsRover
{
    public record Point(decimal X, decimal Y)
    {
        public static Point operator +(Point a, Point b)
        {
            return new Point((decimal) (a.X + b.X), (decimal) (a.Y + b.Y));
        }


    }
}

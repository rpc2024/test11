
namespace test11
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux = x * x + y * y;
            return System.Math.Sqrt(aux);
        }

        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux = x * x + y * y + z * z;

            return System.Math.Sqrt(aux);
        }
        public static double GetCircleArea( double r)
        {
            return System.Math.PI * (r * r);
        }
        public static double GetDistance2D(double x1, double x2, double y1, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return GetVector2DLength(vx, vy);
        }
        //public static double AreIntersecting(double )
       //{

        //}
    }
}

using System;

namespace test11
{
    class Program
    {




        public static void Main(string[] args)
        {

            double len;
            len = Geometry.GetVector2DLength(1, 1);

            double len2;

            len2 = Geometry.GetVector3DLength(1, 2, 3);
            
            int a = 3;
            int b = 5;

            Misc.GetMinValue(a, b);
            Misc.GetMaxValue(a, b);

            int i = 1;
            int p = 2;

            Misc.IsEven(i);
            Misc.IsEven(p);

            int x = -2;
            int y = 3;

            Misc.IsPositive(x);
            Misc.IsPositive(y);

            int r = 2;

            Geometry.GetCircleArea(r);

            ejercicio.Ejercicio4();

        }

        
        
       

    }
}

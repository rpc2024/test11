

namespace test11
{
    class ejercicio
    {

        // Ejercicio: Hacer una función que imprima en pantalla los números del 0 al 99

        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador > 100)
            {
                System.Console.WriteLine (contador);
                contador++;
            }



        }

        // Hacer una función que imprima todos los números pares desde el 0 hasta n

        public static void Ejercicio2 (int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
            
        }
        

        public static void Ejercicio3()
        {   
            for (int i = 5; i > -90; i --) ;
        }


       // public static void Ejercicio4()
       // {
            
        //    for (int i = 0; i > 90; i++) ;
        //    {
        //        if ((i % 2) == 0)
        //            System.Console.WriteLine(-i);
        //        else
        //            System.Console.WriteLine(i);

        //    }
      //  }

        public static void Ejercicio4()
        {
            
            int number = 0;
            int number2 = 1;
            int i = number + number2;
           while (i < 90)
            {
                System.Console.WriteLine(i);
                number2 = number + number2;
                number = number2 - number;
            }



        }
    }
}

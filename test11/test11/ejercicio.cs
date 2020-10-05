

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
            // Hacer un programa si un número es primo o no
        }

    }
}

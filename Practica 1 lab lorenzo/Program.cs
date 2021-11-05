using System;

namespace Practica_1_lab_lorenzo
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int x = 0;
            int y = 1;
           
            for (int i = 0; i < n; i++)
            {
                int z = x;
                x = y;
                y = z + y;
            }
            return x;

        }

        static void Main()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            for (int i = 0; i <= 50; i++)
            {
                int contador = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                        break;
                    }
                }

                if (contador == 0 && i != 50)
                {
                //numeros que son primos dentro de la cifra de 50
                    Console.Write( "{0}  ", i);
                }

            }
            Console.ReadKey();
        }

    }
}

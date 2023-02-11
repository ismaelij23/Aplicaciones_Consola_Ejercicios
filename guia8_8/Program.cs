
/* 8. Se ingresa una lista de 20 números en un vector. Se pide ordenar dichos
      números en forma decreciente (de mayor a menor). Mostrar el listado
      ordenado informando también la posición original de cada número en el
      vector.
      Pista: usar ciclos combinados. */

using System;

namespace guia8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int[] posiciones = new int[20];

            for (int x = 0; x < 20; x++)
            {
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());

                numeros[x] = numero;
                posiciones[x] = x + 1;
            }

            //MÉTODO BURBUJA:
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 19; x++)
                {
                    if(numeros[x] < numeros[x + 1]){
                        int aux = numeros[x + 1];
                        numeros[x + 1] = numeros[x];
                        numeros[x] = aux;

                        aux = posiciones[x + 1];
                        posiciones[x + 1] = posiciones[x];
                        posiciones[x] = aux;
                    }
                }
            }

            Console.WriteLine("\nRESULTADOS:");
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("\nNúmero: " + numeros[x] + "\nPosición original: " + posiciones[x]);
            }
        }
    }
}

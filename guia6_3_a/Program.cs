
/* 3. Hacer un programa para ingresar los valores de los pesos de distintas
      encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
      ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
      pueden transportar hasta 200 kilos en total.
      
      Por ejemplo:

      10, 20, 140    70, 100    40, 10, 50, 80    90, 30, 40,   50       -10.
      Camión 1.      Camión 2   Camión 3          Camión 4      Camión 5

Se pide determinar e informar:
    a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
       Camión 2: 170kg, etc.). */

using System;

namespace guia6_3_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPeso: ");
            int peso = int.Parse(Console.ReadLine());
            int camion = 1;
            
            while(peso > 0){
                int pesoTotal = 0;
                while(peso > 0 && pesoTotal + peso <= 200){
                    pesoTotal += peso;
                    Console.Write("\nPeso: ");
                    peso = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nRESULTADO\nCamión: " + camion + "\nCarga: " + pesoTotal);
                camion++;
            }
        }
    }
}


/* 3. Hacer un programa para ingresar los valores de los pesos de distintas
      encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
      ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
      pueden transportar hasta 200 kilos en total.
      
      Por ejemplo:

      10, 20, 140    70, 100    40, 10, 50, 80    90, 30, 40,   50       -10.
      Camión 1.      Camión 2   Camión 3          Camión 4      Camión 5

     Se pide determinar e informar:

      b. El número de camión que transporta mayor cantidad de encomiendas
         (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
      c. La cantidad de camiones que se terminaron cargando. */

using System;

namespace guia6_3_b_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Peso: ");
            int peso = int.Parse(Console.ReadLine());

            int camionMaxEncomiendas = 0;
            int contCamiones = 1;
            int contEncomiendas_Max = 0;

            while(peso > 0){
                int contEncomiendas_Aux = 0;
                int pesoMax = 0;

                while(peso > 0 && peso + pesoMax <= 200){
                    pesoMax += peso;
                    contEncomiendas_Aux++;

                    Console.Write("Peso: ");
                    peso = int.Parse(Console.ReadLine());

                    if(peso > 200){
                        Console.Write("\nEl paquete es muy grande, intruduzca un paquete menor o igual a 200kg: ");
                        peso = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("\nExcedente de carga, el paquete sera cargado en el siguiente camión\n");

                if(contEncomiendas_Aux > contEncomiendas_Max){
                    contEncomiendas_Max = contEncomiendas_Aux;
                    camionMaxEncomiendas = contCamiones;
                }

                contCamiones++;
            }
            Console.WriteLine("\nRESULTADOS\nCamiones cargados: " + contCamiones + "\nCamión con mayor cantidad encomiendas: " + camionMaxEncomiendas + "\nTotal: " + contEncomiendas_Max);
        }
    }
}

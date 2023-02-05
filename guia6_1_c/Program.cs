
/* 1. Se dispone de una lista de 10 grupos de números enteros separados entre ellos
      por ceros. Se pide determinar e informar:
         c. Informar cuántos grupos están formados por todos números ordenados
            de mayor a menor. */

using System;

namespace guia6_1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            for (int x = 0; x < 3; x++)
            {
                int bandera = 1;

                Console.Write("\nIngrese el primer número del grupo " + (x + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());
                int aux = numero;

                while(numero != 0){
                    if(!(numero <= aux)){
                        bandera = 0;
                    }
                    aux = numero;
                    Console.Write("\nIngrese otro número: ");
                    numero = int.Parse(Console.ReadLine());
                }

                if(bandera == 1){
                    cont++;
                }
            }

            Console.WriteLine("\nRESULTADO\nGrupos ordenados: " + cont);
        }
    }
}

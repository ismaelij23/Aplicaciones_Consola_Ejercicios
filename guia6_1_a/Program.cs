
/* 1. Se dispone de una lista de 10 grupos de números enteros separados entre ellos
      por ceros. Se pide determinar e informar:
         a. El número de grupo con mayor porcentaje de números impares
            positivos respecto al total de números que forman el grupo. */

using System;

namespace guia6_1_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxP = 0;
            int gMax = 0;
            int contieneImpGrupos = 0;

            for (int x = 0; x < 3; x++)
            {
                int numero;

                if(x == 0){
                    Console.WriteLine("\nARRANCASTE EL GRUPO " + (x + 1));
                    Console.Write("Ingrese el primer número del grupo: ");
                    numero = int.Parse(Console.ReadLine());
                } else {
                    Console.WriteLine("\nARRANCASTE EL GRUPO " + (x + 1));
                    Console.Write("Ingrese el primer número del grupo: ");
                    numero = int.Parse(Console.ReadLine());
                }

                int totalNros = 0;
                int impPos = 0;

                while(numero != 0){
                    if(numero > 0){
                        if(!(numero % 2 == 0)){
                            impPos++;
                        }
                    }
                    totalNros++;
                    Console.Write("Ingrese otro número: ");
                    numero = int.Parse(Console.ReadLine());
                }

                int porcentaje;
                if(impPos > 0){
                    contieneImpGrupos++;
                    porcentaje = (impPos * 100) / totalNros;
                    if(porcentaje > maxP){
                    maxP = porcentaje;
                    gMax = (x + 1);
                    }
                } else {
                    Console.WriteLine("ATENCIÓN: El grupo " + (x + 1) + " no cuenta con impares positívos");
                }

            }
            
            if(contieneImpGrupos != 0)
                Console.WriteLine("\nGrupo con mayor porcentaje de números impares positívos: " + gMax + "\n");
            else 
                Console.WriteLine("\nNINGÚN GRUPO CUENTA CON IMPARES POSITÍVOS\n");
        }
    }
}

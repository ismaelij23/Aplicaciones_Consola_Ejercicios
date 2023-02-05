
/* 1. Se dispone de una lista de 10 grupos de números enteros separados entre ellos
      por ceros. Se pide determinar e informar:
         b. Para cada grupo, el último número primo y en qué orden apareció en
            ese grupo. Si en un grupo no hubiera números primos, informarlo con
            un cartel aclaratorio. */

using System;

namespace guia6_1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 3; x++)
            {
                int ultPr = 0;
                int orden = 0;
                int ordenPr = 0;

                Console.Write("\nIngrese el primer número del grupo " + (x + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());

                while(numero != 0){
                    orden++;
                    int j = 1;
                    int cont = 0;

                    while(j <= numero){
                        if(numero % j == 0){
                            cont++;
                        }
                        j++;
                    }
                    if(cont == 2){
                        ultPr = numero;
                        ordenPr = orden;
                    }

                    Console.Write("\nIngrese otro número, o 0 para cortar: ");
                    numero = int.Parse(Console.ReadLine());
                }

                if(ultPr != 0){
                    Console.WriteLine("\nRESULTADOS: \nGrupo: " + (x + 1) + "\nÚltimo número primo: " + ultPr + "\nPosición: " + ordenPr);
                }
            }
        }
    }
}

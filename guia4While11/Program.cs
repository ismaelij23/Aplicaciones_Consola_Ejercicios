using System;

namespace guia4While11
{
    class Program
    {
        static void Main(string[] args)
        {
                int contPares = 0;
                int contPos = 0;
                int contPrimos = 0;
                int contNeg = 0;

                Console.WriteLine("Ingrese un número");
                int numero = int.Parse(Console.ReadLine());

                while(numero != 0){
                    if(numero > 0) {
                        contPos++;
                    } else {
                        contNeg++;
                    }

                    if(numero % 2 == 0) {
                        contPares++;
                    }

                    int aux = 1;
                    int cont = 0;

                    while(aux <= numero){
                        if(numero % aux == 0){
                            cont++;
                        }
                        aux++;
                    }
                    if(cont == 2){
                        contPrimos++;
                    }

                    Console.WriteLine("Ingrese otro número, si desea para ejecución ingrese 0");
                    numero = int.Parse(Console.ReadLine());
                }
                // 3 7 13 59 primos y positivos 4
                // 4 6 8 10 pares y positivos 4
                // 22 26 pos 2 
                // -1 -5 -7 

                //pos = 10
                //neg = 3
                //pares = 6
                //primos = 4

                Console.WriteLine("\n\nRESULTADOS");
                Console.WriteLine("Positivos: " + contPos + "\nNegativos: " + contNeg + "\nPares: " + contPares + "\nPrimos: " + contPrimos + "\n");
        }
    }
}

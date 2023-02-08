
/* 8. Hacer un programa que permita ingresar una lista de números que corta
      cuando se ingresa un cero. A partir de dichos datos informar:
        a. El mayor de los números pares.
        b. La cantidad de números impares.
        c. El menor de los números primos. */

using System;

namespace guia7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPar = 0;
            int bPar = 0;
            int contImpares = 0;
            int minPrimo = 0;
            int bPr = 0;

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            while(numero != 0){
                int par = esPar(numero);
                if(par == 1){
                    if(bPar == 0){
                        maxPar = numero;
                        bPar = 1; 
                    }
                    else if(numero > maxPar)
                        maxPar = numero;
                } 
                else{
                    contImpares++;
                }

                int primo = esPrimo(numero);
                if(primo == 1){
                    if(bPr == 0){
                        minPrimo = numero;
                        bPr = 1;
                    }
                    else if(numero < minPrimo){
                        minPrimo = numero;
                    }
                }
                Console.Write("Ingrese otro número: ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nRESULTADOS\nMayor par: " + maxPar + "\nImpares: " + contImpares + "\nMenor primo: " + minPrimo); 
        }

        static int esPar(int n){
            if(n % 2 == 0)
                return 1;
            else
                return 0;
        }
        static int esPrimo(int n){
            int j = 1;
            int c = 0;
            while(j <= n){
                if(n % j == 0)
                    c++;
                j++;
            }
            if(c == 2)
                return 1;
            else
                return 0;
        }
    }
}


/* 7. Hacer una función de tipo void (porque no va a devolver nada) llamada
      “positivoNegativoCero” que reciba un número por valor y una variable por
      referencia. Que analice el número y escriba variable recibida por referencia
      con:
        a. 1 si el número es positivo.
        b. -1 si el número es negativo.
        c. 0 si el número es cero. */

using System;

namespace guia7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int contPos = 0;
            int contNeg = 0;
            int contCer = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());
                int resultado = 0;
                positivoNegativoCero(numero, ref resultado);

                if(resultado == 1)
                    contPos++;
                else if(resultado == -1)
                    contNeg++;
                else
                    contCer++;
            }   

            Console.WriteLine("\nRESULTADOS\nPositivos: " + contPos + "\nNegativos: " + contNeg + "\nCeros: " + contCer);
        }

        static void positivoNegativoCero(int n, ref int r){
            if(n > 0)
                r = 1;
            else if(n < 0)
                r = -1;
            else
                r = 0;
           }
    }
}


/* 6. Hacer una función que se llame “sumaResta” que reciba dos números y que
      devuelva la suma Y la resta del primer número con el segundo.
      
      Nota: recordemos que una función solo puede devolver UN valor por return.
      Cómo podríamos hacer para tener ambos resultados en el main? */

using System;

namespace guia7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro: ");
            int n2 = int.Parse(Console.ReadLine());

            int suma = sumaResta(n1, ref n2);
            int resta = n2;

            Console.WriteLine("\nSuma: " + suma + "\nResta: " + resta);
        }

        static int sumaResta(int n1, ref int n2){
            int suma = n1 + n2;
            n2 = n2 - n1;
            return suma;
        }
    }
}

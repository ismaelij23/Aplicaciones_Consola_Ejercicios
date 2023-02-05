using System;

namespace guia4While8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int num1 = int.Parse(Console.ReadLine());
            int min1 = num1;
            int pos1 = 1;
            int min2 = 0;
            int pos2 = 0;

            Console.WriteLine("Ingrese otro número");
            int num2 = int.Parse(Console.ReadLine());

            if(num2 < num1){
                min2 =  min1;
                pos2 = pos1;
                pos1 = 2;
                min1 = num2;
            } else {
                min2 = num2;
                pos2 = 2;
            }

            Console.WriteLine("Siga ingresando números, para cortar ingrese 0");
            int aux = int.Parse(Console.ReadLine());
            int posAux = 3;

            while(aux != 0){
                if(aux < min1){
                    min2 = min1;
                    pos2 = pos1;
                    min1 = aux;
                    pos1 = posAux;
                } else { 
                    if(aux < min2){
                        min2 = aux;
                        pos2 = posAux;
                    }
                }
                posAux++;
                Console.WriteLine("Siga ingresando números, para cortar ingrese 0");
                aux = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1er Menor: " + min1 + "\nPosición: " + pos1 + "\n2do Menor: " + min2 + "\nPosición: " + pos2);
        }
    }
}

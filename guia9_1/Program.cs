
/* 1. Una empresa que fabrica 20 artículos tiene la siguiente información para cada uno de ellos:
        - Código de Artículo (4 dígitos, no correlativos).

    Este primer lote no se encuentra ordenado.
    Cuenta por otro lado con un lote de registros con las ventas del año anterior. Cada registro contiene
    la siguiente información:

        - Código de Artículo (4 dígitos no correlativos).
        - Mes (1 a 12).
        - Cantidad vendida.

    Puede haber más de un registro para el mismo artículo. El lote finaliza con un registro con código de artículo igual a cero.
    Se pide:
        a) Un listado con el siguiente formato:
            Código de Artículo      Cantidad Total Vendida
                    999                      999

    Este listado debe salir ordenado de mayor a menor por cantidad total vendida.
        b) Informar, si los hubiera, los nombres de los meses en que no hubo ventas.
        c) Informar los códigos de los artículos cuyas ventas en cantidad son mayores al promedio. */

using System;

namespace guia9_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] codArticulos = new int[4];
            int[] cantVendArticulos = new int[4];
            bool[] meses = new bool[12];
            
            cargarVector(ref codArticulos, 4);
            proceso(ref codArticulos, ref cantVendArticulos, ref meses);
            Console.WriteLine("\n\n\nPUNTO A:");
            funcionPtoA(ref codArticulos, ref cantVendArticulos, 4);
            Console.WriteLine("\n\n\nPUNTO B:");
            funcionPtoB(ref meses);
            Console.WriteLine("\n\n\nPUNTO C: \n\n");
            funcionPtoC(ref codArticulos, ref cantVendArticulos);
        }

        static void cargarVector(ref int[] codigos, int vueltas){
            for (int x = 0; x < vueltas; x++)
            {
                Console.Write("\nCódigo de artículo: ");
                int codigo = int.Parse(Console.ReadLine());

                codigos[x] = codigo;
            }
            Console.WriteLine("CARGA COMPLETADA CON ÉXITO");
        }
        static void proceso(ref int[] vectorCod, ref int[] vectorCant, ref bool[] meses){
            Console.Write("\nCódigo de artículo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("\nMes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("\nCantidad vendida: ");
            int cant = int.Parse(Console.ReadLine());
            
            while(codigo != 0){
                int i = buscar(ref vectorCod, 8, codigo);
                vectorCant[i] += cant;
                meses[mes - 1] = true;

                Console.Write("\nCódigo de artículo: ");
                codigo = int.Parse(Console.ReadLine());
                Console.Write("\nMes: ");
                mes = int.Parse(Console.ReadLine());
                Console.Write("\nCantidad vendida: ");
                cant = int.Parse(Console.ReadLine());
            }
            
        }
        static int buscar(ref int[]vector, int vueltas, int cod){
            for (int x = 0; x < vueltas; x++)
            {
                if(cod == vector[x])
                    return x;      
            }
            return -1;
        }
        static void funcionPtoA(ref int[] vectorCod, ref int[] vectorCant, int vueltas){
            int[] vectorCodAux = new int[vueltas];
            int[] vectorCantAux = new int[vueltas];
            copiaVector(ref vectorCod, ref vectorCodAux, vueltas);
            copiaVector(ref vectorCant, ref vectorCantAux, vueltas);
            ordenar(ref vectorCodAux, ref vectorCantAux, vueltas);
            mostrar(ref vectorCodAux, ref vectorCantAux, vueltas);
        }
        static void copiaVector(ref int[] vectorCod, ref int[] vectorAux, int vueltas){
            for (int x = 0; x < vueltas; x++)
            {   
                vectorAux[x] = vectorCod[x];
            }
        }
        static void ordenar(ref int[] vectorAux, ref int[] vectorCant, int vueltas){
            for (int y = 0; y < vueltas; y++)
            {
                for (int x = 0; x < vueltas - 1; x++)
                {
                    if(vectorCant[x] < vectorCant[x + 1]){
                        int aux = vectorCant[x];
                        vectorCant[x] = vectorCant[x + 1];
                        vectorCant[x + 1] = aux;

                        aux = vectorAux[x];
                        vectorAux[x] = vectorAux[x + 1];
                        vectorAux[x + 1] = aux;
                    }
                }
            }
        }
        static void mostrar(ref int[] vectorAux, ref int[] vectorCant, int vueltas){
            for (int x = 0; x < vueltas; x++)
            {   
                Console.Write("\nCódigo de artículo     " + "Cantidad total vendida \n" + "        " +vectorAux[x] + "                        " + vectorCant[x]);
            }
        }
        static void funcionPtoB(ref bool[] vectorMeses){
            for (int x = 0; x < 12; x++)
            {
                if(!vectorMeses[x]){
                    Console.Write(mMes(x) + "   ");
                }
            }
        }
        static string mMes(int m){
            switch(m){
                case 0:
                    return "Enero";
                case 1: 
                    return "Febrero";
                case 2: 
                    return"Marzo";
                case 3:
                    return "Abril";
                case 4:
                    return "Mayo";
                case 5: 
                    return "Junio";
                case 6: 
                    return "Julio";
                case 7:
                    return "Agosto";
                case 8:
                    return "Septiembre";
                case 9:
                    return"Octubre";
                case 10:
                    return "Noviembre";
                default:
                    return"Diciembre";
            }
        }
        static void funcionPtoC(ref int[] vectorCod, ref int[] vectorCant){
            int acu = 0;
            
            for (int x = 0; x < 4; x++)
            {
                acu += vectorCant[x];
            }

            float promedio = acu / 4;

            for (int x = 0; x < 4; x++)
            {
                if(vectorCant[x] > promedio){
                    Console.WriteLine("Las ventas del código de artículo " + vectorCod[x] + "(" + vectorCant[x] + ")" +" son mayores al promedio, el cual es " + promedio);
                }
            }
        }
    }
}

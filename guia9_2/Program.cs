
/* 2. Se dispone de un lote de 5 registros (uno por artículo), cada uno de los cuales tiene la
      siguiente información:
        - Número de artículo (4 dígitos no correlativos).
        - Cantidad de unidades en stock.
        - Precio Unitario.
      
      El lote está desordenado.
      Se dispone de otro lote de registros, cada uno de los cuales corresponde a una venta con la siguiente
      información:
        - Número de cliente (1 a 5).
        - Número de artículo (4 dígitos, no correlativos).
        - Cantidad de unidades vendidas.

      El último registro de este lote tiene número de cliente cero y no debe procesarse. Desarrollar el
      programa que determine e imprima:
      a) Un listado de las ventas realizadas, con el siguiente formato:

                                        Listado de ventas
          |  Nro. Cliente    |    Nro. Artículo   |    Cantidad Vendida    |    Importe Total  |
          |      99          |         99         |          999           |       999.99      |

      b) Informar cuál es el número de cliente que más compró en total (en pesos).
      c) Informar cada uno de los números de los artículos que no hayan registrado ventas. */

using System;

namespace guia9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vArt = new int[5];
            int[] vStock = new int[5];
            float[] vPrecio = new float[5];
            float[] vPtoB = new float[5];
            bool[] vPtoC = new bool[5];

            cargar(ref vArt, ref vStock, ref vPrecio);
            proceso(ref vArt, ref vPrecio, ref vPtoB, ref vPtoC);
            fPtoB(ref vPtoB);
            fPtoC(ref vArt, ref vPtoC);
        }
        static void cargar(ref int[]vArt, ref int[]vStock, ref float[]vPrecio){
            for (int x = 0; x < 5; x++)
            {
                Console.Write("\nNúmero de artículo: ");
                int nroArt = int.Parse(Console.ReadLine());
                /* Console.Write("Stock: ");
                int stock = int.Parse(Console.ReadLine()); */
                Console.Write("\nPrecio: ");
                float precio = float.Parse(Console.ReadLine());

                vArt[x] = nroArt;
                /* vStock[x] = stock; */
                vPrecio[x] = precio;
            }
        }
        static void proceso(ref int[]vArt, ref float[]vPrecio, ref float[]vPtoB, ref bool[]vPtoC){
            Console.Write("\nNúmero de cliente: ");
            int nroCliente = int.Parse(Console.ReadLine());
            Console.Write("\nNúmero de artículo: ");
            int nroArt = int.Parse(Console.ReadLine());
            Console.Write("\nCantidad vendida: ");
            int cantVend = int.Parse(Console.ReadLine());

            while(nroCliente != 0){
                int i = buscar(nroArt, ref vArt);
                float total = vPrecio[i] * cantVend;
                vPtoB[nroCliente - 1] += total;
                vPtoC[i] = true;
                
                Console.WriteLine("\nVENTA:");
                Console.WriteLine("Número de cliente: " + nroCliente + "\nNúmero de artículo: " + nroArt + "\nCantidad vedida: " + cantVend + "\nTotal: " + total);

                Console.Write("\nNúmero de cliente: ");
                nroCliente = int.Parse(Console.ReadLine());
                Console.Write("\nNúmero de artículo: ");
                nroArt = int.Parse(Console.ReadLine());
                Console.Write("\nCantidad vendida: ");
                cantVend = int.Parse(Console.ReadLine());
            }
        }
        static int buscar(int nroArt, ref int[]vArt){
            int ind = 0;
            for (int x = 0; x < 5; x++)
            {
                if(nroArt == vArt[x])
                    ind = x;
            }
            return ind;
        }
        static void fPtoB(ref float[]vPtoB){
            float max = 0;
            int clMax = 0;
            
            for (int x = 0; x < 5; x++)
            {
                if(vPtoB[x] > max){
                    max = vPtoB[x];
                    clMax = x + 1;
                }
            }

            Console.WriteLine("\nRESULTADO PUNTO B\nCliente que más compro:" + clMax + "\nTotal: $" + max);
        }
        static void fPtoC(ref int[]vArt, ref bool[]vPtoC){
            Console.WriteLine("\nRESULTADO PUNTO C\nArtículos que no se vendieron: ");
            for (int x = 0; x < 5; x++)
            {
                if(!vPtoC[x])
                    Console.Write(vArt[x] + " ");
            }
        }
    }
}

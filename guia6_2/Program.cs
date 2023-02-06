
/* 2. Una compañía de electricidad necesita calcular anualmente el consumo que ha
      registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
      Para ello tiene un lote de registros por cada uno de los usuarios con los
      siguientes datos:
        
        • Zona (numérico entero).
        • Número de cliente (número de cuatro dígitos no correlativos).
        • Cantidad de kilovatios consumidos en el periodo.

      El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
      con zona igual a cero.
      Se pide generar un listado con el siguiente formato:

      Zona: XX
      Cantidad de usuarios de la zona: XX
      Total facturado en la zona: XX

      Zona: XX
      Cantidad de usuarios de la zona: XX
      Total facturado en la zona: XX

      El precio es escalonado según la siguiente escala:
          • $ 0.10 por kv por los primeros 100 kv de consumo.
          • $ 0.12 por kv por el consumo de 101 a 200 kvs.
          • $ 0.15 por kv por el consumo de 201 kvs en adelante. */

using System;

namespace guia6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zona: ");
            int zona = int.Parse(Console.ReadLine());
            Console.Write("Número de cliente: ");
            int nroCliente = int.Parse(Console.ReadLine());
            Console.Write("Consumo: ");
            int consumo = int.Parse(Console.ReadLine());

            while(zona != 0){
                int zonaActual = zona;
                int usuarios = 0;
                double totalFacturado = 0;

                while(zona == zonaActual){
                    if(consumo <= 100){
                        totalFacturado += consumo * 0.10;
                    }
                    else if(consumo <= 200){
                        totalFacturado += consumo * 0.12;
                    } 
                    else {
                        totalFacturado += consumo * 0.15;
                    }

                    usuarios++;

                    Console.Write("\nZona: ");
                    zona = int.Parse(Console.ReadLine());
                    Console.Write("Número de cliente: ");
                    nroCliente = int.Parse(Console.ReadLine());
                    Console.Write("Consumo: ");
                    consumo = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nRESULTADOS\nZona: " + zonaActual + "\nCantidad de usuarios: " + usuarios + "\nTotal facturado: " + totalFacturado + "\n");
            }
        }
    }
}

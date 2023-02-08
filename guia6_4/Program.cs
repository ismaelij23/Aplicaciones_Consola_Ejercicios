
/* 4. Una compañía de turismo aventura registró los paquetes vendidos durante la
      última temporada vacacional. Para cada venta se ingresó:
        • Número de paquete (4 dígitos no correlativos).
        • Cantidad de personas incluidas.
        • Precio por persona.
        • Horas totales de actividades.
        • Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.
          “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”,
          Parapente).

    El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con
    número de paquete cero. En el lote no se ingresan registros cuyo tipo de aventura
    no se haya vendido.

    A partir de dichos datos, se solicita informar:

        a. La cantidad de paquetes vendidos de cada tipo de aventura..
        b. La cantidad total de personas que disfrutaron de las aventuras durante la
           temporada.
        c. El total recaudado por cada venta.
        d. La venta con mayor importe de cada tipo de aventura.
        e. El paquete con menos horas incurridlas y en qué tipo de actividad fue. */

using System;

namespace guia6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de paquete: ");
            int nroPaquete = int.Parse(Console.ReadLine());
            Console.Write("\nCantidad de personas: ");
            int cantPersonas = int.Parse(Console.ReadLine());
            Console.Write("\nPrecio por persona: ");
            int precioXPersona = int.Parse(Console.ReadLine());
            Console.Write("\nHoras totales de actividades: ");
            int horasTotales = int.Parse(Console.ReadLine());
            Console.Write("\nTipo de aventura: ");
            char tipoAventura = char.Parse(Console.ReadLine());

            int acuPtoB = 0;
            int bandPtoE = 0;

            while(nroPaquete != 0){
                char tipoAventuraActual = tipoAventura;
                int contPtoA = 0;
                int ventaMax = 0;

                while(tipoAventura == tipoAventuraActual){
                    contPtoA++;
                    acuPtoB++;
                    int precioTotalVenta = cantPersonas * precioXPersona;
                    Console.WriteLine("Precio del paquete: " + precioTotalVenta);
                    if(precioTotalVenta > ventaMax){
                        ventaMax = precioTotalVenta;
                    }
                }
            }
        }
    }
}

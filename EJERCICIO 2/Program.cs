using System;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double compra, descuento, total;
            compra = 410;
            descuento = compra * 0.20;
            total = compra - descuento;
            if (compra > 300)
            {
                Console.Write("El descuento es de: " + descuento);
                Console.Write("El total a pagar es: " + total);

            }

            else
                Console.Write("Sin descuentos, el total es:" + total);

        }
    }
}

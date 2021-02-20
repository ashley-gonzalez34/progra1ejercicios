using System;

namespace EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha;
            int año;
            bool x;
            string formato;

            Console.Write("Introduce una fecha en formato Dia/Mes/Anio: ");
            x = DateTime.TryParse(Console.ReadLine(), out fecha);

            if (x == true)
            {

                formato = fecha.ToString("yyyy");
                int.TryParse(formato, out año);

                if (DateTime.IsLeapYear(año))
                {
                    Console.WriteLine("El año Es bisiesto");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El año No es bisiesto");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("el formato son incorrectos");
                Console.ReadLine();

            }
        }
}

using System;

namespace EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduce un dia de la semana");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("lunes");
                    break;
                case "martes":
                    Console.WriteLine("martes");
                    break;
                case "miercoles":
                    Console.WriteLine("miercoles");
                    break;

                case "jueves":
                    Console.WriteLine("jueves");
                    break;
                case "viernes":
                    Console.WriteLine("viernes");
                    break;
                    Console.WriteLine("Es un dia laboral");
                    break;


                case "sabado":
                    Console.WriteLine("sabado");
                    break;
                case "domingo":
                    Console.WriteLine("domingo");
                    break;

                    Console.WriteLine("Es un dia festivo");
                    break;

                default:

                    Console.Write("Coloque un dia de la semana");
                    break;
            }

        }
    }
}

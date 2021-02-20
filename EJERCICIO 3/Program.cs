using System;

namespace EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                float ss;
                int ht, he;

                Console.Write("Ingrese las horas que trabajo:");
                ht = int.Parse(Console.ReadLine());
                if (ht > 40)
                {
                    he = ht - 40;

                    ss = he * 20 + 40 * 16;
                }
                else
                {

                    ss = ht * 16;
                }

                Console.Write("El Salario de la semana es :{0}", ss);
                Console.ReadLine();
            }
        }
    }
}

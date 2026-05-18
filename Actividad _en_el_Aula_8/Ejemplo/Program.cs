using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicializaciones
            int variable1 = 0;
            int opcion;

            //iterar opcion
            do
            {
                //opciones del menú
                Console.Clear();
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Opción 1");
                Console.WriteLine("2. Opción 2");
                Console.WriteLine("Otro. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());


                //Verificar Opción seleccionada y procesar
                switch (opcion)
                {
                    case 1:
                        //procesar opción 1
                        Console.Clear();
                        Console.WriteLine("Opcion 1");
                        Console.ReadKey();
                        break;

                    case 2:

                        //procesar opción 2
                        Console.Clear();
                        Console.WriteLine("Opcion 2");
                        Console.ReadKey();

                        break;
                }
            }
            while (opcion > 0 && opcion >= 2);


            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1;

internal class Program
{
    static void Main(string[] args)
    {
        #region declarando e inicializaciones
        double acum, num, prom;
        int contador, opcion;
        acum = 0;
        contador = 0;
        #endregion

        //iterar opcion
        do
        {
            #region opciones del menú
            Console.Clear();
            Console.WriteLine("Titulo de programa");
            Console.WriteLine("1_Solicitar un número");
            Console.WriteLine("2_Informar acumulado");
            Console.WriteLine("3_Cant acumulados");
            Console.WriteLine("4_Calulo e informe promedio");
            Console.WriteLine("Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Verificar opción seleccionada y procesar
            switch (opcion)
            {
                case 1:
                    #region Solicitar un número
                    Console.Clear();
                    Console.WriteLine("Ingrese un número: ");
                    num = Convert.ToDouble(Console.ReadLine());
                    acum += num; // acum+= num;
                    contador = contador + 1; //contador++;
                    Console.WriteLine("Presione cualquier tecla para volver al menú");
                    Console.ReadKey();
                    #endregion
                    break;

                case 2:
                    //procesar opción 2
                    Console.Clear();
                    Console.WriteLine("El acumulado es de: " +acum);
                    Console.ReadKey();
                    break;

                case 3:
                    //cantidad acumulados
                    Console.Clear();
                    Console.WriteLine("La cantidad acumulada es de: " +contador);
                    Console.WriteLine("Presione cualquier tecla para volver al menú");
                    Console.ReadKey();
                    break;

                case 4:
                    // calcular e informar promedio
                    if (contador > 0)
                    {
                        prom = 1.0 * acum / contador;
                        Console.Clear();
                        Console.WriteLine($"El promedio es de: {prom:f2}");
                    }
                    else
                    {
                        Console.WriteLine("No hay datos para calcular el promedio.");
                    }

                    Console.WriteLine("Presione cualquier tecla para volver al menú");
                    Console.ReadKey();
                    break;
            }
            #endregion
        }
        while (opcion >= 1 && opcion >= 4);

        Console.WriteLine("Presione una tecla para salir");
        Console.ReadKey();

    }
}
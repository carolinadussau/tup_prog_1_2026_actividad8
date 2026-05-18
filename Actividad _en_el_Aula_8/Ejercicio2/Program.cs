using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2;

internal class Program
{
    static int Acumulado;
    static int Cantidad;

    static void RegistrarNumero(int numero)
    {
        Acumulado += numero; // Acumulado += numero;
        Cantidad = Cantidad + 1; //Cantidad++;
    }


    static void MostrarPantallaSolicitarNumero()
    {
        Console.Clear();
        Console.WriteLine("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Program.RegistrarNumero(numero);
        Console.WriteLine("Presione cualquier tecla para volver al menú");
        Console.ReadKey();
    }

    static void MostrarPantallaAcmulado()
    {
        Console.Clear();

        Console.WriteLine($"Acumulado: {Acumulado} ");

        Console.WriteLine("Presione cualquier tecla para volver al menú");
        Console.ReadKey();
    }


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
                    Program.MostrarPantallaSolicitarNumero();
                    break;

                case 2:
                    Program.MostrarPantallaAcmulado();
                    break;

                default:
                    opcion = 5;
                    break;
            }
            #endregion
        }
        while (opcion !=5);

        Console.WriteLine("Presione una tecla para salir");
        Console.ReadKey();

    }
}
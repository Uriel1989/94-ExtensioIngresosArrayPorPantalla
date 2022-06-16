using System;

//Extension y valores internos del Array ingresados por pantalla

namespace _94_ExtensioIngresosArrayPorPantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorLeft = 30;
            Console.WriteLine("Ingrese la extension del array:");

            int i = Convert.ToInt32(Console.ReadLine());


            int[] array = new int[i];


            Console.CursorLeft = 30;

            Console.WriteLine("Ahora ingrese los valores:");


            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine("Ingrese el valor de la posicion " + x + ": " + (array[x] = int.Parse(Console.ReadLine())));
            }

            Console.Clear();

            Console.CursorLeft = 30;

            Console.WriteLine("Los valores ingresados son:");

            for (int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a]);
            }
        }
    }
}

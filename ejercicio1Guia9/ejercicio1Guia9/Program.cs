using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1Guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Double[] nota = new double[9];
            int mayor = 0;
            for (int x = 0; x < 9; x++)
            {
                Console.WriteLine($"Ingrese el dato/nota {(x + 1)}");
                nota[x] = Double.Parse(Console.ReadLine());
                if (nota[x] == 8.5)
                {
                    mayor++;
                }
            }
            Console.WriteLine($"Hay {mayor} notas iguales a 8.5");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Double[] medidaM;
            int piezasP = 0, ideales = 0;
            Console.WriteLine("Ingrese la cantidad de piezas ");
            piezasP = int.Parse(Console.ReadLine());
            medidaM = new Double[piezasP];
            for (int x = 0; x < piezasP; x++)
            {
                Console.WriteLine($"Ingrese la medida de la pieza que desea");
                medidaM[x] = Double.Parse(Console.ReadLine());
                if (medidaM[x] <= 1.40 && medidaM[x] >= 1.20)
                {
                    ideales++;
                }
            }
            Console.WriteLine($"Hay {ideales} piezas ideales detectadas.");
            Console.ReadKey();
        }
    }
}

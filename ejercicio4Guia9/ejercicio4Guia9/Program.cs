using System;
using System.Linq;
namespace ejercicio4Guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            String meses = "";
            int[] ventas = new int[9];
            int max = ventas[0], min = ventas[0], sumatoria = 0, promedio = 0, menores = 0;
            for (int x = 0; x < 9; x++)
            {
                Console.Write($"Las ventas para el {(x + 1)} mes: ");
                ventas[x] = int.Parse(Console.ReadLine());
                sumatoria += ventas[x];
            }
            promedio = sumatoria / 9;
            for (int x = 0; x < 9; x++)
            {
                if (ventas[x] < promedio)
                {
                    meses += ($"{(x + 1)}, ");
                    menores++;
                }
            }
            Console.WriteLine($"\nEl mayor ingreso registrado fué : {ventas.Max()}\n" +
                $"El menor ingreso fue de: {ventas.Min()}\n" +
                $"El promedio de ventas registrado es de: {promedio}\n" +
                $"Hay {menores} meses que se registraron menos que el promedio \n" +
                $"Los meses con menor ingreso en promedio son: {meses}");
            Console.ReadKey();
        }
    }
}

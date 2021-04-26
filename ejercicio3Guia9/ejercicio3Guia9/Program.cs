using System;

namespace ejercicio3Guia9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            var azar = new Random();
            var arreglo = new byte[20];
            byte prueba = 0, valid = 0;
            azar.NextBytes(arreglo);
            Console.WriteLine("Bienvenido a tu ruleta de la surte, ingresa un número y este se encuentra");
            prueba = byte.Parse(Console.ReadLine());
            for (int x = 0; x < 20; x++)
            {
                if (prueba == arreglo[x])
                {
                    Console.WriteLine($"El dato coincide con un número que se encuentra \n" +
                        $"en la posición {(x + 1)} del arreglo");
                    valid = 1;
                }
            }
            if (valid == 0)
            {
                Console.WriteLine("Sigue intentandolo amigo...");
            }
            Console.ReadKey();
        }
    }
}

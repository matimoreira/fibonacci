using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de Fibonacci.");
            int valor1 = 0, valor2 = 1, cantidad, aux;
            Console.Write("Ingresar la cantidad de numero que desea ver de la serie: ");
            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                aux = valor1;
                valor1 = valor2;
                valor2 = aux + valor1;
                if (i < 3)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(valor1);
                }


            }
        }
    }
}

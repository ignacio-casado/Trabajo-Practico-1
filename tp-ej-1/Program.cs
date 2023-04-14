using System;
using System.Globalization;
using System.Xml;

class Program
{
    static void Main()
    {
        //Ejercicio 1
        
        int i = 0;
        int cantidadPares = 0;
        int cantidadPorTres = 0;

        while (i < 125)
        {
            i++;
            if (i % 2 == 0)
            {
                cantidadPares++;
            }

            if (i % 3 == 0)
            {
                cantidadPorTres++;
            }

        }
        Console.WriteLine($"La cantidad de numeros pares es de {cantidadPares} y la cantidad de numeros divisibles por 3 es de {cantidadPorTres}");
    }
}
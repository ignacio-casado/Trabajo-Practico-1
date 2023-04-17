using System;

class Program
{
    static void Main()
    {
        //Ejercicio 5

        Console.WriteLine("Bienvenido al programa para sacar el promedio");
        int notas = 0;

        int contador = 0;

        while (true)
        {
            Console.WriteLine("Ingrese una nota -  presione e para frenar y obtener promedio");
            Console.Write("Ingrese Nota: ");
            string response = Console.ReadLine();



            if (response == "e")
            {
                // Salir del bucle o de la aplicación si se presiona la tecla ESC
                break;

            }
            if (int.TryParse(response, out int nota))
            {
                if (nota < 0)
                {
                    Console.WriteLine("Las notas no pueden ser menores a  0 ");
                    break;
                }
                contador++;
                notas += nota;
            }
            else
            {
                Console.WriteLine("¡Entrada inválida! Por favor, ingrese un número válido.");
            }


        }
        if (notas > 0)
        {
            int resultado = notas / contador;
            Console.WriteLine($"El porcentaje de las notas es de {resultado}");

        }
        else
        {
            Console.WriteLine("No ingreso noas :( ");
        }
    }
}
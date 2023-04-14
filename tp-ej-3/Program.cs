using System;

class Program
{
    static void Main()
    {
        // Ejercicio 3

        Console.WriteLine("Elija un numero entero entre el 1 y el 10 incluido para ser traducido a romano");
        int result = int.Parse(Console.ReadLine());
        //validar que no sea nulo
        if (result == null)
        {
            Console.WriteLine("El input no puede ser null");
        }
        // hardcode de las respuestas
        switch (result)
        {
            case 1:
                Console.WriteLine("Su traduccion a Romano es I");
                break;
            case 2:
                Console.WriteLine("Su traduccion a Romano es II");
                break;
            case 3:
                Console.WriteLine("Su traduccion a Romano es III");
                break;
            case 4:
                Console.WriteLine("Su traduccion a Romano es IV");
                break;
            case 5:
                Console.WriteLine("Su traduccion a Romano es V");
                break;
            case 6:
                Console.WriteLine("Su traduccion a Romano es VI");
                break;
            case 7:
                Console.WriteLine("Su traduccion a Romano es VII");
                break;
            case 8:
                Console.WriteLine("Su traduccion a Romano es VIII");
                break;
            case 9:
                Console.WriteLine("Su traduccion a Romano es X");
                break;
            case 10:
                Console.WriteLine("Su traduccion a Romano es X");
                break;
            default:
                Console.WriteLine("Elija un numero valido");
                break;
        }
    }
}
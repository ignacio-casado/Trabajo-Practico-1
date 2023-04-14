using System;

class Program
{
    static void Main() 
    {
        //Ejercicio 2//

        Console.Write("Ingrese un dia de la semana: ");
        string diaDeSemana = Console.ReadLine();

        switch (diaDeSemana.ToUpper())
        {
            case "LUNES":
                Console.WriteLine("No es fin de semana");
                break;
            case "MARTES":
                Console.WriteLine("No es fin de semana");
                break;
            case "MIERCOLES":
                Console.WriteLine("No es fin de semana");
                break;
            case "JUEVES":
                Console.WriteLine("No es fin de semana");
                break;
            case "VIERNES":
                Console.WriteLine("No es fin de semana");
                break;
            case "SABADO":
                Console.WriteLine("Es fin de semana");
                break;
            case "DOMINGO":
                Console.WriteLine("Es fin de semana");
                break;
            default:
                Console.WriteLine("No selecciono un dia de la semana");
                break;

        }

    }
}
using System;

class Program
{
    static void Main()
    {
        //// Ejercicio 4
        try
        {
            Console.WriteLine("Programa para calcular que tipo de triangulo es");
            Console.WriteLine("Ingrese lado 1 ");
            int ladoUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 2");
            int ladoDos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 3");
            int ladoTres = int.Parse(Console.ReadLine());


            //Si la respuesta es null se corta ya que el tipo int no puede ser null

            if ((ladoUno == ladoDos) && (ladoUno == ladoTres))
            {
                Console.WriteLine("El triangulo es Equilatero");
            }
            if ((ladoUno == ladoDos) && (ladoUno != ladoTres) || (ladoDos == ladoTres) && (ladoDos != ladoUno) || (ladoUno == ladoTres) && (ladoUno != ladoDos))
            {
                Console.WriteLine("El triangulo es Isosceles");
            }
            if (ladoUno != ladoDos && ladoDos != ladoTres && ladoUno != ladoTres)
            {
                Console.WriteLine("Es un triangulo Escaleno");
            }
        }
        catch (Exception ex) { Console.WriteLine("\t El dato debe ser de tipo int " + ex.ToString()); }

    }
}
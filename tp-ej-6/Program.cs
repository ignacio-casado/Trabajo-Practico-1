using System;

class Program
{
    static void Main()
    {
        //ejercicio 6
        Console.WriteLine("Bienvenido al programa para sacar el area de una figura");
        Console.WriteLine("Para sacar el area de un Rectangulo presione 1");
        Console.WriteLine("Para sacar el area de un Triangulo presione 2");
        Console.WriteLine("Para sacar el area de un Cuadrado presione 3");
        Console.WriteLine("Para sacar el area de un Rombo presione 4");
        Console.WriteLine("Para salir preione 5");


        int respuesta = int.Parse(Console.ReadLine());

        switch (respuesta)
        {
            case 1:
                AreaRectangulo();
                break;
            
            case 2:
                AreaTriangulo(); 
                break;
           
            case 3:
                AreaCuadrado();
                break;
            
            case 4:
                AreaRombo();
                break;
            case 5:
                Console.WriteLine();
                break;
          
            default:
                Console.WriteLine();
                break;
        }
       
  
    }
    private static int AreaRectangulo()
    {
        Console.WriteLine("Ingrese un lado del rectangulo (base)");
        int respuestaUno = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el lado perpendicular (altura)");
        int respuestaDos = int.Parse(Console.ReadLine());

        if (respuestaUno == respuestaDos)
        {
            Console.WriteLine("No pueden ser iguales");
        }
        //else if (respuestaUno == null || respuestaDos == null)
        //{
        //    Console.WriteLine("Ambos lados deben ser mayor a 0 y no pueden ser null");
        //}
        else if (respuestaUno == 0 || respuestaDos == 0)
        {
            Console.WriteLine("Ambos lados deben ser mayor a 0 y no pueden ser null");
        }
        else
        {
            int resultadoFinal = respuestaUno * respuestaDos;
            Console.WriteLine(resultadoFinal);
        }
        return 0;
    }
    private static int AreaTriangulo()
    {
        Console.WriteLine("Ingrese un lado de la base del triangulo (base)");
        int respuestaUnoTriangulo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triangulo  (altura)");
        int respuestaDosTriangulo = int.Parse(Console.ReadLine());

        if (respuestaUnoTriangulo == respuestaDosTriangulo)
        {
            Console.WriteLine("No pueden ser iguales");
        }
        //else if (respuestaUnoTriangulo == null || respuestaDosTriangulo == null)
        //{
        //    Console.WriteLine("Ambos lados deben ser mayor a 0 y no pueden ser null");
        //}
        else if (respuestaUnoTriangulo == 0 || respuestaDosTriangulo == 0)
        {
            Console.WriteLine("Ambos lados deben ser mayor a 0 y no pueden ser null");
        }
        else
        {
            int resultado = (respuestaUnoTriangulo * respuestaDosTriangulo) / 2;
            Console.WriteLine($"El tamaño del area es de {resultado}");
        }
        return 0;
    }
    private static int AreaCuadrado()
    {
        Console.WriteLine("Ingrese un lado del cuadrado");
        int respuestaCuadrado = int.Parse(Console.ReadLine());
        if (respuestaCuadrado <= 0)
        {
            Console.WriteLine("El lado no puede ser menor o igual a cero");
        }
        else if (respuestaCuadrado == null)
        {
            Console.WriteLine("El resultado no puede ser null");
        }
        else
        {
            int resultado = respuestaCuadrado * 2;
            Console.WriteLine($"El tamaño del area es de {resultado}");
        }
        return 0;
    }
    private static int AreaRombo()
    {
        Console.WriteLine("Ingrese la diagonal mayor del rombo (D)");
        int respuestaUnoRombo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la diagonal mayor del rombo (d)");
        int respuestaDosRombo = int.Parse(Console.ReadLine());

        if (respuestaUnoRombo == 0 || respuestaDosRombo == 0)
        {
            Console.WriteLine("Sus lados no pueden ser 0");
        }
        else if (respuestaUnoRombo == null || respuestaDosRombo == null)
        {
            Console.WriteLine("No puede tener lados null");
        }
        else if (respuestaUnoRombo < 0 || respuestaDosRombo < 0)
        {
            Console.WriteLine("Sus lados no pueden ser menor a 0");
        }
        else
        {
            int resultado = (respuestaUnoRombo * respuestaDosRombo) / 2;
            Console.WriteLine($"El tamaño del area es de {resultado}");
        }
        return 0;
    }
}



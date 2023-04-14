using System;

class Program
{
    static void Main()
    {
      

        Console.WriteLine("Bienvenidos a la calculadora ");
        Console.WriteLine("Para sumar presione + ");
        Console.WriteLine("Para restar presione - ");
        Console.WriteLine("Para multiplicar presione * ");
        Console.WriteLine("Para dividir presione / ");
        Console.WriteLine("Para sacar la potencia de un numero presione ^ ");

        string response = Console.ReadLine();
        switch (response)
        {
            case "+":
                Console.WriteLine("Seleccione un valor A");
                string res = Console.ReadLine();
                Console.WriteLine("Seleccione un valor B");
                string res2 = Console.ReadLine();
                int result = Suma(res, res2);
                Console.WriteLine($"El resultado de la suma entre {res} y {res2} es {result}");
                break;
            case "-":
                Console.WriteLine("Seleccione un valor A");
                string resResta = Console.ReadLine();
                Console.WriteLine("Seleccione un valor B");
                string resResta2 = Console.ReadLine();
                int resultResta = Resta(resResta, resResta2);
                Console.WriteLine($"El resultado de la resta entre {resResta} y {resResta2} es {resultResta}");
                break;
            case "*":
                Console.WriteLine("Seleccione un valor A");
                string resMulti = Console.ReadLine();
                Console.WriteLine("Seleccione un valor B");
                string resMulti2 = Console.ReadLine();
                int resultMulti = Multiplicacion(resMulti, resMulti2);
                Console.WriteLine($"El resultado de la multiplicacion entre {resMulti} y {resMulti2} es {resultMulti}");
                break;
            case "/":
                Console.WriteLine("Seleccione un valor A");
                string resDiv = Console.ReadLine();
                Console.WriteLine("Seleccione un valor B");
                string resDiv2 = Console.ReadLine();
                int resultDiv = Division(resDiv, resDiv2);
                Console.WriteLine($"El resultado de la division entre {resDiv} y {resDiv2} es {resultDiv}");
                break;
            case "^":
                Console.WriteLine("Seleccione un valor A (base)");
                string resPot = Console.ReadLine();
                Console.WriteLine("Seleccione un valor B (exponente)");
                string resPot2 = Console.ReadLine();
                double resultPot = Potencia(resPot, resPot2);
                Console.WriteLine($"El resultado de la potencia entre {resPot} y {resPot2} es {resultPot}");
                break;

            default: 
                Console.WriteLine();
                break;
        }
    



    }
    private static int Suma(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            return value1 + value2;
        }
        else
        {
            return 0;
        }
    }

    private static int Resta(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            return value1 - value2;
        }
        else
        {
            return 0;
        }
    }
    private static int Multiplicacion(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            return value1 * value2;
        }
        else
        {
            return 0;
        }
    }
    private static int Division(string a, string b)
    {
        int value1 = 0;
        int value2 = 0;

        bool IsNumber = int.TryParse(a, out value1);
        bool IsNumber2 = int.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            if (value2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            return value1 / value2;
        }
        else
        {
            return 0;
        }
    }
    private static double Potencia(string a, string b)
    {
        double value1 = 0;
        double value2 = 0;

        bool IsNumber = double.TryParse(a, out value1);
        bool IsNumber2 = double.TryParse(b, out value2);

        if (IsNumber == false)
        {
            Console.WriteLine("El valor A no es un numero");
        }
        if (IsNumber2 == false)
        {
            Console.WriteLine("El valor B no es un numero");
        }
        if (IsNumber == true && IsNumber2 == true)
        {
            
            return Math.Pow(value1, value2);
        }
        else
        {
            return 0;
        }
    }
}

using System;

class Calculadora
{
    public void Menu()
    {
        Console.WriteLine("=== Calculadora ===");
        Console.WriteLine("1. SUMAR");
        Console.WriteLine("2. RESTAR");
        Console.WriteLine("3. MULTIPLICAR");
        Console.WriteLine("4. DIVIDIR");
        Console.WriteLine("5. POTENCIA");
        Console.WriteLine("6. SALIR");
        Console.WriteLine("====================");
    }

    public void Sumar()
    {
        Console.WriteLine("Ingrese la cantidad de números a sumar:");
        int cantidad = LeerEntero();
        double resultado = 0;

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            resultado += LeerDouble();
        }

        Console.WriteLine("El resultado de la suma es: " + resultado);
    }

    public void Restar()
    {
        Console.WriteLine("Ingrese la cantidad de números:");
        int cantidad = LeerEntero();
        Console.Write("Ingrese el número 1: ");
        double resultado = LeerDouble();

        for (int i = 1; i < cantidad; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            resultado -= LeerDouble();
        }

        Console.WriteLine("El resultado de la resta es: " + resultado);
    }

    public void Multiplicar()
    {
        Console.WriteLine("Ingrese la cantidad de números a multiplicar:");
        int cantidad = LeerEntero();
        double resultado = 1;

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            resultado *= LeerDouble();
        }

        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
    }

    public void Dividir()
    {
        double divisor;
        do
        {
            Console.Write("Ingrese el divisor (no puede ser cero): ");
            divisor = LeerDouble();
            if (divisor == 0)
                Console.WriteLine("¡Error! El divisor no puede ser cero.");
        } while (divisor == 0);

        Console.Write("Ingrese el dividendo: ");
        double dividendo = LeerDouble();

        double resultado = dividendo / divisor;

        Console.WriteLine("El resultado de la división es: " + resultado);
    }

    public void Potencia()
    {
        Console.Write("Ingrese la base: ");
        double baseNum = LeerDouble();
        Console.Write("Ingrese el exponente: ");
        double exponente = LeerDouble();

        double resultado = Math.Pow(baseNum, exponente);

        Console.WriteLine("El resultado de la potencia es: " + resultado);
    }

    // Método para leer un entero de la consola de forma segura
    private static int LeerEntero()
    {
        int numero = 0;
        bool entradaValida = false;
        do
        {
            Console.Write("Ingrese un número entero: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out numero))
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
            }
        } while (!entradaValida);

        return numero;
    }

    // Método para leer un double de la consola de forma segura
    private static double LeerDouble()
    {
        double numero = 0;
        bool entradaValida = false;
        do
        {
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && double.TryParse(input, out numero))
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
        } while (!entradaValida);

        return numero;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        int opcion;

        while (true)
        {
            calc.Menu();
            Console.Write("Seleccione una opción: ");
            opcion = LeerEntero();

            switch (opcion)
            {
                case 1:
                    calc.Sumar();
                    break;
                case 2:
                    calc.Restar();
                    break;
                case 3:
                    calc.Multiplicar();
                    break;
                case 4:
                    calc.Dividir();
                    break;
                case 5:
                    calc.Potencia();
                    break;
                case 6:
                    Console.WriteLine("Saliendo...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
            Console.WriteLine();
        }
    }

    // Método estático para leer un entero de la consola de forma segura
    private static int LeerEntero()
    {
        int numero = 0;
        bool entradaValida = false;
        do
        {
            Console.Write("Ingrese un número entero: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out numero))
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
            }
        } while (!entradaValida);

        return numero;
    }
}

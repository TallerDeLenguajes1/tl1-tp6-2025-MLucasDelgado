// See https://aka.ms/new-console-template for more information

//Ejercicio 2 - Calculadora

bool seguirCalculando = true;

while (seguirCalculando)
{
    string opcionElegida = ElegirOpciones();

    switch (opcionElegida)
    {
        case "1":
            operacionesBasicas();
            break;
        case "2":
            FuncionesUnNumero();
            break;
        case "3":
            CompararNumeros();
            break;
        case "4":
            seguirCalculando = false;
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }

    if (opcionElegida != "4")
    {
        Console.Write("\n¿Desea realizar otra operación? (s/n): ");
        string respuesta = Console.ReadLine().ToLower();
        if (respuesta == "s")
        {
            seguirCalculando = true;
        }
        else
        {
            seguirCalculando = false;
        }
    }
}

string ElegirOpciones()
{
    Console.WriteLine("----- CALCULADORA V2 -----");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1 - Operaciones básicas (sumar, restar, multiplicar, dividir)");
    Console.WriteLine("2 - Funciones sobre un número");
    Console.WriteLine("3 - Comparar dos números (máximo y mínimo)");
    Console.WriteLine("4 - Salir");
    Console.Write("Opción: ");
    string opcion = Console.ReadLine();

    return opcion;
}

void operacionesBasicas()
{
    Console.WriteLine("\n--- Operaciones Básicas ---");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.Write("Opción: ");
    string operacion = Console.ReadLine();

    Console.Write("Ingrese el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    Console.Write("Ingrese el segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    double resultado = 0;
    bool valido = true;

    switch (operacion)
    {
        case "1":
            resultado = num1 + num2;
            break;
        case "2":
            resultado = num1 - num2;
            break;
        case "3":
            resultado = num1 * num2;
            break;
        case "4":
            if (num2 != 0)
                resultado = num1 / num2;
            else
            {
                Console.WriteLine("No se puede dividir por 0.");
                valido = false;
            }
            break;
        default:
            Console.WriteLine("Opción inválida.");
            valido = false;
            break;
    }

    if (valido) Console.WriteLine($"Resultado: {resultado}");
}

void FuncionesUnNumero()
{
    Console.WriteLine("Ingrese un numero: ");
    if (!double.TryParse(Console.ReadLine(), out double num))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    Console.WriteLine($"Valor Absoluto: {Math.Abs(num)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(num, 2)}");
    Console.WriteLine($"Raíz Cuadrada: {Math.Sqrt(num)}");
    Console.WriteLine($"Seno: {Math.Sin(num)}");
    Console.WriteLine($"Coseno: {Math.Cos(num)}");
    Console.WriteLine($"Parte entera: {Math.Truncate(num)}");
}

void CompararNumeros()
{
    Console.WriteLine("Ingrese el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    Console.WriteLine("Ingrese el segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    Console.WriteLine($"Máximo: {Math.Max(num1, num2)}");
    Console.WriteLine($"Mínimo: {Math.Min(num1, num2)}");
}




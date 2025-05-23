// See https://aka.ms/new-console-template for more information

//Ejercicio 2 - Calculadora

bool seguirCalculando = true;

while (seguirCalculando)
{
    string opcion = ElegirOpciones();

    // Validar opción antes de pedir números
    if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
    {
        Console.Write("Ingrese el primer número: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Número inválido.");
            continue; // vuelve al inicio del while
        }

        Console.Write("Ingrese el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Número inválido.");
            continue;
        }

        double resultado = 0;
        bool operacionValida = true;

        switch (opcion)
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
                    operacionValida = false;
                }
                break;
        }

        if (operacionValida)
        {
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
    else
    {
        Console.WriteLine("Opción inválida.");
    }

    Console.Write("¿Desea realizar otro cálculo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    seguirCalculando = (respuesta == "s");
}

string ElegirOpciones()
{
    Console.WriteLine("-----CALCULADORA-----");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.Write("Opción: ");
    return Console.ReadLine();
}




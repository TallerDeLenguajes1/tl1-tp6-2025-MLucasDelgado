// See https://aka.ms/new-console-template for more information

//Ejercicio 2 y 3 - Calculadora

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
            ResolverEcuacionSimple();
            break;
        case "5":
            seguirCalculando = false;
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }

    if (opcionElegida != "5")
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
    Console.WriteLine("------ CALCULADORA V2 ------");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1 - Operaciones básicas (sumar, restar, multiplicar, dividir)");
    Console.WriteLine("2 - Funciones sobre un número");
    Console.WriteLine("3 - Comparar dos números (máximo y mínimo)");
    Console.WriteLine("4 - Resolver ecuación simple (ej: 582+2)");
    Console.WriteLine("5 - Salir");
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

    string textoOperacion = "";
    switch (operacion)
    {
        case "1":
            resultado = num1 + num2;
            textoOperacion = $"La suma de {num1} y {num2} es igual a: {resultado}";
            break;
        case "2":
            resultado = num1 - num2;
            textoOperacion = $"La resta de {num1} y {num2} es igual a: {resultado}";
            break;
        case "3":
            resultado = num1 * num2;
            textoOperacion = $"El producto de {num1} y {num2} es igual a: {resultado}";
            break;
        case "4":
            if (num2 != 0)
            {
                resultado = num1 / num2;
                textoOperacion = $"La división de {num1} y {num2} es igual a: {resultado}";
            }
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

    if (valido) Console.WriteLine(textoOperacion);
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

void ResolverEcuacionSimple()
{
    Console.WriteLine("Ingrese una ecuación simple (ej: 582+2): ");
    string ecuacion = Console.ReadLine().Replace(" ", ""); // elimina espacios

    char[] operadores = { '+', '-', '*', '/' };
    char operador = ' ';

    foreach (char caracter in operadores) // caracter= (+ ó - ó * ó /)
    {
        if (ecuacion.Contains(caracter))
        {
            operador = caracter;
            break; // el bucle termine cuando encuentra el primer operador válido
        }
    }

    if (operador == ' ')
    {
        Console.WriteLine("Ecuación Inválida. No se encontró un operador válido");
        return; // salimos de la funcion si no encontramos un operador valido
    }

    string[] partes = ecuacion.Split(operador);

    if (partes.Length != 2 || !double.TryParse(partes[0], out double num1) || !double.TryParse(partes[1], out double num2))
    {
        Console.WriteLine("Ecuación mal formada o números inválidos");
        return;
    }

    double resultado = 0;
    bool valido = true;

    switch (operador)
    {
        case '+':
            resultado = num1 + num2;
            break;
        case '-':
            resultado = num1 - num2;
            break;
        case '*':
            resultado = num1 * num2;
            break;
        case '/':
            if (num2 != 0)
                resultado = num1 / num2;
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
                valido = false;
            }
            break;
    }

    if (valido)
    {
        Console.WriteLine($"El resultado de {num1} {operador} {num2} es: {resultado}");
    }
}

//Ejercicio 4 - Frases

Console.WriteLine("Ingrese una frase: "); // esto me devuelve un void
string fraseLeida = Console.ReadLine();
int longitudFrase = fraseLeida.Length;
Console.WriteLine($"Longitud de la palabra: {longitudFrase}");

Console.WriteLine("Ingrese otra frase: ");
string segundaFrase = Console.ReadLine();
string frasesConcatenadas = fraseLeida + " " + segundaFrase;
Console.WriteLine($"Frases concatenadas: {frasesConcatenadas}");

if (longitudFrase >= 5)
{
    string subcadena = fraseLeida.Substring(0, 5); // Esto toma los primeros 5 caracteres, empezando desde el índice 0:
    Console.WriteLine($"Subcadena extraída: {subcadena}");
}
else
{
    Console.WriteLine("La frase es demasiado corta para extraer una subcadena de 5 caracteres.");
}

foreach (char letra in fraseLeida)
{
    Console.WriteLine(letra.ToString());
}

Console.WriteLine("\nIngrese una palabra a buscar: ");
string palabraBuscada = Console.ReadLine();

if (fraseLeida.ToLower().Contains(palabraBuscada.ToLower()))
{
    Console.WriteLine($"La palabra '{palabraBuscada}' se encontró en la frase.");
}
else
{
    Console.WriteLine($"La palabra '{palabraBuscada}' NO se encontró en la frase.");
}

string fraseEnMayuscula = fraseLeida.ToUpper();
Console.WriteLine($"{fraseEnMayuscula}");
string fraseEnMinuscula = fraseLeida.ToLower();
Console.WriteLine($"{fraseEnMinuscula}");

string[] partes = fraseLeida.Split(" ");

Console.WriteLine("\nPartes separadas:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}
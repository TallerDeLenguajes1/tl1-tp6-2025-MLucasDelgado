[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

## Ejercicio 4 - Preguntas

**¿String es un tipo por valor o un tipo por referencia?**  
`string` en C# es un tipo **por referencia**, pero se comporta como inmutable (como si fuera por valor) porque no puede ser modificado una vez creado.

**¿Qué secuencias de escape tiene el tipo string?**  
Algunas secuencias comunes:

- `\n` nueva línea
- `\t` tabulación
- `\\` barra invertida
- `\"` comillas dobles
- `\r` retorno de carro

**¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?**

- `@` (verbatim string): Interpreta literalmente la cadena, ignorando secuencias de escape. Ideal para rutas de archivos o texto con muchas barras.

  - Ejemplo: `@"C:\Usuarios\Juan\Documentos"`

- `$` (interpolación de cadenas): Permite insertar variables o expresiones dentro de una cadena.

  - Ejemplo:
    ```csharp
    string nombre = "Juan";
    Console.WriteLine($"Hola {nombre}"); // Muestra: Hola Juan
    ```

- También se pueden combinar: `$@"Ruta:\Usuarios\{nombre}"`

  - Esto permite interpolar **y** tratar el string como verbatim al mismo tiempo.

  # Expresiones Regulares en C#

## ¿Qué son?

Las expresiones regulares (o _Regular Expressions_, abreviadas como _Regex_) son secuencias de caracteres especiales que se utilizan para definir patrones de búsqueda y coincidencia dentro de cadenas de texto. Son una herramienta poderosa para validar, extraer, o reemplazar partes de un texto que cumplan con cierto formato.

## ¿Funcionan únicamente en C#?

No. Las expresiones regulares son una herramienta ampliamente utilizada en muchos lenguajes de programación y tecnologías, como:

- Java
- Python
- JavaScript
- PHP
- Ruby
- Bash
- Incluso en editores de texto avanzados como VS Code o Notepad++

En cada lenguaje puede haber ligeras diferencias en la implementación, pero la sintaxis general es compartida.

## ¿En qué casos son útiles? (3 ejemplos)

1. **Validación de entradas**: Verificar si una cadena es un correo electrónico válido, número de teléfono, código postal, etc.
2. **Búsqueda y reemplazo**: Buscar patrones dentro de un texto y reemplazarlos, como cambiar fechas de formato o censurar palabras ofensivas.
3. **Extracción de datos**: Obtener datos específicos desde textos estructurados o semiestructurados (por ejemplo, encontrar todas las direcciones de correo en un documento).

## ¿Cómo se usan en C#?

En C#, las expresiones regulares se implementan mediante la clase `Regex` del espacio de nombres `System.Text.RegularExpressions`.

### Ejemplo básico de uso:

```csharp
using System;
using System.Text.RegularExpressions;

class Programa
{
    static void Main()
    {
        string texto = "Mi número es 123-456-7890";
        string patron = @"\d{3}-\d{3}-\d{4}";

        if (Regex.IsMatch(texto, patron))
        {
            Console.WriteLine("Se encontró un número de teléfono.");
        }
    }
}

---
```

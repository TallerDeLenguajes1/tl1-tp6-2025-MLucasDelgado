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

---
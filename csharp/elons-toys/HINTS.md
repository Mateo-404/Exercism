# Consejos

## General

## 1. Comprar un coche teledirigido nuevo

- [Esta página muestra cómo crear una nueva instancia de una clase][creating-objects].

## 2. Visualizar la distancia recorrida

- Registra la distancia recorrida en un [campo][campos].
- Considere qué visibilidad utilizar para el campo (¿necesita ser utilizado fuera de la clase?).
- Considera el uso de [interpolación de cadena][interpolación de cadena] para formatear la cadena a devolver.

## 3. Mostrar el porcentaje de batería

- Lleva la cuenta de la distancia recorrida en un [campo][campos].
- Inicializa el campo a un valor específico que corresponda a la carga inicial de la batería.
- Considera qué visibilidad usar para el campo (¿necesita ser usado fuera de la clase?).
- Considera el uso de [string interpolation][string-interpolation] para formatear la cadena a devolver.

## 4. Actualizar el número de metros recorridos al conducir

- Actualizar el campo que representa la distancia recorrida.

## 5. Actualizar el porcentaje de batería al conducir

- Actualizar el campo que representa el porcentaje de batería conducido.

## 6. Impedir la conducción cuando la batería está agotada

- Añade una condicional para actualizar la distancia y la batería sólo si la batería no se ha agotado.
- Añade un condicional para mostrar el mensaje de batería vacía si la batería está agotada.

[crear-objetos]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes#creating-objects
[campos]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields
[cadena-i

Traducción realizada con la versión gratuita del traductor DeepL.com
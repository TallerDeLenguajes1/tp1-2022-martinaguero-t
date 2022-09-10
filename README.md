# Taller de Lenguajes II - Trabajo Práctico N°1

Agüero Trevisan Martin Gabriel

---

## Respuestas a ejercicios 
---
### Ejercicio 4

a) **Cuando se captura una excepción, existen muchas formas de lanzar la excepción al
método llamador. Algunas de estas se encuentran en el código a continuación. Investigue
en qué se diferencian cada una de ellas. Responda en el README.md.**

```C#
catch(Exception ex)
{
    throw;
    throw new AlgunaExcepcion("mensaje de error 1", ex);
    throw new AlgunaExcepcion("mensaje de error 2");
    throw ex;
}
```

_throw_  es una palabra reservada del lenguaje que se utiliza para lanzar excepciones. La principal diferencia entre _throw;_ y _throw ex;_ es que, si bien ambas sentencias lanzan la misma excepcion _ex_, la segunda reinicia el _StackTrace_ que se describe más abajo (**en general** la primera no lo hace). Es por eso que resulta más conveniente para cuando un método debe lanzar una excepción a otro que a su vez debe lanzar dicha excepción al método original (_re-throwing_). Por otro lado, _throw new AlgunaExcepcion("mensaje de error 2");_ y _throw new AlgunaExcepcion("mensaje de error 1", ex);_  ambas crean una nueva instancia de la clase _Exception_. En el primer caso, se usa el constructor que recibe como parámetro una cadena de caracteres que es el mensaje de descripción del error. En el segundo caso, al constructor se pasa adicionalmente la referencia a la excepción interna, que es la que causa la nueva excepción instanciada.

Fuentes: [Difference between \'throw\' and \'throw new Exception()\'
](https://stackoverflow.com/questions/2999298/difference-between-throw-and-throw-new-exception), [Is there a difference between "throw" and "throw ex"?](https://stackoverflow.com/questions/730250/is-there-a-difference-between-throw-and-throw-ex) (StackOverFlow), [throw (C# Reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw) y [Exception Constructors](https://docs.microsoft.com/en-us/dotnet/api/system.exception.-ctor?view=net-6.0) (Documentación .NET).

b) **Investigue el objeto _StackTrace_ de _System.Diagnostics_.**

De acuerdo con el artículo [StackTrace Class](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stacktrace?view=net-6.0), un objeto _StackTrace_ es una colección **ordenada** de uno o más _Stack Frames_. Un _Stack Frame_ es un elemento de la **pila de llamadas**, que se puede definir como una _abstracción del estado actual de un método en ejecución_ (extraído de <https://www.oreilly.com/library/view/c-in-a/0596001819/re255.html>). El _Stack Trace_  (podría llamarse _"rastro de la pila (de llamadas)"_) sería una representación de un determinado estado de los _Stack Frames_ de la pila de llamadas en un determinado momento de la ejecución del programa. 

En este sentido, resulta muy útil para detectar problemas y excepciones durante la ejecución del programa, lo cual es importante en el proceso de _debugging_.

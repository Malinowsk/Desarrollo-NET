# Objetos en c#

Los objetos en c# se manejan de la misma forma que se manejan en c++, con la ventaja de que el manejo de punteros al heal o a el stack de memoria, se hacen de forma automatica (eso lo arregla c# por detras).
### Tipos de datos para estructuras

**Struct**: Tipo por valor, debe ser menor a 16 kb, mas usado para representar un tipo primitivo, es un valor guardado en stack de memoria.
- Su instancia es pequeña
- Es inmutable
- Boxed

~~~ c#
public struct Coords{
    public Coords(double x, double y){
        X = x;
        Y = y;
    }
    public double X { get; }
    public double Y { get; }
    public override string ToString() => $"({X}, {Y})";
}
~~~
- Para que la struct sea por **referencia** se utiliza la palabra reservada `ref`
~~~ c#
public ref struct CustomRef{
    public bool IsValid;
    public Span<int> Inputs;
    public Span<int> Outputs;
}
~~~

**Record**: Tipo por referencia, es como una clase, pero es inmutable.
- Inmutable

**Class**: Tipo por referencia, al igual que el record, se almacenan en el heap y sus instancias son punteros de referencia a la posicion en Heap donde estan almaceados.


## Exepciones
~~~ c#
static void Main(string[], args){
    int numero;
    try{
        numero = int.Parse(Console.ReadLine());
    }
    catch(FormatException e){ // Captura un error por tipo de dato no valido
        Console.WriteLine("No ingresaste un numero");
    }
    catch(OverFlowException e){ // Captura un error en caso de sobrepasar los limites del tipo de dato
        Console.WriteLine("Ingresaste un numero demaciado alto");
    }
    catch(Exception e){ // Captura cualquier tipo de exepcion generica
        Console.WriteLine("No intentes romper el programa");
    }
}
~~~

# COMANDO
dotnet dev-certs https --trust
dotnet new mvc -o Proyecto
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
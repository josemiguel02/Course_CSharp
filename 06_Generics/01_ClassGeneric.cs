namespace Course_CSharp._06_Generics;

/*
 * Genéricos en C#
 * Los genéricos introducen el concepto de parámetros de tipo a .NET, lo que le permite diseñar clases y métodos
 * que aplazan la especificación de uno o varios tipos hasta que el código de cliente declare y cree una
 * instancia de la clase o el método.
 *
*/

// Clase Genérica
// Para convertir una clase en generica debemos usar la siguiente sintaxis:
// public class NombreClase<T> {}
public class ArregloGenerico<T>
{
    private T[] _arreglo;

    public ArregloGenerico(short longitud)
    {
        _arreglo = new T[longitud];
    }

    public void Agregar(int indice, T item)
    {
        _arreglo[indice] = item;
    }

    public override string ToString()
    {
        return string.Join(" - ", _arreglo);
    }
}
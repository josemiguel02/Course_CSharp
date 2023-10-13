using System;

namespace Course_CSharp._05_POO;

/*
 * Declarando una clase en C#
 * Para crear una clase en C#, se utiliza la palabra clave class, seguida del nombre de
 * la clase y un bloque de código entre llaves. Dentro de este bloque de código,
 * se pueden definir las propiedades y métodos de la clase.
*/
public class Persona
{
    // Propiedades o Atributos
    public string Nombre;
    public int Edad;


    /*
     * Constructor
     * En C#, el nombre del constructor es el mismo que el nombre de la clase.
     * Los constructores no tienen un tipo de valor de retorno y pueden tener parámetros.
    */
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }


    // Método
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años!");
    }
}
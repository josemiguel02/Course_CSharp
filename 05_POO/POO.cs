using System;

namespace Course_CSharp._05_POO;

public class POO
{
    public POO()
    {
        // Creando una instancia de la clase Persona
        Persona persona1 = new Persona("Jhon Doe", 42);
        Persona persona2 = new Persona("Mac Miller", 26);

        // Llamando al método Saludar()
        persona1.Saludar();
        persona2.Saludar();


        Console.WriteLine("************** HERENCIA *******************");


        Carro carro1 = new Carro("Tesla", "X", "rojo");
        Carro carro2 = new Carro("Audi", "Q3", "blanco");

        // Lamando al método heredado de la clase Padre
        carro1.Acelerar();

        // Método sobreescrito
        carro1.ObtenerDatos();

        carro2.Girar("derecha");

        Moto moto1 = new Moto("Ducati", "Monster", 1500);
        Moto moto2 = new Moto("Suzuki", "A1", 1000);

        moto1.Acelerar();

        moto2.ObtenerDatos();
        moto2.HacerAcrobacia();


        Console.WriteLine("************** Encapsulamiento *******************");


        Animal loro = new Animal()
        {
            Nombre = "Otto",
            Especie = "loro"
        };

        loro.ObtenerInfo();

        Perro perro = new Perro() { Nombre = "Teddy" };

        perro.ObtenerInfo();
        perro.Ladrar();
    }
}
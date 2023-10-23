using System;
using System.Threading;
using System.Threading.Tasks;

namespace Course_CSharp._07_Asynchronism;

/*
 * Task
 * La clase Task representa una operación asincrónica.
*/
public class TaskClass
{
    // Creación de instancias de la clase Task
    public static async Task CrearTarea()
    {
        var miTarea = new Task(() =>
        {
            Thread.Sleep(2000); // Simulando un Delay

            Console.WriteLine("Tarea interna de Task");
        });

        miTarea.Start();

        await miTarea;

        Console.WriteLine("Ha terminado la tarea!");
        Console.ReadKey();
    }
}
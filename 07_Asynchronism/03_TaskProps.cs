using System;
using System.Threading.Tasks;

namespace Course_CSharp._07_Asynchronism;

public class TaskProps
{
    public static async Task ObtenerPropiedades()
    {
        /*
         * Task.IsCompleted
         * Obtiene un valor que indica si la tarea se ha completado.
        */
        var miTarea = Task.Run(() => "Mi Task");

        await miTarea;

        Console.WriteLine($"La tarea está completa? {miTarea.IsCompleted}");


        /*
         * Task.IsCompletedSuccessfully
         * Obtiene si la tarea se ejecutó hasta completarse.
        */
        var miTarea2 = new Task(() => Console.WriteLine("Mi Tarea 2"));

        Console.WriteLine($"La tarea se ejecutó hasta completarse? {miTarea2.IsCompleted}");


        /*
         * Task.IsCanceled
         * Obtiene un valor que indica si esta instancia de Task ha completado su ejecución
         * debido a una cancelación.
        */
        Console.WriteLine($"La tarea ha sido cancelada? {miTarea.IsCanceled}");


        /*
         * Task.IsFaulted
         * Obtiene un valor que indica si el objeto Task se ha completado debido a una
         * excepción no controlada.
        */
        Console.WriteLine($"La tarea ha sido completada debido a una excepción? {miTarea2.IsFaulted}");
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace Course_CSharp._02_DataStructures;

public class Queues
{
    public Queues()
    {
        /*
         * Queue
         * Representa una colección de objetos de tipo primero en entrar,
         * primero en salir (FIFO).
        */

        // Declarando un Queue
        Queue miQueue = new Queue();

        // Encolando elementos al Queue
        miQueue.Enqueue(1);
        miQueue.Enqueue(2);
        miQueue.Enqueue(3);

        // Quitando y devolviendo el objeto al comienzo del Queue.
        Console.WriteLine(miQueue.Dequeue());

        Console.WriteLine(miQueue);


        /*
         * Queue<T>
         * Representa una colección de objetos del tipo especificado primero en entrar,
         * primero en salir (FIFO).
        */
        Queue<string> queueConTipo = new Queue<string>();

        queueConTipo.Enqueue("Elemento 1");
        queueConTipo.Enqueue("Elemento 2");
        queueConTipo.Enqueue("Elemento 3");

        Console.WriteLine(queueConTipo.Dequeue());

        Console.WriteLine(queueConTipo);
    }
}
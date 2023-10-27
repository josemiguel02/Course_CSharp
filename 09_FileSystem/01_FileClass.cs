using System;
using System.IO;

namespace Course_CSharp._09_FileSystem;

/*
 * File
 * Proporciona métodos estáticos para crear, copiar, eliminar, mover y abrir un solo archivo, y contribuye
 * a la creación de objetos FileStream.
 */
public class FileClass
{
    public FileClass()
    {
        string rutaArchivo = "my_archivo.txt";


        /*
         * Exists (string? path)
         * Determina si existe el archivo especificado.
        */
        if (!File.Exists(rutaArchivo))
        {
            Console.WriteLine("No existe el archivo.");
        }
    }
}
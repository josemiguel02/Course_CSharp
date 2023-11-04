using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

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
        var rutaBase = Path.GetFullPath(
            Path.Combine(Environment.CurrentDirectory, "..", "..", "../", "files")
        );

        string rutaArchivo = Path.Join(rutaBase, "mi_archivo.txt");


        /*
         * Exists (string? path)
         * Determina si existe el archivo especificado.
        */
        if (!File.Exists(rutaArchivo))
        {
            Console.WriteLine("No existe el archivo.");
        }


        /*
         * Create (string path)
         * Crea o sobrescribe un archivo de la ruta de acceso especificada, indicando un tamaño de búfer y opciones
         * que describen cómo crear o sobrescribir el archivo.
        */
        using (FileStream fileStream = File.Create(rutaArchivo))
        {
            var datos = new UTF8Encoding(true).GetBytes("Contenido del archivo");

            fileStream.Write(datos, 0, datos.Length);
        }


        /*
         * CreateText (string path)
         * Crea o abre un archivo para escribir texto con codificación UTF-8. Si el archivo ya existe,
         * se sobrescribe su contenido.
        */
        var rutaArchivo2 = Path.Join(rutaBase, "mi_texto.txt");

        if (!File.Exists(rutaArchivo2))
        {
            using (StreamWriter writer = File.CreateText(rutaArchivo2))
            {
                writer.WriteLine("Hola");
                writer.WriteLine("Desde Archivo #2");
                writer.WriteLine("!!");
            }
        }


        /*
         * OpenText (string path)
         * Abre un archivo de texto existente con codificación UTF-8 para lectura.
         *
        */
        using (StreamReader reader = File.OpenText(rutaArchivo2))
        {
            string? s;

            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }


        /*
         * ReadLines(string path)
         * Lee las líneas de un archivo.
        */
        var lineas = File.ReadLines(rutaArchivo);

        foreach (string linea in lineas)
        {
            Console.WriteLine(linea);
        }


        /*
         * AppendText (string path)
         * Crea un StreamWriter que anexa texto codificado UTF-8 a un archivo existente o a un nuevo archivo si
         * el archivo especificado no existe.
        */
        if (File.Exists(rutaArchivo))
        {
            using (StreamWriter writer = File.AppendText(rutaArchivo))
            {
                writer.WriteLine("\nTexto #1 agregado");
                writer.WriteLine("Texto #2 agregado");
            }
        }


        /*
         * WriteAllText (string path, string? contents)
         * Crea un archivo nuevo, escribe la cadena especificada en él y, a continuación, lo cierra.
         * Si el archivo de destino ya existe, se sobrescribe.
        */
        var rutaArchivo3 = Path.Join(rutaBase, "usuarios.json");

        var usuarios = new List<object>()
        {
            new { username = "JhonDoe", email = "jhon@mail.com" },
            new { username = "JoseDP", email = "jose@gmail.com" }
        };

        var usuariosJson = JsonSerializer.Serialize(usuarios);

        if (!File.Exists(rutaArchivo3))
        {
            File.WriteAllText(rutaArchivo3, usuariosJson);
        }


        /*
         * ReadAllText (string path)
         * Abre un archivo de texto, lee todo el texto del archivo y, a continuación, cierra el archivo.
        */
        var textoArchivo = File.ReadAllText(rutaArchivo3);
        Console.WriteLine(textoArchivo);


        /*
         * Delete (string path)
         * Elimina el archivo especificado.
        */
        var rutaArchivo4 = Path.Join(rutaBase, "archivo_tmp.txt");

        if (File.Exists(rutaArchivo4))
        {
            File.Delete(rutaArchivo4);
        }
    }
}
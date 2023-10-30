using System;
using System.IO;

namespace Course_CSharp._09_FileSystem;

/*
 * Path
 * Ejecuta operaciones en instancias de String que contienen información de rutas de acceso de archivos o directorios.
 * Estas operaciones se ejecutan de forma adecuada para múltiples plataformas.
 */
public class PathClass
{
    public PathClass()
    {
        /*
         * DirectorySeparatorChar
         * Proporciona un carácter específico de la plataforma, que se utiliza para separar niveles de directorios en
         * una cadena de ruta de acceso que refleja una organización jerárquica del sistema de archivos.
        */
        Console.WriteLine(Path.DirectorySeparatorChar);


        /*
         * Combine (params string[] paths)
         * Combina cadenas en una ruta de acceso.
        */
        var ruta1 = @"C:\Users\JOSE MIGUEL\";
        var ruta2 = @"archivos\media\images\mi_imagen.png";

        var rutaCombinada = Path.Combine(ruta1, ruta2);

        Console.WriteLine(rutaCombinada);


        /*
         * GetDirectoryName (string? path)
         * Devuelve la información de directorio para la ruta de acceso especificada.
         */
        Console.WriteLine(Path.GetDirectoryName(rutaCombinada));


        /*
         * GetExtension(string? path)
         * Devuelve la extensión (incluido el punto ".") de la cadena de ruta de acceso especificada.
        */
        Console.WriteLine(Path.GetExtension(rutaCombinada));


        /*
         * GetFileName (string? path)
         * Devuelve el nombre de archivo y la extensión de la cadena de ruta de acceso especificada.
        */
        Console.WriteLine(Path.GetFileName(rutaCombinada));


        /*
         * GetPathRoot (string? path)
         * Obtiene la información del directorio raíz de la ruta de acceso contenida en la cadena especificada.
        */
        Console.WriteLine(Path.GetPathRoot(rutaCombinada));
    }
}
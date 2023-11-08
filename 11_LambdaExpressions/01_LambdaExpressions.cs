using System;

namespace Course_CSharp._11_LambdaExpressions;

/*
 * Expresiones Lambda y Funciones Anónimas
 * Use una expresión lambda para crear una función anónima. Use el operador de declaración lambda (=>)
 * para separar la lista de parámetros de la lamba de su cuerpo.
 * - Una lambda de expresión que tiene una expresión como cuerpo:
 *      (input-parameters) => expression
 * - Una lambda de instrucción que tiene un bloque de instrucciones como cuerpo:
 *      (input-parameters) => { <sequence-of-statements> }
*/
public class LambdaExpressions
{
    public LambdaExpressions()
    {
        /* Action vs. Func
         * Una expresión lambda que tiene dos parámetros y no devuelve ningún valor corresponde a un delegado
         * Action<T1,T2>. Una expresión lambda que tiene un parámetro y devuelve un valor se puede convertir en
         * un delegado Func<T,TResult>.
        */

        // Lambdas de expresión
        Func<int, int> cuadrado = x => x * x;
        Func<int, double> elevarAlCubo = x => Math.Pow(x, 3);

        // Dos o más parámetros de entrada se separan mediante comas:
        Func<int, int, int> sumar = (num1, num2) => num1 + num2;
        Func<int, int, bool> comparar = (num1, num2) => num1 == num2;

        Console.WriteLine(cuadrado(2));
        Console.WriteLine(elevarAlCubo(4));

        Console.WriteLine(sumar(3, 7));
        Console.WriteLine(comparar(12, 6));


        // Lambdas de instrucción
        Action<string> saludar = nombre =>
        {
            var saludo = $"Hola, {nombre}!";
            Console.WriteLine(saludo);
        };

        Action realizarAccion = () =>
        {
            Console.WriteLine("Realizando una acción...");
        };

        saludar("Kurt Cobain");
        realizarAccion();
    }
}
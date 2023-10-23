# Programación Asincrónica en C#

Si tiene cualquier necesidad enlazada a E/S (por ejemplo, solicitar datos de una red, acceder a una base de datos o leer
y escribir un sistema de archivos), deberá usar la programación asincrónica. También podría tener código enlazado a la
CPU, como realizar un cálculo costoso, que también es un buen escenario para escribir código asincrónico.

C# tiene un modelo de programación asincrónico de nivel de lenguaje que permite escribir fácilmente código asincrónico
sin tener que hacer malabares con las devoluciones de llamada (callbacks) o ajustarse a una biblioteca que admita la
asincronía.
Sigue lo que se conoce como
el [modelo asincrónico basado en tareas (TAP)](https://learn.microsoft.com/es-es/dotnet/standard/asynchronous-programming-patterns/task-based-asynchronous-pattern-tap).

## Información general del modelo Asincrónico

El núcleo de la programación asincrónica son los objetos Task y Task<T>, que modelan las operaciones asincrónicas. Son
compatibles con las palabras clave async y await. El modelo es bastante sencillo en la mayoría de los casos:

Para el código enlazado a E/S, espera una operación que devuelva Task o Task<T> dentro de un método async.
Para el código enlazado a la CPU, espera una operación que se inicia en un subproceso en segundo plano con el método
Task.Run.
La palabra clave await es donde ocurre la magia. Genera control para el autor de la llamada del método que ha realizado
await, y permite en última instancia una interfaz de usuario con capacidad de respuesta o un servicio flexible. Aunque
existen maneras de abordar el código asincrónico diferentes de async y await.

## Qué sucede en segundo plano

En lo que respecta a C#, el compilador transforma el código en una máquina de estados que realiza el seguimiento de
acciones como la retención de la ejecución cuando se alcanza await y la reanudación de la ejecución cuando se ha
finalizado un trabajo en segundo plano.

## Piezas claves

El código asincrónico puede usarse para código tanto enlazado a E/S como enlazado a la CPU, pero de forma distinta en
cada escenario.
El código asincrónico usa Task<T> y Task, que son construcciones que se usan para modelar el trabajo que se realiza en
segundo plano.
La palabra clave async convierte un método en un método asincrónico, lo que permite usar la palabra clave await en su
cuerpo.
Cuando se aplica la palabra clave await, se suspende el método de llamada y se cede el control al autor de la llamada
hasta que se completa la tarea esperada.
await solo puede usarse dentro de un método asincrónico.
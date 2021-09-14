# Trabajos Prácticos de Simulación


## Funcionamiento

Para hacer un código que sea funcional, fácil de programar y mantener, se optó por la arquitectura MVC (modelo-vista-controlador).

### Controlador

#### Inicio de un Controlador
Por cada Trabajo Practico existe un controlador especifico que va a ser ejecutado cuando el programa se inicia. La clase estática **Program**  es la que lo llama.

Iniciar Controlador:
```C#
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ControladorTPX.GetInstance().Start();
        }
    }.
```
Ejemplo: Iniciar Controlador TP3:

```C#
            ControladorTP3.GetInstance().Start();
```

#### Responsabilidades:

>  Poseer la lógica de funcionamiento de un solo TP.

>  Administrar las Interfaces de Usuario (Crear, Eliminar, Enviar y Recibir datos).

>  Comunicarse con los objetos entidades para delegar tareas.

> Ser el intermediario entre las Pantallas y las Entidades.

#### Patrón Singleton

La finalidad es que exista únicamente un solo objeto controlador en toda la vida del programa.

La clase controlador al aplicar este patrón no puede ser instanciada por ningún otro objeto. La clase controlador se instancia a si misma y es al inicio del programa. 
 ```C#
    public class ControladorTP3 : ApplicationContext
    {
        private static readonly ControladorTP3 _instance = new ControladorTP3();
```

 ```C#
   public static ControladorTP3 GetInstance() {
    return _instance; 
   }
   ```
Si un objeto necesita de los servicios del controlador debe llamar al método getInstance() donde el controlador se devuelve a si mismo.

Ejemplo: El objeto que llama, pide la instancia de controladorTP3 y a esa instancia le pide ejecutar el método Start()
```C#
            ControladorTP3.GetInstance().Start();
```

 Esto permite que todos los objetos que utilicen servicios del controlador, utilicen el mismo objeto controlador.
 

 

### Interfaces de Usuario

#### Responsabilidades:

>  Recibir y mostrar datos en la pantalla.

> Ser el intermediario entre la lógica y el usuario.

> Convertir los datos en formas amigables para el usuario.

### Entidades

#### Responsabilidades:

>  Realizar el trabajo que le fue delegado.

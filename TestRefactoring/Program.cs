namespace TestRefactoring
{
    using System;
    using System.Threading.Tasks;
    using TestRefactoring.BusinessLogic;

    internal class Program
    {
        /*
        1) PRUEBA .NET:
        Consigna: Optimizar el código lo máximo posible.
        Lo que se vea que se puede optimizar, hacerlo.
        Todos los cambios quedan a criterio del programador y se aceptan todo tipo de cambios.

        HECHO:
        Crear solucion tipo consola
        substituir el main del proyecto por el del test
        Agregar un repositorio git local
        Refactorizar: 1 Interface comun para los 2: ITrabajador
        Llevar las clases a sus archivos
        Encapsular las propiedades
        Clase Trabajador para que Calcular precio no se repita
        Calcular precio de la misma forma que los otros metodos de la clase
        Clean Code: agregar metodo ProcesarTrabajador: Si se metiese en la clase, el console.Writeline iria fuera y se deberia guardar el objeto
        Dias y precio es un data clump con un metodo: calcularPrecio

        Evitar el código duplicado, usando buenas prácticas de programación orientada a objetos, que es fundamental para nuestros nuevos desarrollos.
        Separación de capas y uso correspondiente de cada función en cada capa.
        Evitar declaraciones innecesarias (variables privadas).
        Multithreading, ya que está permitido y hay casos para aplicarlo.
        */

        private static void Main()
        {
            Task task1 = new Task(() => ProcesarTrabajador(
                new TrabajadorService(),
                new Empleado
                {
                    Nombre = "Carlos",
                    Apellido = "Rodriguez",
                    Comentarios = "Habla inglés perfecto",
                    Tarea = new TareaFacturable
                    {
                        Dias = 5,
                        Precio = 25,
                    }
                }));
            task1.Start();

            Task task2 = new Task(() => ProcesarTrabajador(
                new TrabajadorService(),
                new Freelance
                {
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    Tarea = new TareaFacturable
                    {
                        Dias = 10,
                        Precio = 50,
                    },
                    FechaNacimiento = new DateTime(1987, 7, 1),
                }));
            task2.Start();

            task1.Wait();
            task2.Wait();

            Console.Write("\nPulsa una tecla para finalizar...");
            Console.ReadKey();
        }

        private static void ProcesarTrabajador(ITrabajadorService trabajadorService, ITrabajador trabajador)
        {
            trabajadorService.ProcesarTrabajador(trabajador);

            Console.WriteLine(trabajador.NombreCompleto + ": " + trabajadorService.CalcularPrecio(trabajador.Tarea));
        }
    }
}
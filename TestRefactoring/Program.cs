namespace TestRefactoring
{
    using System;

    internal class Program
    {
        /*
        1) PRUEBA .NET:
        Consigna: Optimizar el código lo máximo posible.
        Todo lo que se vea que se puede optimizar, hacerlo.
        Todos los cambios quedan a criterio del programador y se aceptan todo tipo de cambios.

        HECHO:
        Crear solucion tipo consola
        substituir el main del proyecto por el del test
        Agregar un repositorio git local
        Refactorizar: 1 Interface comun para los 2: ITrabajador
        Llevar las clases a sus archivos
        Encapsular las propiedades
        Clase Trabajador para que Calcular precio no se repita
        Los metodos de la clase: ¿Dentro del "dominio" o fuera con algun patron? (Prefiero dentro del dominio)
        Calcular precio de la misma forma que los otros metodos de la clase
        Clean Code: agregar metodo ProcesarTrabajador: Si se metiese en la clase, el console.Writeline iria fuera y se deberia guardar el objeto
        Dias y precio es un data clump con un metodo: calcularPrecio
        */

        private static void Main()
        {
            ProcesarTrabajador(new Empleado
            {
                Nombre = "Carlos",
                Apellido = "Rodriguez",
                Comentarios = "Habla inglés perfecto",
                Tarea = new TareaFacturable
                {
                    Dias = 5,
                    Precio = 25,
                }
            });

            ProcesarTrabajador(new Freelance
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                Tarea = new TareaFacturable
                {
                    Dias = 10,
                    Precio = 50,
                },
                FechaNacimiento = new DateTime(1987, 7, 1),
            });

            Console.Write("\nPulsa una tecla para finalizar...");
            Console.ReadKey();
        }

        private static void ProcesarTrabajador(Trabajador trabajador)
        {
            trabajador.ProcesarPedidos();
            trabajador.ProcesarTareas();

            Console.WriteLine(trabajador.NombreCompleto + ": " + trabajador.Tarea.Total);
        }
    }
}
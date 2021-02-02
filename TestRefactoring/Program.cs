using System;

namespace TestRefactoring
{
    class Program
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

        TODO:
        Refactorizar: 1 Interface comun para los 2 ¿ITrabajador?
        Llevar las clases a sus archivos
        Encapsular las propiedades
        Los metodos de la clase: ¿Dentro del "dominio" o fuera con algun patron? (Prefiero dentro del dominio)
        Calcular precio de la misma forma que los otros metodos de la clase
        */

        static void Main(string[] args)
        {
            Empleado claseA = new Empleado
            {
                Nombre = "Carlos",
                Apellido = "Rodriguez",
                Comentarios = "Habla inglés perfecto",
                NombreCompleto = "Carlos" + " " + "Rodriguez",
                Dias = 5,
                Precio = 25
            };

            claseA.ProcesarPedidos();
            claseA.ProcesarTareas();

            Console.WriteLine(claseA.NombreCompleto + ": " + claseA.CalcularPrecio());

            Freelance claseB = new Freelance
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                NombreCompleto = "Juan" + " " + "Pérez",
                Dias = 10,
                Precio = 50,
                FechaNacimiento = new DateTime(1987, 7, 1)
            };

            claseB.ProcesarPedidos();
            claseB.ProcesarTareas();

            Console.WriteLine(claseA.NombreCompleto + ": " + claseB.CalcularPrecio());

            Console.ReadLine();
        }


        //private static int CalcularPrecio(Freelance pFreelance)
        //{
        //    return pFreelance.Dias * pFreelance.Precio;
        //}
    }


}

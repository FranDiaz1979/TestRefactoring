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
			
        */

        static void Main(string[] args)
        {
            Empleado claseA = new Empleado();
            claseA.Nombre = "Carlos";
            claseA.Apellido = "Rodriguez";
            claseA.Comentarios = "Habla inglés perfecto";
            claseA.NombreCompleto = "Carlos" + " " + "Rodriguez";
            claseA.Dias = 5;
            claseA.Precio = 25;

            claseA.ProcesarPedidos();
            claseA.ProcesarTareas();

            Console.WriteLine(claseA.NombreCompleto + ":" + CalcularPrecio(claseA));

            Freelance claseB = new Freelance();
            claseB.Nombre = "Juan";
            claseB.Apellido = "Pérez";
            claseB.NombreCompleto = "Juan" + " " + "Pérez";
            claseB.Dias = 10;
            claseB.Precio = 50;
            claseB.FechaNacimiento = new DateTime(1987, 7, 1);

            claseB.ProcesarPedidos();
            claseB.ProcesarTareas();

            Console.WriteLine(claseA.NombreCompleto + ":" + CalcularPrecio(claseB));

            Console.ReadLine();
        }

        private static int CalcularPrecio(Empleado pEmpleado)
        {
            return pEmpleado.Dias * pEmpleado.Precio;
        }

        private static int CalcularPrecio(Freelance pFreelance)
        {
            return pFreelance.Dias * pFreelance.Precio;
        }
    }

    class Empleado
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get; set; }

        public int Dias { get; set; }

        public int Precio { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Comentarios { get; set; }


        public void ProcesarTareas()
        {
            //Código
        }

        public void ProcesarPedidos()
        {
            //Código
        }

        public void ProcesarVacaciones()
        {
            //Código
        }
    }

    class Freelance
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get; set; }

        public int Dias { get; set; }

        public int Precio { get; set; }

        public DateTime FechaNacimiento { get; set; }


        public void ProcesarTareas()
        {
            //Código
        }

        public void ProcesarPedidos()
        {
            //Código
        }

        public void ProcesarVacaciones()
        {
            //Código
        }
    }
}

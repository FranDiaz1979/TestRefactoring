namespace TestRefactoring
{
    using System;

    interface ITrabajador
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get; }

        public int Dias { get; set; }

        public int Precio { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public void ProcesarTareas();

        public void ProcesarPedidos();

        public void ProcesarVacaciones();

        public int CalcularPrecio();

    }
}

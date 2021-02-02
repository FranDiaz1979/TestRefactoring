namespace TestRefactoring
{
    using System;

    internal interface ITrabajador
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get; }

        public TareaFacturable Tarea { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public void ProcesarTareas();

        public void ProcesarPedidos();

        public void ProcesarVacaciones();
    }
}
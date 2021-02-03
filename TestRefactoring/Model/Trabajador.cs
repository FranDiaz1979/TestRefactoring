namespace TestRefactoring
{
    using System;

    internal class Trabajador : ITrabajador
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get => this.Nombre + " " + this.Apellido; }

        public TareaFacturable Tarea { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
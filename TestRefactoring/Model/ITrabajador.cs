namespace TestRefactoring
{
    using System;

    public interface ITrabajador
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get; }

        public TareaFacturable Tarea { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
namespace TestRefactoring
{
    using System;

    internal class Trabajador : ITrabajador
    {
        private string apellido;
        private string nombre;
        private TareaFacturable tarea;
        private DateTime fechaNacimiento;

        public string Nombre { get => this.nombre; set => this.nombre = value; }

        public string Apellido { get => this.apellido; set => this.apellido = value; }

        public string NombreCompleto { get => this.nombre + " " + this.apellido; }

        public TareaFacturable Tarea { get => this.tarea; set => this.tarea = value; }

        public DateTime FechaNacimiento { get => this.fechaNacimiento; set => this.fechaNacimiento = value; }

        public virtual void ProcesarTareas()
        {
            // Código
        }

        public virtual void ProcesarPedidos()
        {
            // Código
        }

        public virtual void ProcesarVacaciones()
        {
            // Código
        }
    }
}
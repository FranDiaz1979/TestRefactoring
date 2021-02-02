namespace TestRefactoring
{
    using System;

    class Trabajador : ITrabajador
    {
        private string apellido;
        private string nombre;
        private TareaFacturable tarea;
        private DateTime fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        
        public string Apellido { get => apellido; set => apellido = value; }

        public string NombreCompleto { get => nombre + " " + apellido; }

        public TareaFacturable Tarea { get => tarea; set => tarea = value; }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        virtual public void ProcesarTareas()
        {
            //Código
        }

        virtual public void ProcesarPedidos()
        {
            //Código
        }

        virtual public void ProcesarVacaciones()
        {
            //Código
        }
    }
}

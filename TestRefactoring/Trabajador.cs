namespace TestRefactoring
{
    using System;

    class Trabajador : ITrabajador
    {
        private string apellido;
        private string nombre;
        private int dias;
        private int precio;
        private DateTime fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        
        public string Apellido { get => apellido; set => apellido = value; }

        public string NombreCompleto { get => nombre + " " + apellido; }

        public int Dias { get => dias; set => dias = value; }

        public int Precio { get => precio; set => precio = value; }

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

        public int CalcularPrecio()
        {
            return Dias * Precio;
        }

    }
}

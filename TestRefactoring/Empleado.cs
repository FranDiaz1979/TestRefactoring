using System;
using System.Collections.Generic;
using System.Text;

namespace TestRefactoring
{
    class Empleado : ITrabajador
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
}

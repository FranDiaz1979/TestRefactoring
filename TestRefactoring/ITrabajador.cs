using System;
using System.Collections.Generic;
using System.Text;

namespace TestRefactoring
{
    interface ITrabajador
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreCompleto { get; }

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

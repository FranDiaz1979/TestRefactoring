namespace TestRefactoring.BusinessLogic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TrabajadorService : ITrabajadorService
    {
        public void ProcesarTareas(ITrabajador trabajador)
        {
            // Código
        }

        public void ProcesarPedidos(ITrabajador trabajador)
        {
            // Código
        }

        public void ProcesarVacaciones(ITrabajador trabajador)
        {
            // Código
        }

        public void ProcesarTrabajador(ITrabajador trabajador)
        {
            ProcesarPedidos(trabajador);
            ProcesarTareas(trabajador);
        }

        public double CalcularPrecio(TareaFacturable tarea)
        {
            return tarea.Dias * tarea.Precio; 
        }

    }
}


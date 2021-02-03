using System;
using System.Collections.Generic;
using System.Text;

namespace TestRefactoring.BusinessLogic
{
    public interface ITrabajadorService
    {
        public void ProcesarTareas(ITrabajador trabajador);

        public void ProcesarPedidos(ITrabajador trabajador);

        public void ProcesarVacaciones(ITrabajador trabajador);

        public void ProcesarTrabajador(ITrabajador trabajador);

        public double CalcularPrecio(TareaFacturable tarea);
    }
}

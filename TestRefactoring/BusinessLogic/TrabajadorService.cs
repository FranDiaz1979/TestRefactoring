namespace TestRefactoring.BusinessLogic
{
    using System.Threading;

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
            new Thread(() => this.ProcesarPedidos(trabajador)).Start();
            new Thread(() => this.ProcesarTareas(trabajador)).Start();
        }

        public double CalcularPrecio(TareaFacturable tarea)
        {
            return tarea.Dias * tarea.Precio;
        }
    }
}
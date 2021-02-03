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
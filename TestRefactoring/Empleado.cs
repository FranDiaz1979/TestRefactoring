namespace TestRefactoring
{
    internal class Empleado : Trabajador, ITrabajador
    {
        public string Comentarios { get; set; }

        public override void ProcesarTareas()
        {
            // Código
        }

        public override void ProcesarPedidos()
        {
            // Código
        }

        public override void ProcesarVacaciones()
        {
            // Código
        }
    }
}
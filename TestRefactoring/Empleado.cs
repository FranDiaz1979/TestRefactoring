namespace TestRefactoring
{
    class Empleado : Trabajador, ITrabajador
    {
        public string Comentarios { get; set; }

        override public void ProcesarTareas()
        {
            //Código
        }

        override public void ProcesarPedidos()
        {
            //Código
        }

        override public void ProcesarVacaciones()
        {
            //Código
        }
    }
}

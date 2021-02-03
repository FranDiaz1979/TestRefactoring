namespace TestRefactoring
{
    internal class Empleado : Trabajador, ITrabajador
    {
        public string Comentarios { get; set; }
    }
}
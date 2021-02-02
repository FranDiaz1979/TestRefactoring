namespace TestRefactoring
{
    internal class TareaFacturable
    {
        private int dias;
        private int precio;

        public int Dias { get => this.dias; set => this.dias = value; }

        public int Precio { get => this.precio; set => this.precio = value; }

        public int Total { get => this.dias * this.precio; }
    }
}
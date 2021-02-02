namespace TestRefactoring
{
    class TareaFacturable
    {
        private int dias;
        private int precio;
        
        public int Dias { get => dias; set => dias = value; }

        public int Precio { get => precio; set => precio = value; }
        
        public int Total { get => dias * precio; }
    }
}

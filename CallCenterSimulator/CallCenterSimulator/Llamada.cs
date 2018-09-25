namespace CallCenterSimulator
{
    class Llamada
    {
        public Categoria Categoria { get; set; }

        public int Duracion { get; set; }

        public Llamada(Categoria categoria, int duracion)
        { 
            Categoria = categoria;
            Duracion = duracion;
        }
    }
}

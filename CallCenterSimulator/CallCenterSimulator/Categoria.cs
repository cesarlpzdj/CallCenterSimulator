namespace CallCenterSimulator
{
    class Categoria
    {

        public string Nombre { get; set; }

        public int Nivel { get; set; }

        public bool Incluir { get; set; }

        public Categoria(string nombre, int nivel, bool incluir)
        {
            Nombre = nombre;
            Nivel = nivel;
            Incluir = incluir;
        }
    }
}   

namespace CallCenterSimulator
{
    class Categoria
    {

        public string Nombre { get; set; }

        public int Nivel { get; set; }

        public Categoria(string nombre, int nivel)
        {
            Nombre = nombre;
            Nivel = nivel;
        }
    }
}   

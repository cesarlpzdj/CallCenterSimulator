namespace CallCenterSimulator
{
    class Agente
    {
        public int Id { get; set; }

        public int Nivel { get; set; }

        public bool Ocupado { get; set; }

        public Llamada Llamada { get; set; }

        public bool Incluir { get; set; }

        public Agente(int id, int nivel, bool incluir)
        {
            Id = id;
            Nivel = nivel;
            Incluir = incluir;
        }

        public void AtenderLlamada(Llamada llamada)
        {
            Ocupado = true;
            Llamada = llamada;
        }

        public void TerminarLlamada(int minutosTranscurridos)
        {
            if (minutosTranscurridos > Llamada.Duracion)
            {
                Ocupado = false;
            }
        }
    }
}

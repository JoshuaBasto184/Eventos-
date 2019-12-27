using System;

namespace Patron_de_diseño
{
    public class Evento : iEventos
    {
        public string cNombreEvento { get; set; }
        public DateTime dtFechaEvento { get; set; }
    }
}

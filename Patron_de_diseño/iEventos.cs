using System;

namespace Patron_de_diseño
{
    public interface iEventos
    {
        string cNombreEvento { get; set; }
        DateTime dtFechaEvento { get; set; }
    }
}

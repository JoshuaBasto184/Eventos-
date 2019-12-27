using System.Collections.Generic;

namespace Patron_de_diseño
{
    public class EstadoDelEvento : iEstado
    {
        public string estadoEvento(string evento, int fecha)
        {
            if (fecha > 0)
            {
                return evento + " ocurría dentro de " + fecha;
            }
            else
            {
                return evento + " ocurrió hace: " + fecha;

            }
        }
    }
}

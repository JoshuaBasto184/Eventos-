using System.Collections.Generic;

namespace Patron_de_diseño
{
    public class EstadoDelEvantoPrecente : iEstado
    {
        public string estadoFecha()
        {
            if (difFecha())
            {
                return "El Evento: {0} \nEsta ocurriendo ahora" ;
            }
            else
            {
                return "huy";
            }
        }


        private bool difFecha()
        {
            return true;
        }
    }
    public class EstadoDelEvantoPasado : iEstado
    {
        public string estadoFecha()
        {
            if (difFecha())
            {
                return "El evento: {0} \nOcurría dentro de {1}";
            }
            else
            {
                return "huy";
            }
        }

        private bool difFecha()
        {
            return true;
        }
    }
    public class EstadoDelEvantoFuturo : iEstado
    {
        public string estadoFecha()
        {
            if (difFecha())
            {
                return "{0} ocurría dentro de {1}";
            }
            else
            {
                return "huy";
            }
        }

        private bool difFecha()
        {
            return true;
        }
    }
}

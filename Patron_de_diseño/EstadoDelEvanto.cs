using System.Collections.Generic;

namespace Patron_de_diseño
{
    public class EstadoDelEvantoPrecente : iEstado
    {
        public string estadoFecha(string dato)
        {
            if (difFecha())
            {
                return dato + " \nEsta ocurriendo ahora";
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
        public string estadoFecha(string dato)
        {
            if (difFecha())
            {
                return dato + " ocurrió hace: {1}";
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
        public string estadoFecha(string dato)
        {
            if (difFecha())
            {
                return  dato + " Ocurría dentro de {1}";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño
{
    public class ComparadorFecha
    {
        public int fechacomparada(DateTime FechaEvento)
        {
            // Difference in days.
            TimeSpan ts = FechaEvento - DateTime.Now;
            int resultado = ts.Days;
            int estadoFecha = 0;


            if (FechaEvento < DateTime.Now)
            {
                estadoFecha = 2;
            }
            else if (FechaEvento > DateTime.Now)
            {
                estadoFecha = 3;
            }
            else
            {
                estadoFecha = 1;
            }
            return estadoFecha;
        }
    }
}

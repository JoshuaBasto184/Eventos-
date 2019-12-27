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

            return ts.Days;
        }
    }
}

using System.Collections.Generic;

namespace Patron_de_diseño
{
    interface iLectorArchivo
    {
        List<iEventos> LeerInformacion(string RutaArchivo);
    }
}

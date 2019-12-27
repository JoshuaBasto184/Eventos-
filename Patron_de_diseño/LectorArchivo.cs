using System;
using System.Collections.Generic;
using System.IO;

namespace Patron_de_diseño
{
    public class LectorArchivoCSV : iLectorArchivo
    {
        public List<iEventos> LeerInformacion(string RutaArchivo)
        {
            List<iEventos> Eventos = new List<iEventos>();
            string[] lineas = File.ReadAllLines(RutaArchivo);

            foreach (string line in lineas)
            {
                string[] dato = line.Split(',');
                var EventoNuevo = new Evento();
                EventoNuevo.cNombreEvento = dato[0];
                EventoNuevo.dtFechaEvento = Convert.ToDateTime(dato[1]);
                Eventos.Add(EventoNuevo);
            }

            return Eventos;
        }
    }
}

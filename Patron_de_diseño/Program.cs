using System;

namespace Patron_de_diseño
{
    public class EstadoFecha
    {
        public iEstado ObtenerIstancia(int Tipo)
        {
            switch (Tipo)
            {
                case 1:
                    return new EstadoDelEvantoPrecente();
                    break;
                case 2:
                    return new EstadoDelEvantoPasado();
                    break;
                default:
                    return new EstadoDelEvantoFuturo();
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            iLectorArchivo LectorCSV = new LectorArchivoCSV();
            Procesar(LectorCSV, "..\\..\\PD.txt");

            var Fabricar = new EstadoFecha();
            iEstado dtFechaEven = Fabricar.ObtenerIstancia(2);
            EscribirResultado(dtFechaEven);
            




            //// Difference in days.
            //diferenciasDias = ts.Days;

            ////Compara la fecha 
            //if (fecha == fechaActual)
            //{
            //    Console.WriteLine("{0} es hoy", separadas[0]);
            //}
            //else
            //{
            //    if (fecha > fechaActual)
            //    {
            //        Console.WriteLine("{0} ocurría dentro de {1}", separadas[0], diferenciasDias);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} ocurrió hace {1}", separadas[0], diferenciasDias);
            //    }
            //}
            Console.ReadKey();

        }

        private static void EscribirResultado(iEstado dtFechaEven)
        {
            Console.WriteLine(dtFechaEven.estadoFecha());
        }

        private static void Procesar(iLectorArchivo _lector, string ruta)
        {
            var Resultado = _lector.LeerInformacion(ruta);
        }
    }
}

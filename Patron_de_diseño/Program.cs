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

        private static void EscribirResultado(iEstado dtFechaEven, string nEvento)
        {
            Console.WriteLine(dtFechaEven.estadoFecha(nEvento));
        }

        private static void Procesar(iLectorArchivo _lector, string ruta)
        {
            var Fabricar = new EstadoFecha();
            var Resultado = _lector.LeerInformacion(ruta);
            var fechacomparada = new ComparadorFecha();
            int dato = 0;

            foreach (var resultado in Resultado)
            {
                dato = fechacomparada.fechacomparada(resultado.dtFechaEvento);

                iEstado dtFechaEven = Fabricar.ObtenerIstancia(dato);
                EscribirResultado(dtFechaEven, resultado.cNombreEvento);
            }
            //string direccion = File.ReadAllText(@"C:\Users\JoshuaBasto\Desktop\PD.txt");
            //string[] separadas;
            //DateTime fechaActual = DateTime.Now.Date;
            //DateTime fecha;
            //int diferenciasDias;


            //fecha = Convert.ToDateTime(separadas[1]);// convierte el dato de especifico en formato fecha

            //TimeSpan ts = fechaActual - fecha;

            
        }
    }
}

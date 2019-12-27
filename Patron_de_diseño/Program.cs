using System;

namespace Patron_de_diseño
{
    public class Fabrica
    {
        public iEstado EstadoEvento()
        {
            return new EstadoDelEvento();
        }
        //public iEstado ObtenerIstancia(int Tipo)
        //{
        //    switch (Tipo)
        //    {
        //        case 1:
        //            return new EstadoDelEvantoPrecente();
        //            break;
        //        case 2:
        //            return new EstadoDelEvantoPasado();
        //            break;
        //        default:
        //            return new EstadoDelEvantoFuturo();
        //            break;
        //    }
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            iLectorArchivo LectorCSV = new LectorArchivoCSV();
            Procesar(LectorCSV, "..\\..\\PD.txt");

            Console.ReadKey();

        }

        private static void EscribirResultado(iEstado fabrica, string nEvento, int dato)
        {
            Console.WriteLine(fabrica.estadoEvento(nEvento, dato));
        }

        private static void Procesar(iLectorArchivo _lector, string ruta)
        {
            var Fabricar = new Fabrica();
            var Resultado = _lector.LeerInformacion(ruta);
            var fechacomparada = new ComparadorFecha();

            foreach (var resultado in Resultado)
            {
                int dato = fechacomparada.fechacomparada(resultado.dtFechaEvento);

                iEstado dtFechaEven = Fabricar.EstadoEvento();
                EscribirResultado(dtFechaEven, resultado.cNombreEvento, dato);
            }
        }
    }
}

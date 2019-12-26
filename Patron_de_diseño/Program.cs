using System;
using System.IO;

namespace Patron_de_diseño
{
    class Program
    {
        static void Main(string[] args)
        {
            string direccion = File.ReadAllText(@"C:\Users\JoshuaBasto\Desktop\PD.txt");
            string[] separadas;
            DateTime fecha;
            int diferenciasDias;

            separadas = direccion.Split(',');//hace la separación en la cadena por medio de coma

            fecha = Convert.ToDateTime(separadas[1]);// convierte el dato de especifico en formato fecha

            TimeSpan ts = fechaActual - fecha;

            // Difference in days.
            diferenciasDias = ts.Days;

            //Compara la fecha 
            {
                Console.WriteLine("{0} ocurrió hace {1}", separadas[0], diferenciasDias);
                Console.WriteLine("{0} es hoy", separadas[0]);
            }
            else
            {
            }


            Console.ReadKey();
        }
    }
}

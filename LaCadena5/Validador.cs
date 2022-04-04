using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena5
{
    public class Validador
    {
        public static void VocalTildada(string cadena)
        {

            string opcion = cadena.Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').Replace('ó', 'o').Replace('ú', 'u');

            Console.WriteLine("\n Usted escribio " + "*" + cadena + "*" + "\n\n Ahora su frase es: " + "*" + opcion + "*");

        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static string ValidarString(string mensaje)
        {

            string opcion;
            do
            {

                Console.WriteLine(mensaje);
                opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.Clear();
                    Console.WriteLine(" \nEl valor ingresado no puede ser vacio.");
                    Console.WriteLine(" Por favor ingrese un valor.");
                }
            } while (string.IsNullOrEmpty(opcion));
            return opcion;

        }
    }
}

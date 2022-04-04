using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena5
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadena;

            cadena = Validador.ValidarString("\n Ingrese una frase");

            Validador.VocalTildada(cadena);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_deudas
{
    internal class GesPantanllas
    {

        public static void cambiarPantalla(Form ventanaInicial, Form VentanaFinal)
        {
            ventanaInicial.Close();
            VentanaFinal.Show();
        }
    }
}

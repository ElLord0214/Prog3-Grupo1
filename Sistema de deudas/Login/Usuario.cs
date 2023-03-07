using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deudas.Login
{
    internal class Usuario
    {
        public Usuario(string nombre, string contra)
        {
            this.nombreUsuario = nombre;
            this.contra = contra;
        }
        public string nombreUsuario { get; set;}
        public string contra { get; set;}
    }
}

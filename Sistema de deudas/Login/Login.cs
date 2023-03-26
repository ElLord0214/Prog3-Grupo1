using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_deudas.Login
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Propiedades
        public static Login mainForm;

        //FLag para mostrar la ventana
        public bool mostrarse = true;


        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cambiarPantalla(new Registro());
        }

        private void IniciarSesion(object sender, EventArgs e)
            // El presionar el boton de inicio de session se ejecuta esta funcion 
        {
            Usuario usuario;
            InicioSesion login;

            if (nUsuario.Text.Trim().Length > 0 
                && contra.Text.Trim().Length > 0) {
                //Si los campos no estan vacios, deben tener letras no espacios vacios
                usuario = new Usuario(nUsuario.Text.Trim(), contra.Text.Trim());
                login = new InicioSesion();

            }else
            {
                MessageBox.Show("Todos los campos son requeridos", "Error");
                return;
            }



            //Si la funcion de inicio de sesion retorna true en la propiedad valido
            //, las credenciales son correctas y se permite ingresar
            mensaje result = login.iniciarSesion(usuario);


            if (result.valido)
            {
                MessageBox.Show(result.message, "Acceso exitoso");
                cambiarPantalla(new Form1(result.idUsuario));
                LimpiarInputs();
            }else {
                MessageBox.Show(result.message, "Error");
                LimpiarContra();
            }
        }

        private void LimpiarContra()
        // Función para limpiar la caja de texto de la contraseña del formulario
        {
            contra.Clear();
        }

        private void LimpiarInputs()
        // Función para limpiar todas las cajas de texto
        {
            nUsuario.Clear();
            contra.Clear();
        }

        private void cambiarPantalla(Form pantalla)
        {
            this.Hide();
            pantalla.Show();
        }
    }
}

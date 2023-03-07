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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Close();
            MessageBox.Show("Funcionalidad no disponible actualmente.");
        }

        private void IniciarSesion(object sender, EventArgs e)
            // El presionar el boton de inicio de session se ejecuta esta funcion 
        {
            var usuario = new Usuario(nUsuario.Text, contra.Text);
            var login = new InicioSesion();
            
            //Si la funcion de inicio de sesion retorna true, las credenciales son correctas
            if (login.iniciarSesion(usuario))
            {
                MessageBox.Show("¡Sesión iniciada correctamente!");
                this.Hide();
                Form1 fr1 = new Form1();
                fr1.Show();

            }else {
                MessageBox.Show("¡Error, Contraseña o nombre de usuario inválido!");
                LimpiarContra();
            }
        }

        private void LimpiarContra()
        // Función para limpiar la caja de texto de la contraseña del formulario
        {
            contra.Text = "";
        }
    }
}

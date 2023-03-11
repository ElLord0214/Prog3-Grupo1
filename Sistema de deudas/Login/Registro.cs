﻿using System;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

      

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.mainForm.mostrarse = true;
            GesPantanllas.cambiarPantalla(this, Login.mainForm);
        }

        private void LimpiarContra()
        // Función para limpiar la caja de texto de la contraseña del formulario
        {
            contra.Clear();
            ConfirmContra.Clear();
        }

        private void LimpiarInputs()
        // Función para limpiar todas las cajas de texto
        {
            nUsuario.Clear();
            contra.Clear();
            ConfirmContra.Clear();
        }

        private void Registrar(object sender, EventArgs e)
        {
            Usuario usuario;
            InicioSesion login;


            if (nUsuario.Text.Trim().Length > 0
                && contra.Text.Trim().Length > 0
                && ConfirmContra.Text.Trim().Length > 0)
            {
                //Si los campos no estan vacios, deben tener letras no espacios
                // Y si y solo si las contraseñas son iguales
                if (contra.Text == ConfirmContra.Text)
                {
                    usuario = new Usuario(nUsuario.Text, contra.Text);
                    login = new InicioSesion();
                }else
                {
                    MessageBox.Show("Las contraseñas con coinciden", "Error");
                    LimpiarContra();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Error");
                return;
            }

            // Si la propiedad valido del objeto retornado por la funcion registrar
            //es verdadera se accede a la aplicación
            mensaje result = login.RegistrarUsuario(usuario);

 
            if (result.valido)
            {
                MessageBox.Show(result.message, "Acceso exitoso");
                GesPantanllas.cambiarPantalla(this, new Form1());
                LimpiarInputs();
            }
            else
            {
                MessageBox.Show(result.message, "Error");
                LimpiarContra();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.mainForm.Close();
            this.Close();
        }
    }
}

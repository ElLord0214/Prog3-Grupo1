using Sistema_de_deudas.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deudas.Login
{
    internal class InicioSesion
    //Es una clase con las funcionalidades de inicio de sesion, registro y actividades concernientes a la gestion de credenciales
    {
        // propiedades
        string conn = Settings.Default.TransporteMinyetyConnectionString;

        public bool iniciarSesion(Usuario user)
        //Esta funcion tiene como objetivo Verificar si las credenciales son correctas para el inicio de sesion de la aplicacion
        {
            Conexion conn = Conexion.getConexion();
            conn.sqlConn.Open();
            var queryUsuario = $"Select Usuario, Password FROM login WHERE Usuario = '{user.nombreUsuario}'";
            SqlCommand query = new SqlCommand(queryUsuario, conn.sqlConn);

            SqlDataReader datos = query.ExecuteReader();

            bool validado = false;


            if (!datos.Read())
            {
                validado = false;
            }else
            {
                if (user.contra == (string)datos["Password"])
                {
                    validado = true;
                }else
                {
                    validado = false;
                }
            }

            conn.sqlConn.Close();
            return validado;
        }
    }
}

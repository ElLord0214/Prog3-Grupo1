using Microsoft.Win32.SafeHandles;
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

        public mensaje iniciarSesion(Usuario user)
        //Esta funcion tiene como objetivo Verificar si las credenciales son correctas para el inicio de sesion de la aplicacion
        {
            bool validado = false;
            string mensaje = "";
            Conexion conn = Conexion.getConexion();
            
            try {
                conn.sqlConn.Open();
                var queryUsuario = $"Select Usuario, Password FROM login WHERE Usuario = '{user.nombreUsuario}'";
                SqlCommand query = new SqlCommand(queryUsuario, conn.sqlConn);

                SqlDataReader datos = query.ExecuteReader();
                
                if (!datos.Read())
                {
                    validado = false;
                    mensaje = "¡Error, Contraseña o nombre de usuario inválido!";
                }
                else
                {
                    if (user.contra == (string)datos["Password"])
                    {
                        validado = true;
                        mensaje = "¡Sesión iniciada correctamente!";
                    }
                    else
                    {
                        validado = false;
                        mensaje = "¡Error, Contraseña o nombre de usuario inválido!";
                    }
                }

            }
            catch(Exception ex)
            {
                validado = false;
                mensaje = "¡Error, ha ocurrido un error inesperado";

                Console.WriteLine(ex.Message);
            }


            conn.sqlConn.Close();
            return new mensaje(validado, mensaje);
        }

        public mensaje RegistrarUsuario(Usuario user)
        {

            bool validado;
            string mensaje;
            Conexion conn = Conexion.getConexion();
            try {
                conn.sqlConn.Open();
                string query = $"SELECT count(*) as numUsuarios FROM Login WHERE Usuario = '{user.nombreUsuario}';";
                SqlCommand command = new SqlCommand(query, conn.sqlConn);

                SqlDataReader datos = command.ExecuteReader();
                datos.Read();
                int numUsuarios = (int)datos["numUsuarios"];
                datos.Close();


                Console.WriteLine($"Dato: {numUsuarios}");
                if (numUsuarios > 0)
                {
                    validado = false;
                    mensaje = "Ese nombre de usuario ya existe";
                }else
                {
                    query = $"INSERT INTO Login(Usuario, Password) VALUES ('{user.nombreUsuario}','{user.contra}');";
                    command = new SqlCommand(query, conn.sqlConn);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        validado = true;
                        mensaje = "Usuario creado correctamente";
                    }else
                    {
                        validado = false;
                        mensaje = "Error: No se creo la cuenta";
                    }
                }
                
                


            } catch(Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                validado = false;
                mensaje = "Error inesperado: Usuario no agregado correctamente";
            }

            conn.sqlConn.Close();
            return new mensaje(validado, mensaje);
        }
    }
    public class mensaje {
        public bool valido;
        public string message;

        public mensaje(bool valido, string message)
        {
            this.valido = valido;
            this.message = message;
        }
    }
}


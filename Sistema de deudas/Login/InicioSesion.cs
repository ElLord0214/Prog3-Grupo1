using Microsoft.Win32.SafeHandles;
using Sistema_de_deudas.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
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
        const string ERROR_MESSAGE_USER_NOT_ADDED = "Error inesperado: Usuario no agregado correctamente";

        public mensaje iniciarSesion(Usuario user)
        //Esta funcion tiene como objetivo Verificar si las credenciales son correctas para el inicio de sesion de la aplicacion
        {
            bool validado;
            string mensaje;
            int ID = 0;
            Conexion conn = Conexion.getConexion();
            
            try {
                conn.sqlConn.Open();
                var queryUsuario = "EXECUTE Log_in @nombre = @userName, @ID = @userID OUTPUT, @pass = @userPass OUTPUT, ";
                queryUsuario += "@logged = @userLogged OUTPUT;";
                SqlCommand query = new SqlCommand(queryUsuario, conn.sqlConn);

                query.Parameters.Add("@userName", SqlDbType.VarChar, 50);
                query.Parameters["@userName"].Value = user.nombreUsuario;

                query.Parameters.Add("@userID", SqlDbType.Int);
                query.Parameters["@userID"].Direction = System.Data.ParameterDirection.Output;

                query.Parameters.Add("@UserPass", SqlDbType.VarChar, 60);
                query.Parameters["@userPass"].Direction = System.Data.ParameterDirection.Output;

                query.Parameters.Add("@userLogged", SqlDbType.Int);
                query.Parameters["@userLogged"].Direction = ParameterDirection.Output;

                query.ExecuteNonQuery();

                bool logged = (int)query.Parameters["@userLogged"].Value == 1 ? true : false;


                if (!logged)
                {
                    validado = false;
                    mensaje = "¡Contraseña o nombre de usuario inválido!";
                }
                else
                {
                    string password = (string)query.Parameters["@userPass"].Value;

                    if (user.contra == password)
                    {
                        validado = true;
                        mensaje = "¡Sesión iniciada correctamente!";
                        ID = (int)query.Parameters["@userID"].Value;
                    }
                    else
                    {
                        validado = false;
                        mensaje = "¡Contraseña o nombre de usuario inválido!";
                    }
                }

            }
            catch(Exception ex)
            {
                validado = false;
                mensaje = "¡ha ocurrido un error inesperado";

                Console.WriteLine(ex.Message);
            }


            conn.sqlConn.Close();
            return new mensaje(validado, mensaje, ID);
        }

        
        public mensaje RegistrarUsuario(Usuario user)
        {
            bool validado = false;
            string mensaje = "";
            int ID = 0;
            Conexion conn = Conexion.getConexion();
            try {

                conn.sqlConn.Open();
                string query = $"EXECUTE dbo.RegisterUser @Usuario = @username, @password = @pass, @ID = @userID OUTPUT;";
                SqlCommand command = new SqlCommand(query, conn.sqlConn);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50);
                command.Parameters["@username"].Value = user.nombreUsuario;

                command.Parameters.Add("@pass", System.Data.SqlDbType.VarChar, 60);
                command.Parameters["@pass"].Value = user.contra;

                command.Parameters.Add("@userId", System.Data.SqlDbType.Int);
                command.Parameters["@userId"].Direction = System.Data.ParameterDirection.Output;

                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    // datos que seran retornados
                    validado = true;
                    mensaje = "Usuario agregado correctamente";
                    ID = (int)command.Parameters["@userID"].Value;
                }
                else
                {
                    validado = false;
                    mensaje = ERROR_MESSAGE_USER_NOT_ADDED;
                }

            } catch(SqlException sqlE) {
                validado = false;
                mensaje = "Error inesperado: Usuario no agregado correctamente";

                Console.WriteLine(sqlE.Message);

                if (sqlE.Number == 2627)
                {
                    mensaje = "¡El nombre de usuario ya existe!";
                }
            } catch {
                validado = false;
                mensaje = ERROR_MESSAGE_USER_NOT_ADDED;
            }

            conn.sqlConn.Close();
            return new mensaje(validado, mensaje, ID);
        }
    }
    public class mensaje {
        public bool valido;
        public string message;
        public int idUsuario = 0;

        public mensaje(bool valido, string message)
        {
            this.valido = valido;
            this.message = message;
        }

        public mensaje(bool valido, string message, int idUsuario):this(valido, message)
        {
            this.idUsuario = idUsuario;
        }
    }
}


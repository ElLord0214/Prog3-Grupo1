using Sistema_de_deudas.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deudas
{
    internal class Conexion
    {
        //Propiedades
        private static Conexion conn = null;
        public SqlConnection sqlConn;
        
        //Constructor
        private Conexion()
        {
            string connString = Settings.Default.TransporteMinyetyConnectionString;
            this.sqlConn = new SqlConnection(connString);
        }

        public static Conexion getConexion()
        {
            if (Conexion.conn == null)
            {
                Conexion.conn = new Conexion();
            }
            return Conexion.conn;
        }
    }
}

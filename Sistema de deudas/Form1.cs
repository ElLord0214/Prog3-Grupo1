using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_deudas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=JMGAMER15\\SQLEXPRESS; database=Deudas; integrated security=true");
            connection.Open();
            // TODO: esta línea de código carga datos en la tabla 'deudasDataSet1.Sistema_de_Deudas' Puede moverla o quitarla según sea necesario.
            String codigo3 = "Select * From Sistema_de_Deudas ";
            SqlCommand comando3 = new SqlCommand(codigo3, connection);
            SqlDataReader reader = comando3.ExecuteReader();
            connection.Close();
            connection.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(comando3);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            connection.Close();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Cedula = txtCedula.Text;
            String Nombre = txtNombre.Text;
            String Apellido = txtApellido.Text;
            String Numero = txtNumero.Text;
            String Detalles = txtDetalle.Text;
            String Monto = txtMonto.Text;


            SqlConnection connection = new SqlConnection("server=JMGAMER15\\SQLEXPRESS; database=Deudas; integrated security=true");
            connection.Open();
            String codigo = "insert into Sistema_de_Deudas(Cedula,Nombre,Apellidos,Numero,Detalles,Monto) values('" + Cedula + "','" + Nombre + "','" + Apellido + "','" + Numero + "','" + Detalles + "','" + Monto + "')";
            SqlCommand comando = new SqlCommand(codigo, connection);
            SqlDataReader reader3 = comando.ExecuteReader();

            connection.Close();


            connection.Open();


            String codigo2 = "Select * From Sistema_de_Deudas ";
            SqlCommand comando2 = new SqlCommand(codigo2, connection);
            SqlDataReader reader = comando2.ExecuteReader();
            connection.Close();
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;





            connection.Close();
        }
    }
}

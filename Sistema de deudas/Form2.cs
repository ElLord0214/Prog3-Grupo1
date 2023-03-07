using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_deudas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transporteMinyetyDataSet.Sistema_de_Deudas' Puede moverla o quitarla según sea necesario.
            this.sistema_de_DeudasTableAdapter.Fill(this.transporteMinyetyDataSet.Sistema_de_Deudas);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Cedula = txtCedula.Text;
            String Nombre = txtNombre.Text;
            String Apellido = txtApellido.Text;
            String Numero = txtNumero.Text;
            String Detalles = txtDetalle.Text;
            String Monto = txtMonto.Text;


            SqlConnection connection = new SqlConnection("Server=tcp:srvtransportes.database.windows.net,1433;Initial Catalog=MyDbAzure;Persist Security Info=False;User ID=transporteMinAdmin;Password=TransporteMinyetypsw012@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();
            String codigo2 = "insert into Sistema_de_Deudas(Cedula,Nombre,Apellidos,Numero,Detalles,Monto) values('"+Cedula+"','"+Nombre+"','"+Apellido+"','"+Numero+"','"+Detalles+"','"+Monto+"')";
            SqlCommand comando2 = new SqlCommand(codigo2, connection);
            SqlDataReader reader3 = comando2.ExecuteReader();

            connection.Close();


        }
    }
}

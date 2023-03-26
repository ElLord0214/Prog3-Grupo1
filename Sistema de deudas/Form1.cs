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
using Sistema_de_deudas.Login;
using Sistema_de_deudas.Properties;

namespace Sistema_de_deudas
{
    public partial class Form1 : Form
    {
        int id_user;
        public Form1(int id)
        {
            InitializeComponent();
            id_user = id;
        }
        String name;
        public  void Nombre(String nombre)
        {
            String name1 = nombre;
            name = name1;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int id_usuario = id_user;
            SqlConnection connection = new SqlConnection(Settings.Default.TransporteMinyetyConnectionString);
            connection.Open();
            String codigo3 = "Select ID,Cedula,Nombre,Apellidos,telefono,Detalles,Monto,Monto_Pagado From Deudas where Id_Usuario='" + id_usuario + "' ";
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

            int id_usuario = id_user;  
            String Cedula = txtCedula.Text;
            String Nombre = txtNombre.Text;
            String Apellido = txtApellido.Text;
            String Numero = txtNumero.Text;
            String Detalles = txtDetalle.Text;
            String Monto = txtMonto.Text;
            float monto_pagado = 0;

            if (Cedula == "" || Nombre == "" || Apellido == "" || Numero =="" || Detalles == "" || Monto=="") {

                MessageBox.Show("Debe llenar todos los campos!!!");
            }
            else { 
            SqlConnection connection = new SqlConnection(Settings.Default.TransporteMinyetyConnectionString);
            connection.Open();
            String codigo = "insert into Deudas(Cedula,Nombre,Apellidos,telefono,Detalles,Monto,Monto_Pagado,Id_Usuario) values('" + Cedula + "','" + Nombre + "','" + Apellido + "','" + Numero + "','" + Detalles + "','" + Monto + "','" + monto_pagado + "','" + id_usuario + "')";
            SqlCommand comando = new SqlCommand(codigo, connection);
            SqlDataReader reader3 = comando.ExecuteReader();
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumero.Clear();
            txtDetalle.Clear();
            txtMonto.Clear();
            connection.Close();


            connection.Open();
            String codigo2 = "Select * From Deudas where Id_Usuario='" + id_usuario+"' ";
            SqlCommand comando2 = new SqlCommand(codigo2, connection);
            SqlDataReader reader = comando2.ExecuteReader();

            reader.Close();
            SqlDataAdapter da = new SqlDataAdapter(comando2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //quitar visivilidad
            label1.Visible= false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
    
            txtApellido.Visible = false;
            txtCedula.Visible = false;
            txtDetalle.Visible = false;
            txtMonto.Visible = false;
            txtNombre.Visible = false;
            txtNumero.Visible = false;
       
            btnCerrar.Visible = false;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;


            //poner visible
            txtiddelete.Visible = true;
            label7.Visible= true;
            btnOK.Visible= true;
            btndelete.Visible= true;
            btnBuscar.Visible= true;


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String id1 = txtiddelete.Text;
            int id = int.Parse(id1);
            SqlConnection connection = new SqlConnection(Settings.Default.TransporteMinyetyConnectionString);
            connection.Open();
            // TODO: esta línea de código carga datos en la tabla 'deudasDataSet1.Sistema_de_Deudas' Puede moverla o quitarla según sea necesario.
            String codigo3 = "Delete from Deudas where ID='"+id+"' ";
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            //quitar visivilidad
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            txtApellido.Visible = true;
            txtCedula.Visible = true;
            txtDetalle.Visible = true;
            txtMonto.Visible = true;
            txtNombre.Visible = true;
            txtNumero.Visible = true;

            btnCerrar.Visible = true;
            btnGuardar.Visible = true;
            btnEliminar.Visible= true;
            


            //poner visible
            txtiddelete.Visible = false;
            label7.Visible = false;
            btnOK.Visible = false;
            btndelete.Visible = false;
            btnBuscar.Visible= false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dato = txtiddelete.Text;
            if (dato == "") {

                MessageBox.Show("No hay ningun dato en la tabla!!!");
            }
            else {
                String id1 = txtiddelete.Text;
                int id = int.Parse(id1);
            
               

            SqlConnection connection = new SqlConnection(Settings.Default.TransporteMinyetyConnectionString);
            connection.Open();
            // TODO: esta línea de código carga datos en la tabla 'deudasDataSet1.Sistema_de_Deudas' Puede moverla o quitarla según sea necesario.
            String codigo3 = "Select * from Deudas where ID='" + id + "' ";
            SqlCommand comando3 = new SqlCommand(codigo3, connection);
            SqlDataReader reader = comando3.ExecuteReader();
            reader.Close();
            SqlDataAdapter da1 = new SqlDataAdapter(comando3);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            connection.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verDeudasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.Login.mainForm.Show();
        }
    }
}

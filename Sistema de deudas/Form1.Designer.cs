namespace Sistema_de_deudas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sistemadeDeudasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deudasDataSet1 = new Sistema_de_deudas.DeudasDataSet1();
            this.sistema_de_DeudasTableAdapter = new Sistema_de_deudas.DeudasDataSet1TableAdapters.Sistema_de_DeudasTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtiddelete = new System.Windows.Forms.TextBox();
            this.sistema_de_DeudasTableAdapter1 = new Sistema_de_deudas.TransporteMinyetyDataSet1TableAdapters.Sistema_de_DeudasTableAdapter();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeDeudasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deudasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(157, 422);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 38);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 422);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 38);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Numero de Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Detalles de la deuda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cedula";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(21, 198);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(177, 20);
            this.txtNumero.TabIndex = 21;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(21, 142);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(177, 20);
            this.txtApellido.TabIndex = 18;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(21, 345);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(177, 20);
            this.txtMonto.TabIndex = 22;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(21, 248);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(254, 67);
            this.txtDetalle.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 23;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(21, 42);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(177, 20);
            this.txtCedula.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 486);
            this.dataGridView1.TabIndex = 33;
            // 
            // sistemadeDeudasBindingSource
            // 
            this.sistemadeDeudasBindingSource.DataMember = "Sistema_de_Deudas";
            this.sistemadeDeudasBindingSource.DataSource = this.deudasDataSet1;
            // 
            // deudasDataSet1
            // 
            this.deudasDataSet1.DataSetName = "DeudasDataSet1";
            this.deudasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistema_de_DeudasTableAdapter
            // 
            this.sistema_de_DeudasTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(12, 466);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(274, 32);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar un registor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Selecciona el id de el que quieres eliminar";
            this.label7.Visible = false;
            // 
            // txtiddelete
            // 
            this.txtiddelete.Location = new System.Drawing.Point(21, 27);
            this.txtiddelete.Name = "txtiddelete";
            this.txtiddelete.Size = new System.Drawing.Size(177, 20);
            this.txtiddelete.TabIndex = 35;
            this.txtiddelete.Visible = false;
            // 
            // sistema_de_DeudasTableAdapter1
            // 
            this.sistema_de_DeudasTableAdapter1.ClearBeforeFill = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(21, 51);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 37;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(123, 51);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(204, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 510);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtiddelete);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeDeudasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deudasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DeudasDataSet1 deudasDataSet1;
        private System.Windows.Forms.BindingSource sistemadeDeudasBindingSource;
        private DeudasDataSet1TableAdapters.Sistema_de_DeudasTableAdapter sistema_de_DeudasTableAdapter;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtiddelete;
        private TransporteMinyetyDataSet1TableAdapters.Sistema_de_DeudasTableAdapter sistema_de_DeudasTableAdapter1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBuscar;
    }
}


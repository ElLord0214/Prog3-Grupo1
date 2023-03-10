namespace Sistema_de_deudas.Login
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contra = new System.Windows.Forms.TextBox();
            this.nUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmContra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.LinkColor = System.Drawing.Color.Blue;
            this.RegisterLink.Location = new System.Drawing.Point(230, 433);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(87, 16);
            this.RegisterLink.TabIndex = 16;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Iniciar Sesión";
            this.RegisterLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label4.Location = new System.Drawing.Point(97, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "¿Ya tiene cuenta?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.8F);
            this.label2.Location = new System.Drawing.Point(154, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.8F);
            this.label3.Location = new System.Drawing.Point(122, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre de usuario";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.25F);
            this.button1.Location = new System.Drawing.Point(71, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Registrar);
            // 
            // contra
            // 
            this.contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.contra.Location = new System.Drawing.Point(71, 200);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(287, 34);
            this.contra.TabIndex = 2;
            this.contra.UseSystemPasswordChar = true;
            // 
            // nUsuario
            // 
            this.nUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.nUsuario.Location = new System.Drawing.Point(71, 109);
            this.nUsuario.Name = "nUsuario";
            this.nUsuario.Size = new System.Drawing.Size(287, 34);
            this.nUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.8F);
            this.label5.Location = new System.Drawing.Point(116, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Confirmar contraseña";
            // 
            // ConfirmContra
            // 
            this.ConfirmContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ConfirmContra.Location = new System.Drawing.Point(71, 295);
            this.ConfirmContra.Name = "ConfirmContra";
            this.ConfirmContra.Size = new System.Drawing.Size(287, 34);
            this.ConfirmContra.TabIndex = 3;
            this.ConfirmContra.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(71, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cerrar aplicación";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 534);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmContra);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.nUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.TextBox nUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ConfirmContra;
        private System.Windows.Forms.Button button2;
    }
}
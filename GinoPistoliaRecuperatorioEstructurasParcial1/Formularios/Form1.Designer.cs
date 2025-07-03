namespace GinoPistoliaRecuperatorioEstructurasParcial1
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.listClinica = new System.Windows.Forms.ListBox();
            this.listGuardia = new System.Windows.Forms.ListBox();
            this.listPediatria = new System.Windows.Forms.ListBox();
            this.optClinica = new System.Windows.Forms.RadioButton();
            this.optGuardia = new System.Windows.Forms.RadioButton();
            this.optPediatria = new System.Windows.Forms.RadioButton();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblLlamarConsultorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(811, 116);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(131, 41);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(811, 318);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 41);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(811, 271);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(131, 41);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // listClinica
            // 
            this.listClinica.FormattingEnabled = true;
            this.listClinica.Location = new System.Drawing.Point(142, 121);
            this.listClinica.Name = "listClinica";
            this.listClinica.Size = new System.Drawing.Size(127, 238);
            this.listClinica.TabIndex = 3;
            // 
            // listGuardia
            // 
            this.listGuardia.FormattingEnabled = true;
            this.listGuardia.Location = new System.Drawing.Point(326, 121);
            this.listGuardia.Name = "listGuardia";
            this.listGuardia.Size = new System.Drawing.Size(121, 238);
            this.listGuardia.TabIndex = 4;
            // 
            // listPediatria
            // 
            this.listPediatria.BackColor = System.Drawing.SystemColors.Window;
            this.listPediatria.FormattingEnabled = true;
            this.listPediatria.Location = new System.Drawing.Point(527, 121);
            this.listPediatria.Name = "listPediatria";
            this.listPediatria.Size = new System.Drawing.Size(132, 238);
            this.listPediatria.TabIndex = 5;
            // 
            // optClinica
            // 
            this.optClinica.AutoSize = true;
            this.optClinica.Location = new System.Drawing.Point(142, 399);
            this.optClinica.Name = "optClinica";
            this.optClinica.Size = new System.Drawing.Size(56, 17);
            this.optClinica.TabIndex = 6;
            this.optClinica.TabStop = true;
            this.optClinica.Text = "Clinica";
            this.optClinica.UseVisualStyleBackColor = true;
            // 
            // optGuardia
            // 
            this.optGuardia.AutoSize = true;
            this.optGuardia.Location = new System.Drawing.Point(326, 399);
            this.optGuardia.Name = "optGuardia";
            this.optGuardia.Size = new System.Drawing.Size(62, 17);
            this.optGuardia.TabIndex = 7;
            this.optGuardia.TabStop = true;
            this.optGuardia.Text = "Guardia";
            this.optGuardia.UseVisualStyleBackColor = true;
            // 
            // optPediatria
            // 
            this.optPediatria.AutoSize = true;
            this.optPediatria.Location = new System.Drawing.Point(527, 399);
            this.optPediatria.Name = "optPediatria";
            this.optPediatria.Size = new System.Drawing.Size(66, 17);
            this.optPediatria.TabIndex = 8;
            this.optPediatria.TabStop = true;
            this.optPediatria.Text = "Pediatria";
            this.optPediatria.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(128, 46);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(326, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(539, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Clinica",
            "Guardia",
            "Pediatria"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(811, 46);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(131, 21);
            this.cmbEspecialidad.TabIndex = 12;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(128, 27);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 13;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(323, 27);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(536, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(808, 30);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 16;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblLlamarConsultorio
            // 
            this.lblLlamarConsultorio.AutoSize = true;
            this.lblLlamarConsultorio.Location = new System.Drawing.Point(109, 372);
            this.lblLlamarConsultorio.Name = "lblLlamarConsultorio";
            this.lblLlamarConsultorio.Size = new System.Drawing.Size(102, 13);
            this.lblLlamarConsultorio.TabIndex = 17;
            this.lblLlamarConsultorio.Text = "Llamar a Consultorio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.lblLlamarConsultorio);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.optPediatria);
            this.Controls.Add(this.optGuardia);
            this.Controls.Add(this.optClinica);
            this.Controls.Add(this.listPediatria);
            this.Controls.Add(this.listGuardia);
            this.Controls.Add(this.listClinica);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.ListBox listClinica;
        private System.Windows.Forms.ListBox listGuardia;
        private System.Windows.Forms.ListBox listPediatria;
        private System.Windows.Forms.RadioButton optClinica;
        private System.Windows.Forms.RadioButton optGuardia;
        private System.Windows.Forms.RadioButton optPediatria;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblLlamarConsultorio;
    }
}


namespace TrabajoPAVI_Grupo2.ABM
{
    partial class FrmABMPersonal
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
            this.Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbttn1 = new System.Windows.Forms.RadioButton();
            this.rbttn2 = new System.Windows.Forms.RadioButton();
            this.rbttn3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimeFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.cmbMotivoEgreso = new System.Windows.Forms.ComboBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnLimpiarCampos = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.GrillaDelPersonal = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombrePersonal = new System.Windows.Forms.TextBox();
            this.txtDocumentoPersonal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDelPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(58, 35);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(111, 56);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(128, 20);
            this.txtLegajo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // rbttn1
            // 
            this.rbttn1.AutoSize = true;
            this.rbttn1.Location = new System.Drawing.Point(121, 82);
            this.rbttn1.Name = "rbttn1";
            this.rbttn1.Size = new System.Drawing.Size(55, 17);
            this.rbttn1.TabIndex = 5;
            this.rbttn1.TabStop = true;
            this.rbttn1.Text = "Tipo 1";
            this.rbttn1.UseVisualStyleBackColor = true;
            // 
            // rbttn2
            // 
            this.rbttn2.AutoSize = true;
            this.rbttn2.Location = new System.Drawing.Point(121, 100);
            this.rbttn2.Name = "rbttn2";
            this.rbttn2.Size = new System.Drawing.Size(55, 17);
            this.rbttn2.TabIndex = 6;
            this.rbttn2.TabStop = true;
            this.rbttn2.Text = "Tipo 2";
            this.rbttn2.UseVisualStyleBackColor = true;
            // 
            // rbttn3
            // 
            this.rbttn3.AutoSize = true;
            this.rbttn3.Location = new System.Drawing.Point(121, 121);
            this.rbttn3.Name = "rbttn3";
            this.rbttn3.Size = new System.Drawing.Size(55, 17);
            this.rbttn3.TabIndex = 7;
            this.rbttn3.TabStop = true;
            this.rbttn3.Text = "Tipo 3";
            this.rbttn3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 166);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Personal";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(111, 191);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(128, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Barrio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Calle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nro Calle:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha Nac:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Codigo proyecto:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(111, 238);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(128, 20);
            this.txtCalle.TabIndex = 19;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(111, 262);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(128, 20);
            this.txtNroCalle.TabIndex = 21;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(111, 286);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(128, 20);
            this.txtFechaNacimiento.TabIndex = 22;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(111, 29);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(128, 21);
            this.cmbUsuarios.TabIndex = 23;
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(111, 214);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(128, 21);
            this.cmbBarrios.TabIndex = 24;
            // 
            // cmbProyecto
            // 
            this.cmbProyecto.FormattingEnabled = true;
            this.cmbProyecto.Location = new System.Drawing.Point(111, 309);
            this.cmbProyecto.Name = "cmbProyecto";
            this.cmbProyecto.Size = new System.Drawing.Size(128, 21);
            this.cmbProyecto.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Fecha de ingreso:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Fecha de egreso:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Motivo de egreso:";
            // 
            // dateTimeFechaIngreso
            // 
            this.dateTimeFechaIngreso.Location = new System.Drawing.Point(111, 333);
            this.dateTimeFechaIngreso.Name = "dateTimeFechaIngreso";
            this.dateTimeFechaIngreso.Size = new System.Drawing.Size(128, 20);
            this.dateTimeFechaIngreso.TabIndex = 29;
            // 
            // dateTimeFechaEgreso
            // 
            this.dateTimeFechaEgreso.Location = new System.Drawing.Point(111, 357);
            this.dateTimeFechaEgreso.Name = "dateTimeFechaEgreso";
            this.dateTimeFechaEgreso.Size = new System.Drawing.Size(128, 20);
            this.dateTimeFechaEgreso.TabIndex = 30;
            // 
            // cmbMotivoEgreso
            // 
            this.cmbMotivoEgreso.FormattingEnabled = true;
            this.cmbMotivoEgreso.Location = new System.Drawing.Point(111, 381);
            this.cmbMotivoEgreso.Name = "cmbMotivoEgreso";
            this.cmbMotivoEgreso.Size = new System.Drawing.Size(128, 21);
            this.cmbMotivoEgreso.TabIndex = 31;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.BackColor = System.Drawing.Color.Lime;
            this.bttnAgregar.Location = new System.Drawing.Point(137, 416);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(118, 23);
            this.bttnAgregar.TabIndex = 33;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = false;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // bttnLimpiarCampos
            // 
            this.bttnLimpiarCampos.Location = new System.Drawing.Point(9, 416);
            this.bttnLimpiarCampos.Name = "bttnLimpiarCampos";
            this.bttnLimpiarCampos.Size = new System.Drawing.Size(118, 23);
            this.bttnLimpiarCampos.TabIndex = 34;
            this.bttnLimpiarCampos.Text = "Limpiar";
            this.bttnLimpiarCampos.UseVisualStyleBackColor = true;
            this.bttnLimpiarCampos.Click += new System.EventHandler(this.bttnLimpiarCampos_Click);
            // 
            // bttnModificar
            // 
            this.bttnModificar.Location = new System.Drawing.Point(274, 416);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(118, 23);
            this.bttnModificar.TabIndex = 35;
            this.bttnModificar.Text = "Modificar";
            this.bttnModificar.UseVisualStyleBackColor = true;
            this.bttnModificar.Click += new System.EventHandler(this.bttnModificar_Click);
            // 
            // GrillaDelPersonal
            // 
            this.GrillaDelPersonal.AllowUserToAddRows = false;
            this.GrillaDelPersonal.AllowUserToDeleteRows = false;
            this.GrillaDelPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDelPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Legajo,
            this.Apellido,
            this.CodigoProyecto,
            this.Documento});
            this.GrillaDelPersonal.Location = new System.Drawing.Point(277, 35);
            this.GrillaDelPersonal.Name = "GrillaDelPersonal";
            this.GrillaDelPersonal.ReadOnly = true;
            this.GrillaDelPersonal.Size = new System.Drawing.Size(437, 259);
            this.GrillaDelPersonal.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(512, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 29);
            this.label15.TabIndex = 37;
            this.label15.Text = "Delete";
            // 
            // txtNombrePersonal
            // 
            this.txtNombrePersonal.Location = new System.Drawing.Point(505, 362);
            this.txtNombrePersonal.Name = "txtNombrePersonal";
            this.txtNombrePersonal.Size = new System.Drawing.Size(128, 20);
            this.txtNombrePersonal.TabIndex = 42;
            // 
            // txtDocumentoPersonal
            // 
            this.txtDocumentoPersonal.Location = new System.Drawing.Point(505, 337);
            this.txtDocumentoPersonal.Name = "txtDocumentoPersonal";
            this.txtDocumentoPersonal.Size = new System.Drawing.Size(128, 20);
            this.txtDocumentoPersonal.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(437, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Documento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(451, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Nombre:";
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(586, 388);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(118, 23);
            this.bttnEliminar.TabIndex = 43;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombres";
            this.Nombre.HeaderText = "Nombres";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 70;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // CodigoProyecto
            // 
            this.CodigoProyecto.DataPropertyName = "cod_proyecto_asignado";
            this.CodigoProyecto.HeaderText = "Codigo Proyecto";
            this.CodigoProyecto.Name = "CodigoProyecto";
            this.CodigoProyecto.ReadOnly = true;
            this.CodigoProyecto.Width = 70;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "nro_documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(111, 144);
            this.txtDocumento.Mask = "99999999";
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(128, 20);
            this.txtDocumento.TabIndex = 44;
            this.txtDocumento.ValidatingType = typeof(int);
            // 
            // FrmABMPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(726, 453);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.txtNombrePersonal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDocumentoPersonal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.GrillaDelPersonal);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.bttnLimpiarCampos);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.cmbMotivoEgreso);
            this.Controls.Add(this.dateTimeFechaEgreso);
            this.Controls.Add(this.dateTimeFechaIngreso);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbProyecto);
            this.Controls.Add(this.cmbBarrios);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbttn3);
            this.Controls.Add(this.rbttn2);
            this.Controls.Add(this.rbttn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmABMPersonal";
            this.Text = "FrmABMPersonal";
            this.Load += new System.EventHandler(this.FrmABMPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDelPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbttn1;
        private System.Windows.Forms.RadioButton rbttn2;
        private System.Windows.Forms.RadioButton rbttn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimeFechaIngreso;
        private System.Windows.Forms.DateTimePicker dateTimeFechaEgreso;
        private System.Windows.Forms.ComboBox cmbMotivoEgreso;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnLimpiarCampos;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.DataGridView GrillaDelPersonal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombrePersonal;
        private System.Windows.Forms.TextBox txtDocumentoPersonal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
    }
}
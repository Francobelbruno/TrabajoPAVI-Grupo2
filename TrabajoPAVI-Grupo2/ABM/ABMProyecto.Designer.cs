namespace TrabajoPAVI_Grupo2
{
    partial class ABMProyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mskdFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.lblIDProyecto = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grillaProyecto = new System.Windows.Forms.DataGridView();
            this.CodProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(11, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID de cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(22, 88);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(157, 20);
            this.txtIdCliente.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(21, 172);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(157, 20);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // mskdFechaInicio
            // 
            this.mskdFechaInicio.Location = new System.Drawing.Point(137, 328);
            this.mskdFechaInicio.Mask = "00/00/0000";
            this.mskdFechaInicio.Name = "mskdFechaInicio";
            this.mskdFechaInicio.Size = new System.Drawing.Size(67, 20);
            this.mskdFechaInicio.TabIndex = 1;
            this.mskdFechaInicio.ValidatingType = typeof(System.DateTime);
            this.mskdFechaInicio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdFechaInicio_MaskInputRejected);
            // 
            // bntAgregar
            // 
            this.bntAgregar.BackColor = System.Drawing.Color.Silver;
            this.bntAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.bntAgregar.Location = new System.Drawing.Point(650, 97);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(134, 31);
            this.bntAgregar.TabIndex = 3;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = false;
            this.bntAgregar.Click += new System.EventHandler(this.bntAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnModificar.Location = new System.Drawing.Point(650, 144);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 31);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(265, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 38);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBaja.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnBaja.Location = new System.Drawing.Point(650, 239);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(134, 31);
            this.btnBaja.TabIndex = 5;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(448, 378);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(154, 38);
            this.btnLimpiarCampos.TabIndex = 18;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Location = new System.Drawing.Point(21, 250);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(157, 20);
            this.txtIdProyecto.TabIndex = 2;
            this.txtIdProyecto.TextChanged += new System.EventHandler(this.txtIdProyecto_TextChanged);
            // 
            // lblIDProyecto
            // 
            this.lblIDProyecto.AutoSize = true;
            this.lblIDProyecto.BackColor = System.Drawing.Color.Gray;
            this.lblIDProyecto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblIDProyecto.Location = new System.Drawing.Point(10, 228);
            this.lblIDProyecto.Name = "lblIDProyecto";
            this.lblIDProyecto.Size = new System.Drawing.Size(119, 19);
            this.lblIDProyecto.TabIndex = 22;
            this.lblIDProyecto.Text = "ID del proyecto:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(630, 378);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(154, 38);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grillaProyecto
            // 
            this.grillaProyecto.AllowUserToAddRows = false;
            this.grillaProyecto.AllowUserToDeleteRows = false;
            this.grillaProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProyecto,
            this.Descripcion,
            this.IdCliente,
            this.FecInicio});
            this.grillaProyecto.Location = new System.Drawing.Point(241, 42);
            this.grillaProyecto.Name = "grillaProyecto";
            this.grillaProyecto.ReadOnly = true;
            this.grillaProyecto.RowHeadersWidth = 51;
            this.grillaProyecto.RowTemplate.Height = 25;
            this.grillaProyecto.Size = new System.Drawing.Size(378, 304);
            this.grillaProyecto.TabIndex = 26;
            this.grillaProyecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CodProyecto
            // 
            this.CodProyecto.DataPropertyName = "CodProyecto";
            this.CodProyecto.HeaderText = "Codigo Proyecto";
            this.CodProyecto.MinimumWidth = 6;
            this.CodProyecto.Name = "CodProyecto";
            this.CodProyecto.ReadOnly = true;
            this.CodProyecto.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "ID Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 125;
            // 
            // FecInicio
            // 
            this.FecInicio.DataPropertyName = "FecInicio";
            this.FecInicio.HeaderText = "Fecha Inicio";
            this.FecInicio.MinimumWidth = 6;
            this.FecInicio.Name = "FecInicio";
            this.FecInicio.ReadOnly = true;
            this.FecInicio.Width = 125;
            // 
            // btnCargarGrilla
            // 
            this.btnCargarGrilla.BackColor = System.Drawing.Color.Silver;
            this.btnCargarGrilla.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnCargarGrilla.Location = new System.Drawing.Point(650, 191);
            this.btnCargarGrilla.Name = "btnCargarGrilla";
            this.btnCargarGrilla.Size = new System.Drawing.Size(134, 31);
            this.btnCargarGrilla.TabIndex = 6;
            this.btnCargarGrilla.Text = "Cargar grilla";
            this.btnCargarGrilla.UseVisualStyleBackColor = false;
            this.btnCargarGrilla.Click += new System.EventHandler(this.btnCargarGrilla_Click);
            // 
            // ABMProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(805, 428);
            this.Controls.Add(this.btnCargarGrilla);
            this.Controls.Add(this.grillaProyecto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.lblIDProyecto);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.bntAgregar);
            this.Controls.Add(this.mskdFechaInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABMProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Proyecto";
            this.Load += new System.EventHandler(this.ABM_Proyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox mskdFechaInicio;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.Label lblIDProyecto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView grillaProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecInicio;
        private System.Windows.Forms.Button btnCargarGrilla;
    }
}
namespace TrabajoPAVI_Grupo2
{
    partial class ABMProductos
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
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDenominacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecFinDesarrollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnElimOpc = new System.Windows.Forms.Button();
            this.groupBoxProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Controls.Add(this.label6);
            this.groupBoxProductos.Controls.Add(this.btnElimOpc);
            this.groupBoxProductos.Controls.Add(this.btnAct);
            this.groupBoxProductos.Controls.Add(this.txtidProducto);
            this.groupBoxProductos.Controls.Add(this.lblIdProducto);
            this.groupBoxProductos.Controls.Add(this.btnEliminarProducto);
            this.groupBoxProductos.Controls.Add(this.btnActualizarProducto);
            this.groupBoxProductos.Controls.Add(this.txtDenominacion);
            this.groupBoxProductos.Controls.Add(this.btnLimpiarCampos);
            this.groupBoxProductos.Controls.Add(this.txtDescripcion);
            this.groupBoxProductos.Controls.Add(this.btnGuardarProducto);
            this.groupBoxProductos.Controls.Add(this.txtFechaFin);
            this.groupBoxProductos.Controls.Add(this.lblFechaProducto);
            this.groupBoxProductos.Controls.Add(this.lblDescripcion);
            this.groupBoxProductos.Controls.Add(this.lblDenominacion);
            this.groupBoxProductos.Location = new System.Drawing.Point(38, 20);
            this.groupBoxProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProductos.Size = new System.Drawing.Size(402, 393);
            this.groupBoxProductos.TabIndex = 0;
            this.groupBoxProductos.TabStop = false;
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.Silver;
            this.btnAct.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnAct.Location = new System.Drawing.Point(20, 274);
            this.btnAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(154, 27);
            this.btnAct.TabIndex = 14;
            this.btnAct.Text = "Actualizar Producto";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(178, 44);
            this.txtidProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.ReadOnly = true;
            this.txtidProducto.Size = new System.Drawing.Size(200, 20);
            this.txtidProducto.TabIndex = 13;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblIdProducto.ForeColor = System.Drawing.Color.Black;
            this.lblIdProducto.Location = new System.Drawing.Point(81, 45);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(89, 19);
            this.lblIdProducto.TabIndex = 12;
            this.lblIdProducto.Text = "Id Producto";
            this.lblIdProducto.Click += new System.EventHandler(this.lblIdProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnEliminarProducto.Location = new System.Drawing.Point(179, 337);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(199, 27);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Confirmar eliminación";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Visible = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnActualizarProducto.Location = new System.Drawing.Point(179, 274);
            this.btnActualizarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(199, 27);
            this.btnActualizarProducto.TabIndex = 10;
            this.btnActualizarProducto.Text = "Guardar Cambios";
            this.btnActualizarProducto.UseVisualStyleBackColor = false;
            this.btnActualizarProducto.Visible = false;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(178, 77);
            this.txtDenominacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(200, 20);
            this.txtDenominacion.TabIndex = 9;
            this.txtDenominacion.TextChanged += new System.EventHandler(this.txtDenominacion_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(178, 111);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 51);
            this.txtDescripcion.TabIndex = 7;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnGuardarProducto.Location = new System.Drawing.Point(179, 213);
            this.btnGuardarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(199, 27);
            this.btnGuardarProducto.TabIndex = 1;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Visible = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(178, 165);
            this.txtFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(67, 20);
            this.txtFechaFin.TabIndex = 6;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaProducto
            // 
            this.lblFechaProducto.AutoSize = true;
            this.lblFechaProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblFechaProducto.ForeColor = System.Drawing.Color.Black;
            this.lblFechaProducto.Location = new System.Drawing.Point(4, 166);
            this.lblFechaProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaProducto.Name = "lblFechaProducto";
            this.lblFechaProducto.Size = new System.Drawing.Size(170, 19);
            this.lblFechaProducto.TabIndex = 5;
            this.lblFechaProducto.Text = "Fecha fin de desarrollo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(81, 124);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblDenominacion
            // 
            this.lblDenominacion.AutoSize = true;
            this.lblDenominacion.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblDenominacion.ForeColor = System.Drawing.Color.Black;
            this.lblDenominacion.Location = new System.Drawing.Point(59, 76);
            this.lblDenominacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenominacion.Name = "lblDenominacion";
            this.lblDenominacion.Size = new System.Drawing.Size(115, 19);
            this.lblDenominacion.TabIndex = 3;
            this.lblDenominacion.Text = "Denominación:";
            this.lblDenominacion.Click += new System.EventHandler(this.lblDenominacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grillaProductos);
            this.groupBox1.Location = new System.Drawing.Point(465, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(502, 393);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.AllowUserToDeleteRows = false;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.Denominacion,
            this.Descripcion,
            this.FecFinDesarrollo});
            this.grillaProductos.Location = new System.Drawing.Point(42, 76);
            this.grillaProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.ReadOnly = true;
            this.grillaProductos.RowHeadersWidth = 51;
            this.grillaProductos.RowTemplate.Height = 29;
            this.grillaProductos.Size = new System.Drawing.Size(416, 297);
            this.grillaProductos.TabIndex = 2;
            this.grillaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProductos_CellContentClick);
            // 
            // CodProducto
            // 
            this.CodProducto.DataPropertyName = "CodProducto";
            this.CodProducto.HeaderText = "Código Producto";
            this.CodProducto.MinimumWidth = 6;
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Width = 125;
            // 
            // Denominacion
            // 
            this.Denominacion.DataPropertyName = "Denominacion";
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.MinimumWidth = 6;
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.ReadOnly = true;
            this.Denominacion.Width = 125;
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
            // FecFinDesarrollo
            // 
            this.FecFinDesarrollo.DataPropertyName = "FecFinDesarrollo";
            this.FecFinDesarrollo.HeaderText = "Fecha Fin Desarrollo";
            this.FecFinDesarrollo.MinimumWidth = 6;
            this.FecFinDesarrollo.Name = "FecFinDesarrollo";
            this.FecFinDesarrollo.ReadOnly = true;
            this.FecFinDesarrollo.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Productos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Listado de productos";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(20, 213);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(154, 27);
            this.btnLimpiarCampos.TabIndex = 8;
            this.btnLimpiarCampos.Text = "Nuevo Producto";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnElimOpc
            // 
            this.btnElimOpc.BackColor = System.Drawing.Color.RosyBrown;
            this.btnElimOpc.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnElimOpc.Location = new System.Drawing.Point(20, 337);
            this.btnElimOpc.Margin = new System.Windows.Forms.Padding(2);
            this.btnElimOpc.Name = "btnElimOpc";
            this.btnElimOpc.Size = new System.Drawing.Size(154, 27);
            this.btnElimOpc.TabIndex = 15;
            this.btnElimOpc.Text = "Eliminar Producto";
            this.btnElimOpc.UseVisualStyleBackColor = false;
            this.btnElimOpc.Click += new System.EventHandler(this.btnElimOpc_Click);
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1000, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ABMProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.Label lblFechaProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDenominacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecFinDesarrollo;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnElimOpc;
    }
}
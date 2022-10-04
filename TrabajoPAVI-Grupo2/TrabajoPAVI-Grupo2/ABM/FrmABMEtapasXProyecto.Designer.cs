using System.Windows.Forms;

namespace TrabajoPAVI_Grupo2
{
    partial class FrmABMEtapasXProyecto
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
            this.btnActualizarEtapaXProyecto = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdEtapa = new System.Windows.Forms.Label();
            this.gdrEtapasXProyecto = new System.Windows.Forms.DataGridView();
            this.cod_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblICodProyecto = new System.Windows.Forms.Label();
            this.brnAgregarEtapaXProyecto = new System.Windows.Forms.Button();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiarCamposExP = new System.Windows.Forms.Button();
            this.cmbCodProyecto = new System.Windows.Forms.ComboBox();
            this.btnEliminarEtapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEtapasXProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarEtapaXProyecto
            // 
            this.btnActualizarEtapaXProyecto.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizarEtapaXProyecto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActualizarEtapaXProyecto.Location = new System.Drawing.Point(158, 258);
            this.btnActualizarEtapaXProyecto.Name = "btnActualizarEtapaXProyecto";
            this.btnActualizarEtapaXProyecto.Size = new System.Drawing.Size(112, 58);
            this.btnActualizarEtapaXProyecto.TabIndex = 15;
            this.btnActualizarEtapaXProyecto.Text = "Actualizar Etapa por proyecto";
            this.btnActualizarEtapaXProyecto.UseVisualStyleBackColor = false;
            this.btnActualizarEtapaXProyecto.Click += new System.EventHandler(this.btnActualizarEtapaXProyecto_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(265, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 31);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Etapas por Proyecto";
            // 
            // lblIdEtapa
            // 
            this.lblIdEtapa.AutoSize = true;
            this.lblIdEtapa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdEtapa.Location = new System.Drawing.Point(126, 131);
            this.lblIdEtapa.Name = "lblIdEtapa";
            this.lblIdEtapa.Size = new System.Drawing.Size(57, 21);
            this.lblIdEtapa.TabIndex = 12;
            this.lblIdEtapa.Text = "Etapa:";
            // 
            // gdrEtapasXProyecto
            // 
            this.gdrEtapasXProyecto.AllowUserToAddRows = false;
            this.gdrEtapasXProyecto.AllowUserToDeleteRows = false;
            this.gdrEtapasXProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEtapasXProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_proyecto,
            this.id_etapa,
            this.Fecha_inicio,
            this.Fecha_fin});
            this.gdrEtapasXProyecto.Location = new System.Drawing.Point(423, 86);
            this.gdrEtapasXProyecto.Name = "gdrEtapasXProyecto";
            this.gdrEtapasXProyecto.ReadOnly = true;
            this.gdrEtapasXProyecto.RowTemplate.Height = 25;
            this.gdrEtapasXProyecto.Size = new System.Drawing.Size(392, 280);
            this.gdrEtapasXProyecto.TabIndex = 11;
            this.gdrEtapasXProyecto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEtapasXProyecto_CellClick);
            // 
            // cod_proyecto
            // 
            this.cod_proyecto.DataPropertyName = "cod_proyecto";
            this.cod_proyecto.HeaderText = "Cod Proyecto";
            this.cod_proyecto.Name = "cod_proyecto";
            this.cod_proyecto.ReadOnly = true;
            this.cod_proyecto.Width = 70;
            // 
            // id_etapa
            // 
            this.id_etapa.DataPropertyName = "id_etapa";
            this.id_etapa.HeaderText = "Id Etapa";
            this.id_etapa.Name = "id_etapa";
            this.id_etapa.ReadOnly = true;
            this.id_etapa.Width = 70;
            // 
            // Fecha_inicio
            // 
            this.Fecha_inicio.DataPropertyName = "fecha_inicio";
            this.Fecha_inicio.HeaderText = "Fecha Inicio";
            this.Fecha_inicio.Name = "Fecha_inicio";
            this.Fecha_inicio.ReadOnly = true;
            // 
            // Fecha_fin
            // 
            this.Fecha_fin.DataPropertyName = "fecha_fin";
            this.Fecha_fin.HeaderText = "Fecha Fin";
            this.Fecha_fin.Name = "Fecha_fin";
            this.Fecha_fin.ReadOnly = true;
            // 
            // lblICodProyecto
            // 
            this.lblICodProyecto.AutoSize = true;
            this.lblICodProyecto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblICodProyecto.Location = new System.Drawing.Point(31, 83);
            this.lblICodProyecto.Name = "lblICodProyecto";
            this.lblICodProyecto.Size = new System.Drawing.Size(169, 21);
            this.lblICodProyecto.TabIndex = 9;
            this.lblICodProyecto.Text = "Codigo del proyecto:";
            // 
            // brnAgregarEtapaXProyecto
            // 
            this.brnAgregarEtapaXProyecto.BackColor = System.Drawing.Color.Lime;
            this.brnAgregarEtapaXProyecto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.brnAgregarEtapaXProyecto.Location = new System.Drawing.Point(31, 258);
            this.brnAgregarEtapaXProyecto.Name = "brnAgregarEtapaXProyecto";
            this.brnAgregarEtapaXProyecto.Size = new System.Drawing.Size(108, 58);
            this.brnAgregarEtapaXProyecto.TabIndex = 8;
            this.brnAgregarEtapaXProyecto.Text = "Agregar Etapa por Proyecto";
            this.brnAgregarEtapaXProyecto.UseVisualStyleBackColor = false;
            this.brnAgregarEtapaXProyecto.Click += new System.EventHandler(this.brnAgregarEtapaXProyecto_Click_1);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(193, 186);
            this.txtFechaInicio.Mask = "00/00/0000";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.txtFechaInicio.TabIndex = 16;
            this.txtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Location = new System.Drawing.Point(193, 131);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(168, 21);
            this.cmbEtapa.TabIndex = 17;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicio.Location = new System.Drawing.Point(65, 185);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(128, 21);
            this.lblFechaInicio.TabIndex = 18;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.Location = new System.Drawing.Point(25, 222);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(175, 21);
            this.lblFechaFin.TabIndex = 19;
            this.lblFechaFin.Text = "Fecha de finalización:";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(193, 224);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(86, 20);
            this.txtFechaFin.TabIndex = 20;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpiarCamposExP
            // 
            this.btnLimpiarCamposExP.BackColor = System.Drawing.Color.White;
            this.btnLimpiarCamposExP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpiarCamposExP.Location = new System.Drawing.Point(286, 258);
            this.btnLimpiarCamposExP.Name = "btnLimpiarCamposExP";
            this.btnLimpiarCamposExP.Size = new System.Drawing.Size(108, 58);
            this.btnLimpiarCamposExP.TabIndex = 21;
            this.btnLimpiarCamposExP.Text = "Limpiar Campos";
            this.btnLimpiarCamposExP.UseVisualStyleBackColor = false;
            this.btnLimpiarCamposExP.Click += new System.EventHandler(this.btnLimpiarCamposExP_Click);
            // 
            // cmbCodProyecto
            // 
            this.cmbCodProyecto.FormattingEnabled = true;
            this.cmbCodProyecto.Location = new System.Drawing.Point(193, 83);
            this.cmbCodProyecto.Name = "cmbCodProyecto";
            this.cmbCodProyecto.Size = new System.Drawing.Size(168, 21);
            this.cmbCodProyecto.TabIndex = 22;
            // 
            // btnEliminarEtapa
            // 
            this.btnEliminarEtapa.BackColor = System.Drawing.Color.Red;
            this.btnEliminarEtapa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEliminarEtapa.Location = new System.Drawing.Point(158, 322);
            this.btnEliminarEtapa.Name = "btnEliminarEtapa";
            this.btnEliminarEtapa.Size = new System.Drawing.Size(108, 58);
            this.btnEliminarEtapa.TabIndex = 25;
            this.btnEliminarEtapa.Text = "Eliminar Etapa";
            this.btnEliminarEtapa.UseVisualStyleBackColor = false;
            this.btnEliminarEtapa.Click += new System.EventHandler(this.btnEliminarEtapa_Click);
            // 
            // FrmABMEtapasXProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 390);
            this.Controls.Add(this.btnEliminarEtapa);
            this.Controls.Add(this.cmbCodProyecto);
            this.Controls.Add(this.btnLimpiarCamposExP);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.cmbEtapa);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.btnActualizarEtapaXProyecto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblIdEtapa);
            this.Controls.Add(this.gdrEtapasXProyecto);
            this.Controls.Add(this.lblICodProyecto);
            this.Controls.Add(this.brnAgregarEtapaXProyecto);
            this.MaximizeBox = false;
            this.Name = "FrmABMEtapasXProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormABMEtapasXProyecto";
            this.Load += new System.EventHandler(this.FormABMEtapasXProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEtapasXProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnActualizarEtapaXProyecto;
        private Label lblTitulo;
        private Label lblIdEtapa;
        private DataGridView gdrEtapasXProyecto;
        private Label lblICodProyecto;
        private Button brnAgregarEtapaXProyecto;
        private MaskedTextBox txtFechaInicio;
        private ComboBox cmbEtapa;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private MaskedTextBox txtFechaFin;
        private Button btnLimpiarCamposExP;
        private DataGridViewTextBoxColumn cod_proyecto;
        private DataGridViewTextBoxColumn id_etapa;
        private DataGridViewTextBoxColumn Fecha_inicio;
        private DataGridViewTextBoxColumn Fecha_fin;
        private ComboBox cmbCodProyecto;
        private Button btnEliminarEtapa;
    }
}
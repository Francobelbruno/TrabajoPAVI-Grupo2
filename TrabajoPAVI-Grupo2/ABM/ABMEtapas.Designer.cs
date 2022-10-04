using System.Windows.Forms;

namespace trabajoPAVI_Grupo2
{
    partial class formABMEtapa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.brnAgregarEtapa = new System.Windows.Forms.Button();
            this.lblIdEtapa = new System.Windows.Forms.Label();
            this.txtIdEtapa = new System.Windows.Forms.TextBox();
            this.gdrEtapas = new System.Windows.Forms.DataGridView();
            this.id_etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcionEtapa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnActualizarEtapa = new System.Windows.Forms.Button();
            this.btnLimpiarCamposExP = new System.Windows.Forms.Button();
            this.btnEliminarEtapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // brnAgregarEtapa
            // 
            this.brnAgregarEtapa.BackColor = System.Drawing.Color.Lime;
            this.brnAgregarEtapa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.brnAgregarEtapa.Location = new System.Drawing.Point(33, 191);
            this.brnAgregarEtapa.Name = "brnAgregarEtapa";
            this.brnAgregarEtapa.Size = new System.Drawing.Size(108, 55);
            this.brnAgregarEtapa.TabIndex = 2;
            this.brnAgregarEtapa.Text = "Agregar Etapa";
            this.brnAgregarEtapa.UseVisualStyleBackColor = false;
            this.brnAgregarEtapa.Click += new System.EventHandler(this.btnAgregarEtapa_Click);
            // 
            // lblIdEtapa
            // 
            this.lblIdEtapa.AutoSize = true;
            this.lblIdEtapa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdEtapa.Location = new System.Drawing.Point(93, 87);
            this.lblIdEtapa.Name = "lblIdEtapa";
            this.lblIdEtapa.Size = new System.Drawing.Size(29, 21);
            this.lblIdEtapa.TabIndex = 1;
            this.lblIdEtapa.Text = "Id:";
            // 
            // txtIdEtapa
            // 
            this.txtIdEtapa.Location = new System.Drawing.Point(162, 88);
            this.txtIdEtapa.Name = "txtIdEtapa";
            this.txtIdEtapa.Size = new System.Drawing.Size(50, 20);
            this.txtIdEtapa.TabIndex = 0;
            // 
            // gdrEtapas
            // 
            this.gdrEtapas.AllowUserToAddRows = false;
            this.gdrEtapas.AllowUserToDeleteRows = false;
            this.gdrEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEtapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_etapa,
            this.Descripcion});
            this.gdrEtapas.Location = new System.Drawing.Point(439, 60);
            this.gdrEtapas.Name = "gdrEtapas";
            this.gdrEtapas.ReadOnly = true;
            this.gdrEtapas.RowTemplate.Height = 25;
            this.gdrEtapas.Size = new System.Drawing.Size(301, 280);
            this.gdrEtapas.TabIndex = 6;
            this.gdrEtapas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEtapas_CellClick);
            // 
            // id_etapa
            // 
            this.id_etapa.DataPropertyName = "id_etapa";
            this.id_etapa.HeaderText = "Id";
            this.id_etapa.Name = "id_etapa";
            this.id_etapa.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // txtDescripcionEtapa
            // 
            this.txtDescripcionEtapa.Location = new System.Drawing.Point(162, 131);
            this.txtDescripcionEtapa.Name = "txtDescripcionEtapa";
            this.txtDescripcionEtapa.Size = new System.Drawing.Size(224, 20);
            this.txtDescripcionEtapa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(332, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(83, 31);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Etapas";
            // 
            // btnActualizarEtapa
            // 
            this.btnActualizarEtapa.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizarEtapa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActualizarEtapa.Location = new System.Drawing.Point(166, 191);
            this.btnActualizarEtapa.Name = "btnActualizarEtapa";
            this.btnActualizarEtapa.Size = new System.Drawing.Size(108, 55);
            this.btnActualizarEtapa.TabIndex = 3;
            this.btnActualizarEtapa.Text = "Actualizar Etapa";
            this.btnActualizarEtapa.UseVisualStyleBackColor = false;
            this.btnActualizarEtapa.Click += new System.EventHandler(this.btnActualizarEtapa_Click);
            // 
            // btnLimpiarCamposExP
            // 
            this.btnLimpiarCamposExP.BackColor = System.Drawing.Color.White;
            this.btnLimpiarCamposExP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpiarCamposExP.Location = new System.Drawing.Point(301, 191);
            this.btnLimpiarCamposExP.Name = "btnLimpiarCamposExP";
            this.btnLimpiarCamposExP.Size = new System.Drawing.Size(108, 55);
            this.btnLimpiarCamposExP.TabIndex = 4;
            this.btnLimpiarCamposExP.Text = "Limpiar Campos";
            this.btnLimpiarCamposExP.UseVisualStyleBackColor = false;
            this.btnLimpiarCamposExP.Click += new System.EventHandler(this.btnLimpiarCamposExP_Click);
            // 
            // btnEliminarEtapa
            // 
            this.btnEliminarEtapa.BackColor = System.Drawing.Color.Red;
            this.btnEliminarEtapa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEliminarEtapa.Location = new System.Drawing.Point(166, 264);
            this.btnEliminarEtapa.Name = "btnEliminarEtapa";
            this.btnEliminarEtapa.Size = new System.Drawing.Size(108, 55);
            this.btnEliminarEtapa.TabIndex = 5;
            this.btnEliminarEtapa.Text = "Eliminar Etapa";
            this.btnEliminarEtapa.UseVisualStyleBackColor = false;
            this.btnEliminarEtapa.Click += new System.EventHandler(this.btnEliminarEtapa_Click);
            // 
            // formABMEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 374);
            this.Controls.Add(this.btnEliminarEtapa);
            this.Controls.Add(this.btnLimpiarCamposExP);
            this.Controls.Add(this.btnActualizarEtapa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDescripcionEtapa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdrEtapas);
            this.Controls.Add(this.txtIdEtapa);
            this.Controls.Add(this.lblIdEtapa);
            this.Controls.Add(this.brnAgregarEtapa);
            this.MaximizeBox = false;
            this.Name = "formABMEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario ABM Etapas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button brnAgregarEtapa;
        private Label lblIdEtapa;
        private TextBox txtIdEtapa;
        private DataGridView gdrEtapas;
        private TextBox txtDescripcionEtapa;
        private Label label1;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn id_etapa;
        private DataGridViewTextBoxColumn Descripcion;
        private Button btnActualizarEtapa;
        private Button btnLimpiarCamposExP;
        private Button btnEliminarEtapa;
    }
}
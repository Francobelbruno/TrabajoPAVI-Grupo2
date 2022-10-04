namespace TrabajoPAVI_Grupo2.ABM
{
    partial class ABMHerramientas
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
            this.grpAltaHerr = new System.Windows.Forms.GroupBox();
            this.lblAltaHer = new System.Windows.Forms.Label();
            this.txtAltaHer = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpEliminarHer = new System.Windows.Forms.GroupBox();
            this.mskIDEliminarHer = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminarHer = new System.Windows.Forms.Button();
            this.lblEliminarHer = new System.Windows.Forms.Label();
            this.grdHer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsultarHer = new System.Windows.Forms.GroupBox();
            this.lblConsultaHer = new System.Windows.Forms.Label();
            this.txtConsultaHer = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrilla = new System.Windows.Forms.Button();
            this.grpAltaHerr.SuspendLayout();
            this.grpEliminarHer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHer)).BeginInit();
            this.grpConsultarHer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAltaHerr
            // 
            this.grpAltaHerr.Controls.Add(this.lblAltaHer);
            this.grpAltaHerr.Controls.Add(this.txtAltaHer);
            this.grpAltaHerr.Controls.Add(this.btnGuardar);
            this.grpAltaHerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.grpAltaHerr.Location = new System.Drawing.Point(12, 198);
            this.grpAltaHerr.Name = "grpAltaHerr";
            this.grpAltaHerr.Size = new System.Drawing.Size(393, 160);
            this.grpAltaHerr.TabIndex = 17;
            this.grpAltaHerr.TabStop = false;
            this.grpAltaHerr.Text = "Alta Herramienta";
            // 
            // lblAltaHer
            // 
            this.lblAltaHer.AutoSize = true;
            this.lblAltaHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAltaHer.Location = new System.Drawing.Point(18, 51);
            this.lblAltaHer.Name = "lblAltaHer";
            this.lblAltaHer.Size = new System.Drawing.Size(177, 20);
            this.lblAltaHer.TabIndex = 1;
            this.lblAltaHer.Text = "Nombre herramienta:";
            // 
            // txtAltaHer
            // 
            this.txtAltaHer.Location = new System.Drawing.Point(201, 51);
            this.txtAltaHer.Name = "txtAltaHer";
            this.txtAltaHer.Size = new System.Drawing.Size(186, 32);
            this.txtAltaHer.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(133, 102);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 36);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // grpEliminarHer
            // 
            this.grpEliminarHer.Controls.Add(this.mskIDEliminarHer);
            this.grpEliminarHer.Controls.Add(this.btnEliminarHer);
            this.grpEliminarHer.Controls.Add(this.lblEliminarHer);
            this.grpEliminarHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.grpEliminarHer.Location = new System.Drawing.Point(12, 394);
            this.grpEliminarHer.Name = "grpEliminarHer";
            this.grpEliminarHer.Size = new System.Drawing.Size(393, 107);
            this.grpEliminarHer.TabIndex = 19;
            this.grpEliminarHer.TabStop = false;
            this.grpEliminarHer.Text = "Eliminar herramienta";
            // 
            // mskIDEliminarHer
            // 
            this.mskIDEliminarHer.Location = new System.Drawing.Point(155, 39);
            this.mskIDEliminarHer.Mask = "9999";
            this.mskIDEliminarHer.Name = "mskIDEliminarHer";
            this.mskIDEliminarHer.Size = new System.Drawing.Size(60, 32);
            this.mskIDEliminarHer.TabIndex = 7;
            this.mskIDEliminarHer.ValidatingType = typeof(int);
            // 
            // btnEliminarHer
            // 
            this.btnEliminarHer.BackColor = System.Drawing.Color.Red;
            this.btnEliminarHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHer.Location = new System.Drawing.Point(261, 27);
            this.btnEliminarHer.Name = "btnEliminarHer";
            this.btnEliminarHer.Size = new System.Drawing.Size(106, 60);
            this.btnEliminarHer.TabIndex = 16;
            this.btnEliminarHer.Text = "Eliminar herramienta";
            this.btnEliminarHer.UseVisualStyleBackColor = false;
            this.btnEliminarHer.Click += new System.EventHandler(this.btnEliminarHer_Click_1);
            // 
            // lblEliminarHer
            // 
            this.lblEliminarHer.AutoSize = true;
            this.lblEliminarHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEliminarHer.Location = new System.Drawing.Point(15, 46);
            this.lblEliminarHer.Name = "lblEliminarHer";
            this.lblEliminarHer.Size = new System.Drawing.Size(134, 20);
            this.lblEliminarHer.TabIndex = 6;
            this.lblEliminarHer.Text = "ID herramienta:";
            // 
            // grdHer
            // 
            this.grdHer.AllowUserToAddRows = false;
            this.grdHer.AllowUserToDeleteRows = false;
            this.grdHer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.herramienta});
            this.grdHer.Location = new System.Drawing.Point(434, 63);
            this.grdHer.Name = "grdHer";
            this.grdHer.ReadOnly = true;
            this.grdHer.Size = new System.Drawing.Size(389, 378);
            this.grdHer.TabIndex = 18;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_herramienta";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // herramienta
            // 
            this.herramienta.DataPropertyName = "descripcion";
            this.herramienta.HeaderText = "herramienta";
            this.herramienta.Name = "herramienta";
            this.herramienta.ReadOnly = true;
            this.herramienta.Width = 300;
            // 
            // grpConsultarHer
            // 
            this.grpConsultarHer.Controls.Add(this.btnGrilla);
            this.grpConsultarHer.Controls.Add(this.lblConsultaHer);
            this.grpConsultarHer.Controls.Add(this.txtConsultaHer);
            this.grpConsultarHer.Controls.Add(this.btnBuscar);
            this.grpConsultarHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.grpConsultarHer.Location = new System.Drawing.Point(12, 12);
            this.grpConsultarHer.Name = "grpConsultarHer";
            this.grpConsultarHer.Size = new System.Drawing.Size(393, 160);
            this.grpConsultarHer.TabIndex = 16;
            this.grpConsultarHer.TabStop = false;
            this.grpConsultarHer.Text = "Buscar Herramienta";
            // 
            // lblConsultaHer
            // 
            this.lblConsultaHer.AutoSize = true;
            this.lblConsultaHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblConsultaHer.Location = new System.Drawing.Point(18, 51);
            this.lblConsultaHer.Name = "lblConsultaHer";
            this.lblConsultaHer.Size = new System.Drawing.Size(177, 20);
            this.lblConsultaHer.TabIndex = 1;
            this.lblConsultaHer.Text = "Nombre herramienta:";
            // 
            // txtConsultaHer
            // 
            this.txtConsultaHer.Location = new System.Drawing.Point(201, 51);
            this.txtConsultaHer.Name = "txtConsultaHer";
            this.txtConsultaHer.Size = new System.Drawing.Size(186, 32);
            this.txtConsultaHer.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(133, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 36);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnGrilla
            // 
            this.btnGrilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrilla.Location = new System.Drawing.Point(261, 102);
            this.btnGrilla.Name = "btnGrilla";
            this.btnGrilla.Size = new System.Drawing.Size(90, 36);
            this.btnGrilla.TabIndex = 12;
            this.btnGrilla.Text = "Mostrar";
            this.btnGrilla.UseVisualStyleBackColor = false;
            this.btnGrilla.Click += new System.EventHandler(this.btnGrilla_Click);
            // 
            // ABMHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 520);
            this.Controls.Add(this.grpAltaHerr);
            this.Controls.Add(this.grpEliminarHer);
            this.Controls.Add(this.grdHer);
            this.Controls.Add(this.grpConsultarHer);
            this.MaximizeBox = false;
            this.Name = "ABMHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMHerramientas";
            this.Load += new System.EventHandler(this.ABMHerramientas_Load);
            this.grpAltaHerr.ResumeLayout(false);
            this.grpAltaHerr.PerformLayout();
            this.grpEliminarHer.ResumeLayout(false);
            this.grpEliminarHer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHer)).EndInit();
            this.grpConsultarHer.ResumeLayout(false);
            this.grpConsultarHer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAltaHerr;
        private System.Windows.Forms.Label lblAltaHer;
        private System.Windows.Forms.TextBox txtAltaHer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpEliminarHer;
        private System.Windows.Forms.MaskedTextBox mskIDEliminarHer;
        private System.Windows.Forms.Button btnEliminarHer;
        private System.Windows.Forms.Label lblEliminarHer;
        private System.Windows.Forms.DataGridView grdHer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn herramienta;
        private System.Windows.Forms.GroupBox grpConsultarHer;
        private System.Windows.Forms.Label lblConsultaHer;
        private System.Windows.Forms.TextBox txtConsultaHer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrilla;
    }
}
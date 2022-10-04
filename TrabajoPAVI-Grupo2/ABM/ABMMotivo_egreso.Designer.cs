namespace TrabajoPAVI_Grupo2.ABM
{
    partial class ABMMotivo_egreso
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpEliminarMotivo = new System.Windows.Forms.GroupBox();
            this.mskIDEliminar = new System.Windows.Forms.MaskedTextBox();
            this.lblIDEliminar = new System.Windows.Forms.Label();
            this.grdMotEgr = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo_egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroIDMotEgre = new System.Windows.Forms.TextBox();
            this.lblIdMotEgre = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotEgre = new System.Windows.Forms.TextBox();
            this.grpEliminarMotivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMotEgr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(111, 478);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 50);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar motivo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // grpEliminarMotivo
            // 
            this.grpEliminarMotivo.Controls.Add(this.mskIDEliminar);
            this.grpEliminarMotivo.Controls.Add(this.lblIDEliminar);
            this.grpEliminarMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.grpEliminarMotivo.Location = new System.Drawing.Point(30, 370);
            this.grpEliminarMotivo.Name = "grpEliminarMotivo";
            this.grpEliminarMotivo.Size = new System.Drawing.Size(277, 92);
            this.grpEliminarMotivo.TabIndex = 15;
            this.grpEliminarMotivo.TabStop = false;
            this.grpEliminarMotivo.Text = "Eliminar motivo";
            // 
            // mskIDEliminar
            // 
            this.mskIDEliminar.Location = new System.Drawing.Point(116, 39);
            this.mskIDEliminar.Mask = "000";
            this.mskIDEliminar.Name = "mskIDEliminar";
            this.mskIDEliminar.Size = new System.Drawing.Size(60, 32);
            this.mskIDEliminar.TabIndex = 7;
            this.mskIDEliminar.ValidatingType = typeof(int);
            // 
            // lblIDEliminar
            // 
            this.lblIDEliminar.AutoSize = true;
            this.lblIDEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIDEliminar.Location = new System.Drawing.Point(43, 39);
            this.lblIDEliminar.Name = "lblIDEliminar";
            this.lblIDEliminar.Size = new System.Drawing.Size(66, 20);
            this.lblIDEliminar.TabIndex = 6;
            this.lblIDEliminar.Text = "Nro ID:";
            // 
            // grdMotEgr
            // 
            this.grdMotEgr.AllowUserToAddRows = false;
            this.grdMotEgr.AllowUserToDeleteRows = false;
            this.grdMotEgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMotEgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.motivo_egreso});
            this.grdMotEgr.Location = new System.Drawing.Point(354, 84);
            this.grdMotEgr.Name = "grdMotEgr";
            this.grdMotEgr.ReadOnly = true;
            this.grdMotEgr.Size = new System.Drawing.Size(389, 378);
            this.grdMotEgr.TabIndex = 14;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_motivo";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // motivo_egreso
            // 
            this.motivo_egreso.DataPropertyName = "descripcion";
            this.motivo_egreso.HeaderText = "motivo_egreso";
            this.motivo_egreso.Name = "motivo_egreso";
            this.motivo_egreso.ReadOnly = true;
            this.motivo_egreso.Width = 300;
            // 
            // txtNroIDMotEgre
            // 
            this.txtNroIDMotEgre.Enabled = false;
            this.txtNroIDMotEgre.Location = new System.Drawing.Point(146, 18);
            this.txtNroIDMotEgre.Name = "txtNroIDMotEgre";
            this.txtNroIDMotEgre.ReadOnly = true;
            this.txtNroIDMotEgre.Size = new System.Drawing.Size(100, 20);
            this.txtNroIDMotEgre.TabIndex = 9;
            // 
            // lblIdMotEgre
            // 
            this.lblIdMotEgre.AutoSize = true;
            this.lblIdMotEgre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdMotEgre.Location = new System.Drawing.Point(73, 19);
            this.lblIdMotEgre.Name = "lblIdMotEgre";
            this.lblIdMotEgre.Size = new System.Drawing.Size(66, 20);
            this.lblIdMotEgre.TabIndex = 13;
            this.lblIdMotEgre.Text = "Nro ID:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(30, 296);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 50);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar Campo";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(196, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 36);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotEgre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 200);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo de Egreso";
            // 
            // txtMotEgre
            // 
            this.txtMotEgre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMotEgre.Location = new System.Drawing.Point(18, 31);
            this.txtMotEgre.Multiline = true;
            this.txtMotEgre.Name = "txtMotEgre";
            this.txtMotEgre.Size = new System.Drawing.Size(256, 147);
            this.txtMotEgre.TabIndex = 1;
            // 
            // ABMMotivo_egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 549);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grpEliminarMotivo);
            this.Controls.Add(this.grdMotEgr);
            this.Controls.Add(this.txtNroIDMotEgre);
            this.Controls.Add(this.lblIdMotEgre);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ABMMotivo_egreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMMotivo_egreso";
            this.grpEliminarMotivo.ResumeLayout(false);
            this.grpEliminarMotivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMotEgr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpEliminarMotivo;
        private System.Windows.Forms.MaskedTextBox mskIDEliminar;
        private System.Windows.Forms.Label lblIDEliminar;
        private System.Windows.Forms.DataGridView grdMotEgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo_egreso;
        private System.Windows.Forms.TextBox txtNroIDMotEgre;
        private System.Windows.Forms.Label lblIdMotEgre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMotEgre;
    }
}
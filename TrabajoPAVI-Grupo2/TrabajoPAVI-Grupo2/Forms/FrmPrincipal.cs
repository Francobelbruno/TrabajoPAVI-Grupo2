using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPAV1;
using trabajoPAVI_Grupo2;
using TrabajoPAVI_Grupo2.ABM;
using TrabajoPAVI_Grupo2.Entidades;

namespace TrabajoPAVI_Grupo2.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(Usuario usu)
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aBMBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBarrios altaBarrios = new FrmBarrios();
            altaBarrios.Show();
        }

        private void aBMPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMPersonal altaPersonal = new FrmABMPersonal();
            altaPersonal.Show();
        }

        private void aBMEtapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formABMEtapa altaEtapas = new formABMEtapa();
            altaEtapas.Show();
        }

        private void aBMProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProductos altaProductos = new ABMProductos();
            altaProductos.Show();
        }

        private void aBMProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProyecto altaProyecto = new ABMProyecto();
            altaProyecto.Show();
        }

        private void aBMEtapasXProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMEtapasXProyecto altaEtapaxProy = new FrmABMEtapasXProyecto();
            altaEtapaxProy.Show();
        }

        private void aBMClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmClientes altaClientes = new abmClientes();
            altaClientes.Show();
        }



    }
}

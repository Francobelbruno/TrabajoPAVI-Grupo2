using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}

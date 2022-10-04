using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPAVI_Grupo2
{
    public partial class SolicitarID : Form
    {
        string idClt;
        string descr;
        string fechIn;

        public SolicitarID(string id, string desc, string fecha)
        {
            idClt = id;
            descr = desc;
            fechIn = fecha;
            InitializeComponent();
        }

        private void SolicitarID_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdProy.Text.Equals(" "))
            {
                MessageBox.Show("El ID no puede estar vacio!");
                txtIdProy.Focus();
            }
            else
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);


                try
                {

                    SqlCommand cmd = new SqlCommand();

                    string consulta = "UPDATE Proyectos SET Descripcion = @Descripcion, IdCliente = @IdCliente, FecInicio = @FecInicio WHERE CodProyecto = @idProy";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idProy", txtIdProy.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", descr);
                    cmd.Parameters.AddWithValue("@IdCLiente", idClt);
                    cmd.Parameters.AddWithValue("@FecInicio", fechIn);


                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proyecto modificado con exito");

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al modificar proyecto");
                    throw;
                }
                finally
                {
                    this.Hide();
                    cn.Close();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

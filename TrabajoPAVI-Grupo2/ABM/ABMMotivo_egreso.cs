using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrabajoPAVI_Grupo2.ABM
{
    public partial class ABMMotivo_egreso : Form
    {
        public ABMMotivo_egreso()
        {
            InitializeComponent();
        }


        private void ABMMotivo_egreso_Load_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaBD);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM MOTIVO_EGRESOS";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdMotEgr.DataSource = tabla;

                txtNroIDMotEgre.Text = (tabla.Rows.Count + 1).ToString();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void BorrarCampos()
        {
            txtMotEgre.Text = "";
            txtEliminar.Text = "";
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtMotEgre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el motivo");
                txtMotEgre.Focus();
            }
            else
            {
                string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaBD);

                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "INSERT INTO MOTIVO_EGRESOS (descripcion) VALUES (@motivo)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@motivo", txtMotEgre.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    cn.Close();
                }
            }

            BorrarCampos();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMotivo();
        }

        private void EliminarMotivo()
        {
            if (txtEliminar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un ID válido para eliminar");
                txtEliminar.Focus();
            }
            else
            {
                string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaBD);

                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "DELETE FROM MOTIVO_EGRESOS WHERE id_motivo = @id_motivo";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id_motivo", txtEliminar.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    cn.Close();
                }
            }
            BorrarCampos();
            CargarGrilla();
        }
    }
        
   
}

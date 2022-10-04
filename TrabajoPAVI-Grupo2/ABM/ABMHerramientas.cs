using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrabajoPAVI_Grupo2.ABM
{
    public partial class ABMHerramientas : Form
    {
        public ABMHerramientas()
        {
            InitializeComponent();
        }

        private void ABMHerramientas_Load(object sender, EventArgs e)
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

                string consulta = "SELECT * FROM HERRAMIENTAS ORDER BY id_herramienta";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grdHer.DataSource = tabla;


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
            txtAltaHer.Text = "";
            txtConsultaHer.Text = "";
            mskIDEliminarHer.Text = "";
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaBD);

            if (txtAltaHer.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una herramienta válida para registrar");
                txtAltaHer.Focus();
            }
            else
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "INSERT INTO HERRAMIENTAS (descripcion) VALUES (@herramienta)";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@herramienta", txtAltaHer.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Herramienta cargada con éxito");
                    BorrarCampos();
                    CargarGrilla();

                }
                catch (ArgumentException ex)
                {
                    throw;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnEliminarHer_Click_1(object sender, EventArgs e)
        {
            string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaBD);

            if (mskIDEliminarHer.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un id válido para eliminar");
                mskIDEliminarHer.Focus();
            }
            else
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "DElETE FROM HERRAMIENTAS WHERE id_herramienta = @id";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@id", mskIDEliminarHer.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Herramienta eliminada con éxito");
                    BorrarCampos();
                    CargarGrilla();

                }
                catch (ArgumentException ex)
                {
                    throw;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaBD);

            if (txtConsultaHer.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una palabra o frase para buscar");
                txtConsultaHer.Focus();
            }
            else
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "SELECT * FROM HERRAMIENTAS WHERE descripcion like @patron";

                    cmd.Parameters.Clear();

                    string parametro = "%" + txtConsultaHer.Text + "%";
                    Console.WriteLine(parametro);

                    cmd.Parameters.AddWithValue("@patron", parametro);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    grdHer.DataSource = tabla;

                }
                catch (ArgumentException ex)
                {
                    throw;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnGrilla_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
